using CppSharp;
using CppSharp.AST;
using CppSharp.Passes;
using System;
using System.IO;
using System.Linq;

namespace Mono
{
    class LLDBSharpGen : ILibrary
    {
        const string LLDBPath = @"/Users/joao/Dev/llvm/tools/lldb/include/";

        public void Setup(Driver driver)
        {
            var options = driver.Options;
            options.LibraryName = "lldb";
            options.OutputDir = "LLDBSharp";
            options.Verbose = false;
            options.GenerateLibraryNamespace = false;

            if (Platform.IsMacOS) {
                options.SetupXcode ();
                options.TargetTriple = "i686-apple-darwin12.4.0";
            }

            options.addIncludeDirs(Path.GetFullPath(LLDBPath));
            options.Headers.Add("lldb/lldb-defines.h");
            options.Headers.Add("lldb/API/LLDB.h");

            options.GenerateProperties = true;
        }

        public void SetupPasses(Driver driver)
        {
            driver.TranslationUnitPasses.RemovePrefix("SB");
            driver.AddTranslationUnitPass (new FixEnumsName ());
        }

        public void Preprocess(Driver driver, ASTContext ctx)
        {
            ctx.IgnoreHeadersWithName("lldb/lldb-forward.h");
            ctx.IgnoreHeadersWithName("lldb/API/SBDefines.h");

            //ctx.SetMethodParameterUsage("lldb::SBTarget", "LaunchSimple", 1, ParameterUsage.Out);
            //ctx.SetMethodParameterUsage("lldb::SBTarget", "Launch", 9, ParameterUsage.Out);

            ctx.RemoveEnumItemsPrefix ("lldb::StateType", "eState");
            ctx.RemoveEnumItemsPrefix ("lldb::LaunchFlags", "eLaunchFlag");
            ctx.RemoveEnumItemsPrefix ("lldb::RunMode", "e");
            ctx.RemoveEnumItemsPrefix ("lldb::ExpressionResults", "eExpression");
            ctx.RemoveEnumItemsPrefix ("lldb::SymbolContextItem", "eSymbolContext");
            ctx.RemoveEnumItemsPrefix ("lldb::InputReaderAction", "eInputReader");
            ctx.RemoveEnumItemsPrefix ("lldb::DynamicValueType", "e");
            ctx.RemoveEnumItemsPrefix ("lldb::InputReaderAction", "eInputReader");
            ctx.RemoveEnumItemsPrefix ("lldb::AccessType", "eAccess");
            ctx.RemoveEnumItemsPrefix ("lldb::CommandArgumentType", "eArgType");
            ctx.RemoveEnumItemsPrefix ("lldb::EmulateInstructionOptions", "eEmulateInstructionOption");
            ctx.RemoveEnumItemsPrefix ("lldb::TypeOptions", "eTypeOption");
            ctx.RemoveEnumItemsPrefix ("lldb::FrameComparison", "eFrameCompare");
            ctx.RemoveEnumItemsPrefix ("lldb::ExpressionEvaluationPhase", "eExpressionEvaluation");
            ctx.RemoveEnumItemsPrefix ("lldb::TypeFlags", "eType");
            ctx.RemoveEnumItemsPrefix ("lldb::CommandFlags", "eCommand");
            ctx.RemoveEnumItemsPrefix ("lldb::TypeSummaryCapping", "eTypeSummary");

            ctx.SetNameOfClassMethod ("lldb::SBError", "GetError", "GetErrorCode");
            ctx.SetNameOfClassMethod ("lldb::SBValue", "GetValue", "GetValueAsString");

            ctx.GenerateEnumFromMacros ("BreakpointId", "LLDB_BREAK_*", "LLDB_INVALID_BREAK_ID",
                "LLDB_DEFAULT_BREAK_SIZE");
            ctx.GenerateEnumFromMacros ("WatchpointId", "LLDB_WATCH_*", "LLDB_INVALID_WATCH_ID");
            ctx.GenerateEnumFromMacros ("GenericRegister", "LLDB_REGNUM_GENERIC_*");
            ctx.GenerateEnumFromMacros ("InvalidValue", "LLDB_INVALID_*");
            ctx.GenerateEnumFromMacros ("CPUType", "LLDB_ARCH_*", "LLDB_INVALID_CPUTYPE");
            ctx.GenerateEnumFromMacros ("OptionSet", "LDB_OPT_SET_*", "LLDB_MAX_NUM_OPTION_SETS");

            ctx.RenameNamespace("lldb", "LLDB");
        }

        public void Postprocess(Driver driver, ASTContext ctx)
        {
        }

        static class Program
        {
            public static void Main(string[] args)
            {
                ConsoleDriver.Run(new LLDBSharpGen());
            }
        }
    }

    public static class ASTExtensions
    {
        public static void RemoveEnumItemsPrefix(this ASTContext ctx, string enumName, string prefix)
        {
            var @enum = ctx.FindEnum(enumName).FirstOrDefault();
            if (@enum == null)
                return;

            if (@enum.Items.Count == 0)
                return;

            foreach (var item in @enum.Items)
            {
                if (!item.Name.StartsWith (prefix))
                    continue;
                
                item.Name = item.Name.Substring (prefix.Length);
            }
        }
    }

    public class FixEnumsName : TranslationUnitPass
    {
        public override bool VisitEnumDecl (Enumeration @enum)
        {
            if (@enum.Items.Count == 0)
                return base.VisitEnumDecl (@enum);

            string enumPrefix = "e" + @enum.Name;
            if (!@enum.Items[0].Name.StartsWith (enumPrefix))
                return base.VisitEnumDecl (@enum);

            foreach (var item in @enum.Items)
                item.Name = item.Name.Substring (enumPrefix.Length);

            return base.VisitEnumDecl (@enum);
        }
    }
}

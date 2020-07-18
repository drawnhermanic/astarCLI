using System;
using System.Collections.Generic;
using CommandLine;
using CommandLine.Text;

namespace Example
{
    public class FileOptions
    {
        [Option('i', "Input", Required = false, HelpText = "Path to file input")]
        public string InputFile { get; set; }

        [Option('o', "Output", Required = false, HelpText = "Path to file output")]
        public string OutputFile { get; set; }

        [Usage(ApplicationAlias = "Building Calculator")]
        public static IEnumerable<CommandLine.Text.Example> Examples
        {
            get
            {
                yield return new CommandLine.Text.Example("Normal scenario", new FileOptions { InputFile = "in.json", OutputFile = "out.json" });
            }
        }
    }

    public class JsonOptions
    {
        [Option('i', "Input", Required = true, HelpText = "Array of site inputs")]
        public string Input { get; set; }

        [Usage(ApplicationAlias = "Building Calculator")]
        public static IEnumerable<CommandLine.Text.Example> Examples
        {
            get
            {
                yield return new CommandLine.Text.Example("JSON input with array of site configurations", new JsonOptions { Input = "[]" });
            }
        }
    }
}

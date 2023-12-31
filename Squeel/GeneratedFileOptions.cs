﻿using System.Reflection;

namespace Squeel;

internal static class GeneratedFileOptions
{
    public static readonly Version Version = typeof(GeneratedFileOptions).Assembly.GetName().Version;
    public static readonly string AssemblyName = typeof(GeneratedFileOptions).Assembly.GetName().Name;

    public static readonly string Header = $"""
        // <auto-generated>
        //   This file was generated by the source generator {AssemblyName}
        //   
        //   Version      {Version}
        //   SHA          {typeof(GeneratedFileOptions).Assembly.GetCustomAttribute<AssemblyMetadataAttribute>()?.Value}
        //   Repository   https://github.com/S-E-F/Squeel
        // </auto-generated>
        """;

    public static readonly string Attribute = $"""
        [global::System.CodeDom.Compiler.GeneratedCode("{AssemblyName}", "{Version}")]
        """;
}

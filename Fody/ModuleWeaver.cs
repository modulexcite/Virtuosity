﻿using System;
using Mono.Cecil;

public partial class ModuleWeaver
{
    public Action<string> LogInfo { get; set; }
    public ModuleDefinition ModuleDefinition { get; set; }

    public ModuleWeaver()
    {
        LogInfo = s => { };
    }

    public void Execute()
    {
        ReadConfig();
        ProcessIncludesExcludes();
        ProcessAssembly();
        ConvertCallToCallVirtual();
        ConvertNewToOverrides();
        ConvertFunctionPointer();
    }
}
// Copyright 1998-2019 Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.IO;

public class MODULENAME: ModuleRules
{
    private string ThirdPartyPath
    {
        get { return Path.GetFullPath(Path.Combine(ModuleDirectory, "../../ThirdParty")); }
    }

    public MODULENAME(ReadOnlyTargetRules Target) : base(Target)
    {
        bEnableUndefinedIdentifierWarnings = false;

        PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

        PublicDependencyModuleNames.AddRange(new string[]
            {"Core", "CoreUObject", "Engine", "InputCore", "HeadMountedDisplay", "RHI"});

        string OpenCVPath = Path.Combine(ThirdPartyPath, "OpenCV");

        if (Target.Platform == UnrealTargetPlatform.Win64)
        {
            string OpenCVIncludePath = Path.Combine(OpenCVPath, "Includes");
            string OpenCVLibPath = Path.Combine(OpenCVPath, "Libraries", "Win64");

            PublicIncludePaths.Add(OpenCVIncludePath);

            //Add Static Libraries
            PublicAdditionalLibraries.Add(Path.Combine(OpenCVLibPath, "opencv_world320.lib"));

            //Add Dynamic Libraries
            PublicDelayLoadDLLs.Add("opencv_world320.dll");
            PublicDelayLoadDLLs.Add("opencv_ffmpeg320_64.dll");
        }
    }
}

// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;

public class UE4Steam : ModuleRules
{
	public UE4Steam(ReadOnlyTargetRules Target) : base(Target)
	{
		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore" });

		PrivateDependencyModuleNames.AddRange(new string[] {  });

        PrivatePCHHeaderFile = "UE4Steam.h";

        // Uncomment if you are using Slate UI
        // PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });


        // Uncomment if you are using online features
        PrivateDependencyModuleNames.Add("OnlineSubsystem");
  //PrivateDependencyModuleNames.Add("OnlineSubsystemUtils");
  
	// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
    }
}

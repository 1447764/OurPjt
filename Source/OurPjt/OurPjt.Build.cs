// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class OurPjt : ModuleRules
{
	public OurPjt(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"OurPjt",
			"OurPjt/Variant_Platforming",
			"OurPjt/Variant_Platforming/Animation",
			"OurPjt/Variant_Combat",
			"OurPjt/Variant_Combat/AI",
			"OurPjt/Variant_Combat/Animation",
			"OurPjt/Variant_Combat/Gameplay",
			"OurPjt/Variant_Combat/Interfaces",
			"OurPjt/Variant_Combat/UI",
			"OurPjt/Variant_SideScrolling",
			"OurPjt/Variant_SideScrolling/AI",
			"OurPjt/Variant_SideScrolling/Gameplay",
			"OurPjt/Variant_SideScrolling/Interfaces",
			"OurPjt/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}

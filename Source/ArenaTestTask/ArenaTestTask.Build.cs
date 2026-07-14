// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class ArenaTestTask : ModuleRules
{
	public ArenaTestTask(ReadOnlyTargetRules Target) : base(Target)
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
			"ArenaTestTask",
			"ArenaTestTask/Variant_Platforming",
			"ArenaTestTask/Variant_Platforming/Animation",
			"ArenaTestTask/Variant_Combat",
			"ArenaTestTask/Variant_Combat/AI",
			"ArenaTestTask/Variant_Combat/Animation",
			"ArenaTestTask/Variant_Combat/Gameplay",
			"ArenaTestTask/Variant_Combat/Interfaces",
			"ArenaTestTask/Variant_Combat/UI",
			"ArenaTestTask/Variant_SideScrolling",
			"ArenaTestTask/Variant_SideScrolling/AI",
			"ArenaTestTask/Variant_SideScrolling/Gameplay",
			"ArenaTestTask/Variant_SideScrolling/Interfaces",
			"ArenaTestTask/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}

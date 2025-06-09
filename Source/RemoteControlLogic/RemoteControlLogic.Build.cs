// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class RemoteControlLogic : ModuleRules
{
	public RemoteControlLogic(ReadOnlyTargetRules Target) : base(Target)
	{
		PublicDependencyModuleNames.AddRange(
			new string[] {
				"Core",
				"CoreUObject",
			}
		);

		PrivateDependencyModuleNames.AddRange(
			new string[] {
				"AssetRegistry",
				"Cbor",
				"Engine",
				"HTTP",
				"ImageCore",
				"RemoteControl",
				"RenderCore",
				"RHI",
				"Serialization",
			}
		);
		
		if (Target.bBuildEditor)
		{
			PrivateDependencyModuleNames.AddRange(
				new string[] {
					"UnrealEd",
				}
			);
		}
	}
}

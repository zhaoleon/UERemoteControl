// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class WebRemoteControl : ModuleRules
{
	public WebRemoteControl(ReadOnlyTargetRules Target) : base(Target)
	{
		PublicDependencyModuleNames.AddRange(
			new string[] {
				"Core",
				"CoreUObject",
				"HTTPServer",
				"Serialization",
				"WebSocketNetworking",
				"AssetRegistry",
				"HTTP",
				"Networking",
				"RemoteControl",
				"RemoteControlCommon",
				"RemoteControlLogic",
				"Sockets"
			}
		);

        PrivateDependencyModuleNames.AddRange(
			new string[] {

			}
        );

		if (Target.Type == TargetType.Editor)
		{
			PrivateDependencyModuleNames.AddRange(
				new string[] {
					"DeveloperSettings",
					"Engine",
					"ImageWrapper",
					"RemoteControlUI",
					"Settings",
					"SharedSettingsWidgets",
					"Slate",
					"SlateCore",
					"SourceControl",
					"UnrealEd",
				}
			);
		}
	}
}

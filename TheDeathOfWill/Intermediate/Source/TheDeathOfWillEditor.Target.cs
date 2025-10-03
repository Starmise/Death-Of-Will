using UnrealBuildTool;

public class TheDeathOfWillEditorTarget : TargetRules
{
	public TheDeathOfWillEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("TheDeathOfWill");
	}
}

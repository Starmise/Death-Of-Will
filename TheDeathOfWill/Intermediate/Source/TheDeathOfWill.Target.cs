using UnrealBuildTool;

public class TheDeathOfWillTarget : TargetRules
{
	public TheDeathOfWillTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("TheDeathOfWill");
	}
}

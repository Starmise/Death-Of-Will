using UnrealBuildTool;

public class TheDeathOfWillServerTarget : TargetRules
{
	public TheDeathOfWillServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("TheDeathOfWill");
	}
}

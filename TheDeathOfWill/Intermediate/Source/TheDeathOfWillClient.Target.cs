using UnrealBuildTool;

public class TheDeathOfWillClientTarget : TargetRules
{
	public TheDeathOfWillClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("TheDeathOfWill");
	}
}

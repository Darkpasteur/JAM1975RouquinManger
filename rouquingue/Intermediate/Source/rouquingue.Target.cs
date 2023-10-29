using UnrealBuildTool;

public class rouquingueTarget : TargetRules
{
	public rouquingueTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;
		Type = TargetType.Game;
		ExtraModuleNames.Add("rouquingue");
	}
}

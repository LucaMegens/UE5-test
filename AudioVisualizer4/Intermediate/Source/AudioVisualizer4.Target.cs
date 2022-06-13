using UnrealBuildTool;

public class AudioVisualizer4Target : TargetRules
{
	public AudioVisualizer4Target(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;
		Type = TargetType.Game;
		ExtraModuleNames.Add("AudioVisualizer4");
	}
}

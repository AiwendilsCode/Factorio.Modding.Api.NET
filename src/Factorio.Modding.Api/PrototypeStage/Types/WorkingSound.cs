using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("WorkingSound")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class WorkingSound 
{
    [InLua("activate_sound")]
    public Sound? ActivateSound { get; set; }
	[InLua("apparent_volume")]
    public float? ApparentVolume { get; set; }
	[InLua("audible_distance_modifier")]
    public double? AudibleDistanceModifier { get; set; }
	[InLua("deactivate_sound")]
    public Sound? DeactivateSound { get; set; }
	[InLua("fade_in_ticks")]
    public uint? FadeInTicks { get; set; }
	[InLua("fade_out_ticks")]
    public uint? FadeOutTicks { get; set; }
	[InLua("idle_sound")]
    public Sound? IdleSound { get; set; }
	[InLua("match_progress_to_activity")]
    public bool? MatchProgressToActivity { get; set; }
	[InLua("match_speed_to_activity")]
    public bool? MatchSpeedToActivity { get; set; }
	[InLua("match_volume_to_activity")]
    public bool? MatchVolumeToActivity { get; set; }
	[InLua("max_sounds_per_type")]
    public byte? MaxSoundsPerType { get; set; }
	[InLua("persistent")]
    public bool? Persistent { get; set; }
	[InLua("probability")]
    public double? Probability { get; set; }
	[InLua("sound")]
    public Sound Sound { get; set; }
	[InLua("use_doppler_shift")]
    public bool? UseDopplerShift { get; set; }

    
    
    public WorkingSound() {}
    private WorkingSound(Sound value)
    {
        Sound = value;
    }

    public static implicit operator WorkingSound(Sound value) => new(value);

    
}
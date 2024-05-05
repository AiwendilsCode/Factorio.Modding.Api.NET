using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("PlaySoundTriggerEffectItem")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class PlaySoundTriggerEffectItem : TriggerEffectItem
{
    [InLua("audible_distance_modifier")]
    public float? AudibleDistanceModifier { get; set; }
	[InLua("max_distance")]
    public float? MaxDistance { get; set; }
	[InLua("min_distance")]
    public float? MinDistance { get; set; }
	[InLua("play_on_target_position")]
    public bool? PlayOnTargetPosition { get; set; }
	[InLua("sound")]
    public Sound Sound { get; set; }
	[InLua("type")]
    public string Type { get; } = "play-sound";
	[InLua("volume_modifier")]
    public float? VolumeModifier { get; set; }

    
    
    
    

    

    
}
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("Sound")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class Sound 
{
    [InLua("aggregation")]
    public AggregationSpecification? Aggregation { get; set; }
	[InLua("allow_random_repeat")]
    public bool? AllowRandomRepeat { get; set; }
	[InLua("audible_distance_modifier")]
    public double? AudibleDistanceModifier { get; set; }
	[InLua("filename")]
    public FileName? Filename { get; set; }
	[InLua("game_controller_vibration_data")]
    public GameControllerVibrationData? GameControllerVibrationData { get; set; }
	[InLua("max_speed")]
    public float? MaxSpeed { get; set; }
	[InLua("min_speed")]
    public float? MinSpeed { get; set; }
	[InLua("preload")]
    public bool? Preload { get; set; }
	[InLua("speed")]
    public float? Speed { get; set; }
	[InLua("variations")]
    public SoundDefinition[]? Variations { get; set; }
	[InLua("volume")]
    public float? Volume { get; set; }

    
    
    public Sound() {}
    private Sound(SoundDefinition[] value)
    {
        Variations = value;
    }

    public static implicit operator Sound(SoundDefinition[] value) => new(value);

    
}
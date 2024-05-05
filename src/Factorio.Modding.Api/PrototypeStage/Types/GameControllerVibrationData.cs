using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("GameControllerVibrationData")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class GameControllerVibrationData 
{
    [InLua("duration")]
    public uint? Duration { get; set; }
	[InLua("high_frequency_vibration_intensity")]
    public float? HighFrequencyVibrationIntensity { get; set; }
	[InLua("low_frequency_vibration_intensity")]
    public float? LowFrequencyVibrationIntensity { get; set; }
	[InLua("play_for")]
    public PlayFor? PlayFor { get; set; }

    
    
    
    

    

    
}
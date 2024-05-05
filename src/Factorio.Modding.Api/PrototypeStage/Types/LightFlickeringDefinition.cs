using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("LightFlickeringDefinition")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class LightFlickeringDefinition 
{
    [InLua("border_fix_speed")]
    public float? BorderFixSpeed { get; set; }
	[InLua("color")]
    public Color? Color { get; set; }
	[InLua("derivation_change_deviation")]
    public float? DerivationChangeDeviation { get; set; }
	[InLua("derivation_change_frequency")]
    public float? DerivationChangeFrequency { get; set; }
	[InLua("light_intensity_to_size_coefficient")]
    public float? LightIntensityToSizeCoefficient { get; set; }
	[InLua("maximum_intensity")]
    public float? MaximumIntensity { get; set; }
	[InLua("minimum_intensity")]
    public float? MinimumIntensity { get; set; }
	[InLua("minimum_light_size")]
    public float? MinimumLightSize { get; set; }

    
    
    
    

    

    
}
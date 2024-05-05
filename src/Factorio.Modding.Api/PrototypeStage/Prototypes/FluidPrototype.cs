using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("FluidPrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class FluidPrototype : PrototypeBase
{
    [InLua("auto_barrel")]
    public bool? AutoBarrel { get; set; }
	[InLua("base_color")]
    public Color BaseColor { get; set; }
	[InLua("default_temperature")]
    public double DefaultTemperature { get; set; }
	[InLua("emissions_multiplier")]
    public double? EmissionsMultiplier { get; set; }
	[InLua("flow_color")]
    public Color FlowColor { get; set; }
	[InLua("fuel_value")]
    public Energy? FuelValue { get; set; }
	[InLua("gas_temperature")]
    public double? GasTemperature { get; set; }
	[InLua("heat_capacity")]
    public Energy? HeatCapacity { get; set; }
	[InLua("hidden")]
    public bool? Hidden { get; set; }
	[InLua("icon")]
    public FileName? Icon { get; set; }
	[InLua("icon_mipmaps")]
    public IconMipMapType? IconMipmaps { get; set; }
	[InLua("icon_size")]
    public SpriteSizeType? IconSize { get; set; }
	[InLua("icons")]
    public IconData[]? Icons { get; set; }
	[InLua("max_temperature")]
    public double? MaxTemperature { get; set; }
	[InLua("subgroup")]
    public ItemSubGroupID? Subgroup { get; set; }

    
    
    
    

    

    
}
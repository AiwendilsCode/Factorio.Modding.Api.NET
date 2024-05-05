using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("FluidEnergySource")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class FluidEnergySource : BaseEnergySource
{
    [InLua("burns_fluid")]
    public bool? BurnsFluid { get; set; }
	[InLua("destroy_non_fuel_fluid")]
    public bool? DestroyNonFuelFluid { get; set; }
	[InLua("effectivity")]
    public double? Effectivity { get; set; }
	[InLua("fluid_box")]
    public FluidBox FluidBox { get; set; }
	[InLua("fluid_usage_per_tick")]
    public double? FluidUsagePerTick { get; set; }
	[InLua("light_flicker")]
    public LightFlickeringDefinition? LightFlicker { get; set; }
	[InLua("maximum_temperature")]
    public double? MaximumTemperature { get; set; }
	[InLua("scale_fluid_usage")]
    public bool? ScaleFluidUsage { get; set; }
	[InLua("smoke")]
    public SmokeSource[]? Smoke { get; set; }
	[InLua("type")]
    public string Type { get; } = "fluid";

    
    
    
    

    

    
}
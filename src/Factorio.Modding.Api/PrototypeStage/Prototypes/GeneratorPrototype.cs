using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("GeneratorPrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class GeneratorPrototype : EntityWithOwnerPrototype
{
    [InLua("burns_fluid")]
    public bool? BurnsFluid { get; set; }
	[InLua("destroy_non_fuel_fluid")]
    public bool? DestroyNonFuelFluid { get; set; }
	[InLua("effectivity")]
    public double? Effectivity { get; set; }
	[InLua("energy_source")]
    public ElectricEnergySource EnergySource { get; set; }
	[InLua("fluid_box")]
    public FluidBox FluidBox { get; set; }
	[InLua("fluid_usage_per_tick")]
    public double FluidUsagePerTick { get; set; }
	[InLua("horizontal_animation")]
    public Animation? HorizontalAnimation { get; set; }
	[InLua("max_power_output")]
    public Energy? MaxPowerOutput { get; set; }
	[InLua("maximum_temperature")]
    public double MaximumTemperature { get; set; }
	[InLua("min_perceived_performance")]
    public double? MinPerceivedPerformance { get; set; }
	[InLua("performance_to_sound_speedup")]
    public double? PerformanceToSoundSpeedup { get; set; }
	[InLua("scale_fluid_usage")]
    public bool? ScaleFluidUsage { get; set; }
	[InLua("smoke")]
    public SmokeSource[]? Smoke { get; set; }
	[InLua("vertical_animation")]
    public Animation? VerticalAnimation { get; set; }

    
    
    
    

    

    
}
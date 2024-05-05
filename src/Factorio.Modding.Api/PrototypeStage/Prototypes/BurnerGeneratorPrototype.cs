using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("BurnerGeneratorPrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class BurnerGeneratorPrototype : EntityWithOwnerPrototype
{
    [InLua("always_draw_idle_animation")]
    public bool? AlwaysDrawIdleAnimation { get; set; }
	[InLua("animation")]
    public Animation4Way? Animation { get; set; }
	[InLua("burner")]
    public BurnerEnergySource Burner { get; set; }
	[InLua("energy_source")]
    public ElectricEnergySource EnergySource { get; set; }
	[InLua("idle_animation")]
    public Animation4Way? IdleAnimation { get; set; }
	[InLua("max_power_output")]
    public Energy MaxPowerOutput { get; set; }
	[InLua("min_perceived_performance")]
    public double? MinPerceivedPerformance { get; set; }
	[InLua("performance_to_sound_speedup")]
    public double? PerformanceToSoundSpeedup { get; set; }

    
    
    
    

    

    
}
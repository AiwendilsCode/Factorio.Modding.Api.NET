using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("BoilerPrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class BoilerPrototype : EntityWithOwnerPrototype
{
    [InLua("burning_cooldown")]
    public ushort BurningCooldown { get; set; }
	[InLua("energy_consumption")]
    public Energy EnergyConsumption { get; set; }
	[InLua("energy_source")]
    public EnergySource EnergySource { get; set; }
	[InLua("fire")]
    public BoilerFire Fire { get; set; }
	[InLua("fire_flicker_enabled")]
    public bool? FireFlickerEnabled { get; set; }
	[InLua("fire_glow")]
    public BoilerFireGlow FireGlow { get; set; }
	[InLua("fire_glow_flicker_enabled")]
    public bool? FireGlowFlickerEnabled { get; set; }
	[InLua("fluid_box")]
    public FluidBox FluidBox { get; set; }
	[InLua("mode")]
    public ModeEnum? Mode { get; set; }
	[InLua("output_fluid_box")]
    public FluidBox OutputFluidBox { get; set; }
	[InLua("patch")]
    public BoilerPatch? Patch { get; set; }
	[InLua("structure")]
    public BoilerStructure Structure { get; set; }
	[InLua("target_temperature")]
    public double TargetTemperature { get; set; }

    
    
    
    

    

    
}
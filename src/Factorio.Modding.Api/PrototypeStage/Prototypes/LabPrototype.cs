using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("LabPrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class LabPrototype : EntityWithOwnerPrototype
{
    [InLua("allowed_effects")]
    public EffectTypeLimitation? AllowedEffects { get; set; }
	[InLua("base_productivity")]
    public float? BaseProductivity { get; set; }
	[InLua("energy_source")]
    public EnergySource EnergySource { get; set; }
	[InLua("energy_usage")]
    public Energy EnergyUsage { get; set; }
	[InLua("entity_info_icon_shift")]
    public Vector? EntityInfoIconShift { get; set; }
	[InLua("inputs")]
    public ItemID[] Inputs { get; set; }
	[InLua("light")]
    public LightDefinition? Light { get; set; }
	[InLua("module_specification")]
    public ModuleSpecification? ModuleSpecification { get; set; }
	[InLua("off_animation")]
    public Animation OffAnimation { get; set; }
	[InLua("on_animation")]
    public Animation OnAnimation { get; set; }
	[InLua("researching_speed")]
    public double? ResearchingSpeed { get; set; }

    
    
    
    

    

    
}
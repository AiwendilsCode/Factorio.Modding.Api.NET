using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("AmmoType")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class AmmoType 
{
    [InLua("action")]
    public Trigger? Action { get; set; }
	[InLua("category")]
    public AmmoCategoryID Category { get; set; }
	[InLua("clamp_position")]
    public bool? ClampPosition { get; set; }
	[InLua("consumption_modifier")]
    public float? ConsumptionModifier { get; set; }
	[InLua("cooldown_modifier")]
    public double? CooldownModifier { get; set; }
	[InLua("energy_consumption")]
    public Energy? EnergyConsumption { get; set; }
	[InLua("range_modifier")]
    public double? RangeModifier { get; set; }
	[InLua("source_type")]
    public AmmoSourceType? SourceType { get; set; }
	[InLua("target_type")]
    public TargetTypeEnum? TargetType { get; set; }

    
    
    
    

    

    
}
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("DamageTriggerEffectItem")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class DamageTriggerEffectItem : TriggerEffectItem
{
    [InLua("apply_damage_to_trees")]
    public bool? ApplyDamageToTrees { get; set; }
	[InLua("damage")]
    public DamagePrototype Damage { get; set; }
	[InLua("lower_damage_modifier")]
    public float? LowerDamageModifier { get; set; }
	[InLua("lower_distance_threshold")]
    public ushort? LowerDistanceThreshold { get; set; }
	[InLua("type")]
    public string Type { get; } = "damage";
	[InLua("upper_damage_modifier")]
    public float? UpperDamageModifier { get; set; }
	[InLua("upper_distance_threshold")]
    public ushort? UpperDistanceThreshold { get; set; }
	[InLua("vaporize")]
    public bool? Vaporize { get; set; }

    
    
    
    

    

    
}
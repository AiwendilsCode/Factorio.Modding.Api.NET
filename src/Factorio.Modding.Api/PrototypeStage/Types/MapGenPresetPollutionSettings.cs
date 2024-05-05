using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("MapGenPresetPollutionSettings")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class MapGenPresetPollutionSettings 
{
    [InLua("ageing")]
    public double? Ageing { get; set; }
	[InLua("diffusion_ratio")]
    public double? DiffusionRatio { get; set; }
	[InLua("enabled")]
    public bool? Enabled { get; set; }
	[InLua("enemy_attack_pollution_consumption_modifier")]
    public double? EnemyAttackPollutionConsumptionModifier { get; set; }
	[InLua("min_pollution_to_damage_trees")]
    public double? MinPollutionToDamageTrees { get; set; }
	[InLua("pollution_restored_per_tree_damage")]
    public double? PollutionRestoredPerTreeDamage { get; set; }

    
    
    
    

    

    
}
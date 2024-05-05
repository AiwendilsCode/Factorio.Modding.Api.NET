using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("PollutionSettings")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class PollutionSettings 
{
    [InLua("ageing")]
    public double Ageing { get; set; }
	[InLua("diffusion_ratio")]
    public double DiffusionRatio { get; set; }
	[InLua("enabled")]
    public bool Enabled { get; set; }
	[InLua("enemy_attack_pollution_consumption_modifier")]
    public double EnemyAttackPollutionConsumptionModifier { get; set; }
	[InLua("expected_max_per_chunk")]
    public double ExpectedMaxPerChunk { get; set; }
	[InLua("max_pollution_to_restore_trees")]
    public double MaxPollutionToRestoreTrees { get; set; }
	[InLua("min_pollution_to_damage_trees")]
    public double MinPollutionToDamageTrees { get; set; }
	[InLua("min_to_diffuse")]
    public double MinToDiffuse { get; set; }
	[InLua("min_to_show_per_chunk")]
    public double MinToShowPerChunk { get; set; }
	[InLua("pollution_per_tree_damage")]
    public double PollutionPerTreeDamage { get; set; }
	[InLua("pollution_restored_per_tree_damage")]
    public double PollutionRestoredPerTreeDamage { get; set; }
	[InLua("pollution_with_max_forest_damage")]
    public double PollutionWithMaxForestDamage { get; set; }

    
    
    
    

    

    
}
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("AdvancedMapGenSettings")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class AdvancedMapGenSettings 
{
    [InLua("difficulty_settings")]
    public MapGenPresetDifficultySettings? DifficultySettings { get; set; }
	[InLua("enemy_evolution")]
    public MapGenPresetEnemyEvolutionSettings? EnemyEvolution { get; set; }
	[InLua("enemy_expansion")]
    public MapGenPresetEnemyExpansionSettings? EnemyExpansion { get; set; }
	[InLua("pollution")]
    public MapGenPresetPollutionSettings? Pollution { get; set; }

    
    
    
    

    

    
}
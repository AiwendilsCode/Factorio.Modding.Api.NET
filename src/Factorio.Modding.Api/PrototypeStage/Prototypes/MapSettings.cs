using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("MapSettings")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class MapSettings 
{
    [InLua("difficulty_settings")]
    public DifficultySettings DifficultySettings { get; set; }
	[InLua("enemy_evolution")]
    public EnemyEvolutionSettings EnemyEvolution { get; set; }
	[InLua("enemy_expansion")]
    public EnemyExpansionSettings EnemyExpansion { get; set; }
	[InLua("max_failed_behavior_count")]
    public uint MaxFailedBehaviorCount { get; set; }
	[InLua("name")]
    public string Name { get; set; }
	[InLua("path_finder")]
    public PathFinderSettings PathFinder { get; set; }
	[InLua("pollution")]
    public PollutionSettings Pollution { get; set; }
	[InLua("steering")]
    public SteeringSettings Steering { get; set; }
	[InLua("type")]
    public string Type { get; } = "map-settings";
	[InLua("unit_group")]
    public UnitGroupSettings UnitGroup { get; set; }

    
    
    
    

    

    
}
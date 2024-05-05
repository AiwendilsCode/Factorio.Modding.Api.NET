using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("BonusGuiOrdering")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class BonusGuiOrdering 
{
    [InLua("artillery_range")]
    public Order ArtilleryRange { get; set; }
	[InLua("character")]
    public Order Character { get; set; }
	[InLua("follower_robots")]
    public Order FollowerRobots { get; set; }
	[InLua("inserter")]
    public Order Inserter { get; set; }
	[InLua("mining_productivity")]
    public Order MiningProductivity { get; set; }
	[InLua("research_speed")]
    public Order ResearchSpeed { get; set; }
	[InLua("stack_inserter")]
    public Order StackInserter { get; set; }
	[InLua("train_braking_force")]
    public Order TrainBrakingForce { get; set; }
	[InLua("turret_attack")]
    public Order TurretAttack { get; set; }
	[InLua("worker_robots")]
    public Order WorkerRobots { get; set; }

    
    
    
    

    

    
}
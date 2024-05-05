using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("FlyingRobotPrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class FlyingRobotPrototype : EntityWithOwnerPrototype
{
    [InLua("collision_mask")]
    public CollisionMask? CollisionMask { get; set; }
	[InLua("energy_per_move")]
    public Energy? EnergyPerMove { get; set; }
	[InLua("energy_per_tick")]
    public Energy? EnergyPerTick { get; set; }
	[InLua("is_military_target")]
    public bool? IsMilitaryTarget { get; set; }
	[InLua("max_energy")]
    public Energy? MaxEnergy { get; set; }
	[InLua("max_speed")]
    public double? MaxSpeed { get; set; }
	[InLua("max_to_charge")]
    public float? MaxToCharge { get; set; }
	[InLua("min_to_charge")]
    public float? MinToCharge { get; set; }
	[InLua("speed")]
    public double Speed { get; set; }
	[InLua("speed_multiplier_when_out_of_energy")]
    public float? SpeedMultiplierWhenOutOfEnergy { get; set; }

    
    
    
    

    

    
}
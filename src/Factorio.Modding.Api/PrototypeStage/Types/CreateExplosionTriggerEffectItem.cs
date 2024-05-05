using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("CreateExplosionTriggerEffectItem")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class CreateExplosionTriggerEffectItem : CreateEntityTriggerEffectItem
{
    [InLua("cycle_while_moving")]
    public bool? CycleWhileMoving { get; set; }
	[InLua("inherit_movement_distance_from_projectile")]
    public bool? InheritMovementDistanceFromProjectile { get; set; }
	[InLua("max_movement_distance")]
    public float? MaxMovementDistance { get; set; }
	[InLua("max_movement_distance_deviation")]
    public float? MaxMovementDistanceDeviation { get; set; }
	[InLua("type")]
    public string Type { get; } = "create-explosion";

    
    
    
    

    

    
}
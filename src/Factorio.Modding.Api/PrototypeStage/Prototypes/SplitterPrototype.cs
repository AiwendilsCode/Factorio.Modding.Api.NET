using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("SplitterPrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class SplitterPrototype : TransportBeltConnectablePrototype
{
    [InLua("collision_mask")]
    public CollisionMask? CollisionMask { get; set; }
	[InLua("structure")]
    public Animation4Way Structure { get; set; }
	[InLua("structure_animation_movement_cooldown")]
    public uint? StructureAnimationMovementCooldown { get; set; }
	[InLua("structure_animation_speed_coefficient")]
    public double? StructureAnimationSpeedCoefficient { get; set; }
	[InLua("structure_patch")]
    public Animation4Way? StructurePatch { get; set; }

    
    
    
    

    

    
}
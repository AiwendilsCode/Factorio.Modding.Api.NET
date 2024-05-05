using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("TransportBeltConnectablePrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class TransportBeltConnectablePrototype : EntityWithOwnerPrototype
{
    [InLua("animation_speed_coefficient")]
    public double? AnimationSpeedCoefficient { get; set; }
	[InLua("belt_animation_set")]
    public TransportBeltAnimationSet? BeltAnimationSet { get; set; }
	[InLua("belt_horizontal")]
    public Animation? BeltHorizontal { get; set; }
	[InLua("belt_vertical")]
    public Animation? BeltVertical { get; set; }
	[InLua("collision_box")]
    public BoundingBox? CollisionBox { get; set; }
	[InLua("collision_mask")]
    public CollisionMask? CollisionMask { get; set; }
	[InLua("ending_bottom")]
    public Animation? EndingBottom { get; set; }
	[InLua("ending_patch")]
    public Sprite4Way? EndingPatch { get; set; }
	[InLua("ending_side")]
    public Animation? EndingSide { get; set; }
	[InLua("ending_top")]
    public Animation? EndingTop { get; set; }
	[InLua("ends_with_stopper")]
    public bool? EndsWithStopper { get; set; }
	[InLua("flags")]
    public EntityPrototypeFlags? Flags { get; set; }
	[InLua("speed")]
    public double Speed { get; set; }
	[InLua("starting_bottom")]
    public Animation? StartingBottom { get; set; }
	[InLua("starting_side")]
    public Animation? StartingSide { get; set; }
	[InLua("starting_top")]
    public Animation? StartingTop { get; set; }

    
    
    
    

    

    
}
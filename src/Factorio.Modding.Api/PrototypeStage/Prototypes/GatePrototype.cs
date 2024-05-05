using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("GatePrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class GatePrototype : EntityWithOwnerPrototype
{
    [InLua("activation_distance")]
    public double ActivationDistance { get; set; }
	[InLua("close_sound")]
    public Sound CloseSound { get; set; }
	[InLua("collision_mask")]
    public CollisionMask? CollisionMask { get; set; }
	[InLua("fadeout_interval")]
    public uint? FadeoutInterval { get; set; }
	[InLua("horizontal_animation")]
    public Animation HorizontalAnimation { get; set; }
	[InLua("horizontal_rail_animation_left")]
    public Animation HorizontalRailAnimationLeft { get; set; }
	[InLua("horizontal_rail_animation_right")]
    public Animation HorizontalRailAnimationRight { get; set; }
	[InLua("horizontal_rail_base")]
    public Animation HorizontalRailBase { get; set; }
	[InLua("open_sound")]
    public Sound OpenSound { get; set; }
	[InLua("opened_collision_mask")]
    public CollisionMask? OpenedCollisionMask { get; set; }
	[InLua("opening_speed")]
    public float OpeningSpeed { get; set; }
	[InLua("timeout_to_close")]
    public uint TimeoutToClose { get; set; }
	[InLua("vertical_animation")]
    public Animation VerticalAnimation { get; set; }
	[InLua("vertical_rail_animation_left")]
    public Animation VerticalRailAnimationLeft { get; set; }
	[InLua("vertical_rail_animation_right")]
    public Animation VerticalRailAnimationRight { get; set; }
	[InLua("vertical_rail_base")]
    public Animation VerticalRailBase { get; set; }
	[InLua("wall_patch")]
    public Animation WallPatch { get; set; }

    
    
    
    

    

    
}
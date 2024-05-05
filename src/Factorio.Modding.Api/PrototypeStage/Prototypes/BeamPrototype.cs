using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("BeamPrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class BeamPrototype : EntityPrototype
{
    [InLua("action")]
    public Trigger? Action { get; set; }
	[InLua("action_triggered_automatically")]
    public bool? ActionTriggeredAutomatically { get; set; }
	[InLua("body")]
    public AnimationVariations Body { get; set; }
	[InLua("body_light")]
    public AnimationVariations? BodyLight { get; set; }
	[InLua("collision_mask")]
    public CollisionMask? CollisionMask { get; set; }
	[InLua("damage_interval")]
    public uint DamageInterval { get; set; }
	[InLua("ending")]
    public Animation? Ending { get; set; }
	[InLua("ending_light")]
    public Animation? EndingLight { get; set; }
	[InLua("ground_light_animations")]
    public BeamAnimationSet? GroundLightAnimations { get; set; }
	[InLua("head")]
    public Animation Head { get; set; }
	[InLua("head_light")]
    public Animation? HeadLight { get; set; }
	[InLua("light_animations")]
    public BeamAnimationSet? LightAnimations { get; set; }
	[InLua("random_end_animation_rotation")]
    public bool? RandomEndAnimationRotation { get; set; }
	[InLua("random_target_offset")]
    public bool? RandomTargetOffset { get; set; }
	[InLua("start")]
    public Animation? Start { get; set; }
	[InLua("start_light")]
    public Animation? StartLight { get; set; }
	[InLua("tail")]
    public Animation Tail { get; set; }
	[InLua("tail_light")]
    public Animation? TailLight { get; set; }
	[InLua("target_offset")]
    public Vector? TargetOffset { get; set; }
	[InLua("transparent_start_end_animations")]
    public bool? TransparentStartEndAnimations { get; set; }
	[InLua("width")]
    public double Width { get; set; }

    
    
    
    

    

    
}
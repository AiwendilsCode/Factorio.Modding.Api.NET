using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("LandMinePrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class LandMinePrototype : EntityWithOwnerPrototype
{
    [InLua("action")]
    public Trigger? Action { get; set; }
	[InLua("ammo_category")]
    public AmmoCategoryID? AmmoCategory { get; set; }
	[InLua("collision_mask")]
    public CollisionMask? CollisionMask { get; set; }
	[InLua("force_die_on_attack")]
    public bool? ForceDieOnAttack { get; set; }
	[InLua("is_military_target")]
    public bool? IsMilitaryTarget { get; set; }
	[InLua("picture_safe")]
    public Sprite PictureSafe { get; set; }
	[InLua("picture_set")]
    public Sprite PictureSet { get; set; }
	[InLua("picture_set_enemy")]
    public Sprite? PictureSetEnemy { get; set; }
	[InLua("timeout")]
    public uint? Timeout { get; set; }
	[InLua("trigger_collision_mask")]
    public CollisionMask? TriggerCollisionMask { get; set; }
	[InLua("trigger_force")]
    public ForceCondition? TriggerForce { get; set; }
	[InLua("trigger_radius")]
    public double TriggerRadius { get; set; }

    
    
    
    

    

    
}
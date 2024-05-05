using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("ProjectilePrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class ProjectilePrototype : EntityPrototype
{
    [InLua("acceleration")]
    public double Acceleration { get; set; }
	[InLua("action")]
    public Trigger? Action { get; set; }
	[InLua("animation")]
    public AnimationVariations? Animation { get; set; }
	[InLua("collision_mask")]
    public CollisionMask? CollisionMask { get; set; }
	[InLua("direction_only")]
    public bool? DirectionOnly { get; set; }
	[InLua("enable_drawing_with_mask")]
    public bool? EnableDrawingWithMask { get; set; }
	[InLua("final_action")]
    public Trigger? FinalAction { get; set; }
	[InLua("force_condition")]
    public ForceCondition? ForceCondition { get; set; }
	[InLua("height")]
    public double? Height { get; set; }
	[InLua("hit_at_collision_position")]
    public bool? HitAtCollisionPosition { get; set; }
	[InLua("hit_collision_mask")]
    public CollisionMask? HitCollisionMask { get; set; }
	[InLua("light")]
    public LightDefinition? Light { get; set; }
	[InLua("max_speed")]
    public double? MaxSpeed { get; set; }
	[InLua("piercing_damage")]
    public float? PiercingDamage { get; set; }
	[InLua("rotatable")]
    public bool? Rotatable { get; set; }
	[InLua("shadow")]
    public AnimationVariations? Shadow { get; set; }
	[InLua("smoke")]
    public SmokeSource[]? Smoke { get; set; }
	[InLua("speed_modifier")]
    public Vector? SpeedModifier { get; set; }
	[InLua("turn_speed")]
    public float? TurnSpeed { get; set; }
	[InLua("turning_speed_increases_exponentially_with_projectile_speed")]
    public bool? TurningSpeedIncreasesExponentiallyWithProjectileSpeed { get; set; }

    
    
    
    

    

    
}
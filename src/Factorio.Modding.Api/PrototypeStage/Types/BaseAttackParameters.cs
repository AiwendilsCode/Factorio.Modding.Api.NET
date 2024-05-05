using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("BaseAttackParameters")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class BaseAttackParameters 
{
    [InLua("activation_type")]
    public ActivationTypeEnum? ActivationType { get; set; }
	[InLua("ammo_categories")]
    public AmmoCategoryID[]? AmmoCategories { get; set; }
	[InLua("ammo_category")]
    public AmmoCategoryID? AmmoCategory { get; set; }
	[InLua("ammo_consumption_modifier")]
    public float? AmmoConsumptionModifier { get; set; }
	[InLua("ammo_type")]
    public AmmoType? AmmoType { get; set; }
	[InLua("animation")]
    public RotatedAnimation? Animation { get; set; }
	[InLua("cooldown")]
    public float Cooldown { get; set; }
	[InLua("cooldown_deviation")]
    public float? CooldownDeviation { get; set; }
	[InLua("cyclic_sound")]
    public CyclicSound? CyclicSound { get; set; }
	[InLua("damage_modifier")]
    public float? DamageModifier { get; set; }
	[InLua("fire_penalty")]
    public float? FirePenalty { get; set; }
	[InLua("health_penalty")]
    public float? HealthPenalty { get; set; }
	[InLua("lead_target_for_projectile_speed")]
    public float? LeadTargetForProjectileSpeed { get; set; }
	[InLua("min_attack_distance")]
    public float? MinAttackDistance { get; set; }
	[InLua("min_range")]
    public float? MinRange { get; set; }
	[InLua("movement_slow_down_cooldown")]
    public float? MovementSlowDownCooldown { get; set; }
	[InLua("movement_slow_down_factor")]
    public double? MovementSlowDownFactor { get; set; }
	[InLua("range")]
    public float Range { get; set; }
	[InLua("range_mode")]
    public RangeModeEnum? RangeMode { get; set; }
	[InLua("rotate_penalty")]
    public float? RotatePenalty { get; set; }
	[InLua("sound")]
    public LayeredSound? Sound { get; set; }
	[InLua("turn_range")]
    public float? TurnRange { get; set; }
	[InLua("use_shooter_direction")]
    public bool? UseShooterDirection { get; set; }
	[InLua("warmup")]
    public uint? Warmup { get; set; }

    
    
    
    

    

    
}
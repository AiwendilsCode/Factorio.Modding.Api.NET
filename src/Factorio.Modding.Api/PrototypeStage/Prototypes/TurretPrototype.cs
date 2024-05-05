using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("TurretPrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class TurretPrototype : EntityWithOwnerPrototype
{
    [InLua("alert_when_attacking")]
    public bool? AlertWhenAttacking { get; set; }
	[InLua("allow_turning_when_starting_attack")]
    public bool? AllowTurningWhenStartingAttack { get; set; }
	[InLua("attack_from_start_frame")]
    public bool? AttackFromStartFrame { get; set; }
	[InLua("attack_parameters")]
    public AttackParameters AttackParameters { get; set; }
	[InLua("attack_target_mask")]
    public TriggerTargetMask? AttackTargetMask { get; set; }
	[InLua("attacking_animation")]
    public RotatedAnimation4Way? AttackingAnimation { get; set; }
	[InLua("attacking_speed")]
    public float? AttackingSpeed { get; set; }
	[InLua("base_picture")]
    public Animation4Way? BasePicture { get; set; }
	[InLua("base_picture_render_layer")]
    public RenderLayer? BasePictureRenderLayer { get; set; }
	[InLua("base_picture_secondary_draw_order")]
    public byte? BasePictureSecondaryDrawOrder { get; set; }
	[InLua("call_for_help_radius")]
    public double CallForHelpRadius { get; set; }
	[InLua("corpse")]
    public EntityID? Corpse { get; set; }
	[InLua("dying_sound")]
    public Sound? DyingSound { get; set; }
	[InLua("ending_attack_animation")]
    public RotatedAnimation4Way? EndingAttackAnimation { get; set; }
	[InLua("ending_attack_speed")]
    public float? EndingAttackSpeed { get; set; }
	[InLua("energy_glow_animation")]
    public RotatedAnimation4Way? EnergyGlowAnimation { get; set; }
	[InLua("energy_glow_animation_flicker_strength")]
    public float? EnergyGlowAnimationFlickerStrength { get; set; }
	[InLua("folded_animation")]
    public RotatedAnimation4Way FoldedAnimation { get; set; }
	[InLua("folded_speed")]
    public float? FoldedSpeed { get; set; }
	[InLua("folded_speed_secondary")]
    public float? FoldedSpeedSecondary { get; set; }
	[InLua("folding_animation")]
    public RotatedAnimation4Way? FoldingAnimation { get; set; }
	[InLua("folding_sound")]
    public Sound? FoldingSound { get; set; }
	[InLua("folding_speed")]
    public float? FoldingSpeed { get; set; }
	[InLua("glow_light_intensity")]
    public float? GlowLightIntensity { get; set; }
	[InLua("gun_animation_render_layer")]
    public RenderLayer? GunAnimationRenderLayer { get; set; }
	[InLua("gun_animation_secondary_draw_order")]
    public byte? GunAnimationSecondaryDrawOrder { get; set; }
	[InLua("ignore_target_mask")]
    public TriggerTargetMask? IgnoreTargetMask { get; set; }
	[InLua("integration")]
    public Sprite? Integration { get; set; }
	[InLua("is_military_target")]
    public bool? IsMilitaryTarget { get; set; }
	[InLua("prepare_range")]
    public double? PrepareRange { get; set; }
	[InLua("prepared_alternative_animation")]
    public RotatedAnimation4Way? PreparedAlternativeAnimation { get; set; }
	[InLua("prepared_alternative_chance")]
    public float? PreparedAlternativeChance { get; set; }
	[InLua("prepared_alternative_sound")]
    public Sound? PreparedAlternativeSound { get; set; }
	[InLua("prepared_alternative_speed")]
    public float? PreparedAlternativeSpeed { get; set; }
	[InLua("prepared_alternative_speed_secondary")]
    public float? PreparedAlternativeSpeedSecondary { get; set; }
	[InLua("prepared_animation")]
    public RotatedAnimation4Way? PreparedAnimation { get; set; }
	[InLua("prepared_sound")]
    public Sound? PreparedSound { get; set; }
	[InLua("prepared_speed")]
    public float? PreparedSpeed { get; set; }
	[InLua("prepared_speed_secondary")]
    public float? PreparedSpeedSecondary { get; set; }
	[InLua("preparing_animation")]
    public RotatedAnimation4Way? PreparingAnimation { get; set; }
	[InLua("preparing_sound")]
    public Sound? PreparingSound { get; set; }
	[InLua("preparing_speed")]
    public float? PreparingSpeed { get; set; }
	[InLua("random_animation_offset")]
    public bool? RandomAnimationOffset { get; set; }
	[InLua("rotation_speed")]
    public float? RotationSpeed { get; set; }
	[InLua("secondary_animation")]
    public bool? SecondaryAnimation { get; set; }
	[InLua("shoot_in_prepare_state")]
    public bool? ShootInPrepareState { get; set; }
	[InLua("spawn_decoration")]
    public OneOf<CreateDecorativesTriggerEffectItem, CreateDecorativesTriggerEffectItem[]>? SpawnDecoration { get; set; }
	[InLua("spawn_decorations_on_expansion")]
    public bool? SpawnDecorationsOnExpansion { get; set; }
	[InLua("starting_attack_animation")]
    public RotatedAnimation4Way? StartingAttackAnimation { get; set; }
	[InLua("starting_attack_sound")]
    public Sound? StartingAttackSound { get; set; }
	[InLua("starting_attack_speed")]
    public float? StartingAttackSpeed { get; set; }
	[InLua("turret_base_has_direction")]
    public bool? TurretBaseHasDirection { get; set; }

    
    
    
    

    

    
}
using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("UnitPrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class UnitPrototype : EntityWithOwnerPrototype
{
    [InLua("affected_by_tiles")]
    public bool? AffectedByTiles { get; set; }
	[InLua("ai_settings")]
    public UnitAISettings? AiSettings { get; set; }
	[InLua("allow_run_time_change_of_is_military_target")]
    public bool? AllowRunTimeChangeOfIsMilitaryTarget { get; } = false;
	[InLua("alternative_attacking_frame_sequence")]
    public UnitAlternativeFrameSequence? AlternativeAttackingFrameSequence { get; set; }
	[InLua("attack_parameters")]
    public AttackParameters AttackParameters { get; set; }
	[InLua("can_open_gates")]
    public bool? CanOpenGates { get; set; }
	[InLua("collision_mask")]
    public CollisionMask? CollisionMask { get; set; }
	[InLua("distance_per_frame")]
    public float DistancePerFrame { get; set; }
	[InLua("distraction_cooldown")]
    public uint DistractionCooldown { get; set; }
	[InLua("dying_sound")]
    public Sound? DyingSound { get; set; }
	[InLua("has_belt_immunity")]
    public bool? HasBeltImmunity { get; set; }
	[InLua("is_military_target")]
    public bool? IsMilitaryTarget { get; } = true;
	[InLua("light")]
    public LightDefinition? Light { get; set; }
	[InLua("max_pursue_distance")]
    public double? MaxPursueDistance { get; set; }
	[InLua("min_pursue_time")]
    public uint? MinPursueTime { get; set; }
	[InLua("move_while_shooting")]
    public bool? MoveWhileShooting { get; set; }
	[InLua("movement_speed")]
    public float MovementSpeed { get; set; }
	[InLua("pollution_to_join_attack")]
    public float PollutionToJoinAttack { get; set; }
	[InLua("radar_range")]
    public uint? RadarRange { get; set; }
	[InLua("render_layer")]
    public RenderLayer? RenderLayer { get; set; }
	[InLua("rotation_speed")]
    public float? RotationSpeed { get; set; }
	[InLua("run_animation")]
    public RotatedAnimation RunAnimation { get; set; }
	[InLua("running_sound_animation_positions")]
    public float[]? RunningSoundAnimationPositions { get; set; }
	[InLua("spawning_time_modifier")]
    public double? SpawningTimeModifier { get; set; }
	[InLua("vision_distance")]
    public double VisionDistance { get; set; }
	[InLua("walking_sound")]
    public Sound? WalkingSound { get; set; }

    
    
    
    

    

    
}
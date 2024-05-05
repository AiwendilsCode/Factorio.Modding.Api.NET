using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("CharacterPrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class CharacterPrototype : EntityWithOwnerPrototype
{
    [InLua("animations")]
    public CharacterArmorAnimation[] Animations { get; set; }
	[InLua("build_distance")]
    public uint BuildDistance { get; set; }
	[InLua("character_corpse")]
    public EntityID? CharacterCorpse { get; set; }
	[InLua("collision_mask")]
    public CollisionMask? CollisionMask { get; set; }
	[InLua("crafting_categories")]
    public RecipeCategoryID[]? CraftingCategories { get; set; }
	[InLua("damage_hit_tint")]
    public Color DamageHitTint { get; set; }
	[InLua("distance_per_frame")]
    public double DistancePerFrame { get; set; }
	[InLua("drop_item_distance")]
    public uint DropItemDistance { get; set; }
	[InLua("eat")]
    public Sound Eat { get; set; }
	[InLua("enter_vehicle_distance")]
    public double? EnterVehicleDistance { get; set; }
	[InLua("footprint_particles")]
    public FootprintParticle[]? FootprintParticles { get; set; }
	[InLua("footstep_particle_triggers")]
    public FootstepTriggerEffectList? FootstepParticleTriggers { get; set; }
	[InLua("has_belt_immunity")]
    public bool? HasBeltImmunity { get; set; }
	[InLua("heartbeat")]
    public Sound Heartbeat { get; set; }
	[InLua("inventory_size")]
    public ItemStackIndex InventorySize { get; set; }
	[InLua("is_military_target")]
    public bool? IsMilitaryTarget { get; set; }
	[InLua("item_pickup_distance")]
    public double ItemPickupDistance { get; set; }
	[InLua("left_footprint_frames")]
    public float[]? LeftFootprintFrames { get; set; }
	[InLua("left_footprint_offset")]
    public Vector? LeftFootprintOffset { get; set; }
	[InLua("light")]
    public LightDefinition? Light { get; set; }
	[InLua("loot_pickup_distance")]
    public double LootPickupDistance { get; set; }
	[InLua("maximum_corner_sliding_distance")]
    public double MaximumCornerSlidingDistance { get; set; }
	[InLua("mining_categories")]
    public ResourceCategoryID[]? MiningCategories { get; set; }
	[InLua("mining_speed")]
    public double MiningSpeed { get; set; }
	[InLua("mining_with_tool_particles_animation_positions")]
    public float[] MiningWithToolParticlesAnimationPositions { get; set; }
	[InLua("reach_distance")]
    public uint ReachDistance { get; set; }
	[InLua("reach_resource_distance")]
    public double ReachResourceDistance { get; set; }
	[InLua("respawn_time")]
    public uint? RespawnTime { get; set; }
	[InLua("right_footprint_frames")]
    public float[]? RightFootprintFrames { get; set; }
	[InLua("right_footprint_offset")]
    public Vector? RightFootprintOffset { get; set; }
	[InLua("running_sound_animation_positions")]
    public float[] RunningSoundAnimationPositions { get; set; }
	[InLua("running_speed")]
    public double RunningSpeed { get; set; }
	[InLua("synced_footstep_particle_triggers")]
    public FootstepTriggerEffectList? SyncedFootstepParticleTriggers { get; set; }
	[InLua("ticks_to_keep_aiming_direction")]
    public uint TicksToKeepAimingDirection { get; set; }
	[InLua("ticks_to_keep_gun")]
    public uint TicksToKeepGun { get; set; }
	[InLua("ticks_to_stay_in_combat")]
    public uint TicksToStayInCombat { get; set; }
	[InLua("tool_attack_distance")]
    public double? ToolAttackDistance { get; set; }
	[InLua("tool_attack_result")]
    public Trigger? ToolAttackResult { get; set; }

    
    
    
    

    

    
}
using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("FireFlamePrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class FireFlamePrototype : EntityPrototype
{
    [InLua("add_fuel_cooldown")]
    public uint? AddFuelCooldown { get; set; }
	[InLua("burnt_patch_alpha_default")]
    public float? BurntPatchAlphaDefault { get; set; }
	[InLua("burnt_patch_alpha_variations")]
    public TileAndAlpha[]? BurntPatchAlphaVariations { get; set; }
	[InLua("burnt_patch_lifetime")]
    public uint? BurntPatchLifetime { get; set; }
	[InLua("burnt_patch_pictures")]
    public SpriteVariations? BurntPatchPictures { get; set; }
	[InLua("collision_mask")]
    public CollisionMask? CollisionMask { get; set; }
	[InLua("damage_multiplier_decrease_per_tick")]
    public float? DamageMultiplierDecreasePerTick { get; set; }
	[InLua("damage_multiplier_increase_per_added_fuel")]
    public float? DamageMultiplierIncreasePerAddedFuel { get; set; }
	[InLua("damage_per_tick")]
    public DamagePrototype DamagePerTick { get; set; }
	[InLua("delay_between_initial_flames")]
    public uint? DelayBetweenInitialFlames { get; set; }
	[InLua("fade_in_duration")]
    public uint? FadeInDuration { get; set; }
	[InLua("fade_out_duration")]
    public uint? FadeOutDuration { get; set; }
	[InLua("flame_alpha")]
    public float? FlameAlpha { get; set; }
	[InLua("flame_alpha_deviation")]
    public float? FlameAlphaDeviation { get; set; }
	[InLua("initial_flame_count")]
    public byte? InitialFlameCount { get; set; }
	[InLua("initial_lifetime")]
    public uint? InitialLifetime { get; set; }
	[InLua("initial_render_layer")]
    public RenderLayer? InitialRenderLayer { get; set; }
	[InLua("lifetime_increase_by")]
    public uint? LifetimeIncreaseBy { get; set; }
	[InLua("lifetime_increase_cooldown")]
    public uint? LifetimeIncreaseCooldown { get; set; }
	[InLua("light")]
    public LightDefinition? Light { get; set; }
	[InLua("limit_overlapping_particles")]
    public bool? LimitOverlappingParticles { get; set; }
	[InLua("maximum_damage_multiplier")]
    public float? MaximumDamageMultiplier { get; set; }
	[InLua("maximum_lifetime")]
    public uint? MaximumLifetime { get; set; }
	[InLua("maximum_spread_count")]
    public ushort? MaximumSpreadCount { get; set; }
	[InLua("on_damage_tick_effect")]
    public Trigger? OnDamageTickEffect { get; set; }
	[InLua("on_fuel_added_action")]
    public Trigger? OnFuelAddedAction { get; set; }
	[InLua("particle_alpha")]
    public float? ParticleAlpha { get; set; }
	[InLua("particle_alpha_blend_duration")]
    public ushort? ParticleAlphaBlendDuration { get; set; }
	[InLua("particle_alpha_deviation")]
    public float? ParticleAlphaDeviation { get; set; }
	[InLua("pictures")]
    public AnimationVariations? Pictures { get; set; }
	[InLua("render_layer")]
    public RenderLayer? RenderLayer { get; set; }
	[InLua("secondary_picture_fade_out_duration")]
    public uint? SecondaryPictureFadeOutDuration { get; set; }
	[InLua("secondary_picture_fade_out_start")]
    public uint? SecondaryPictureFadeOutStart { get; set; }
	[InLua("secondary_pictures")]
    public AnimationVariations? SecondaryPictures { get; set; }
	[InLua("secondary_render_layer")]
    public RenderLayer? SecondaryRenderLayer { get; set; }
	[InLua("small_tree_fire_pictures")]
    public AnimationVariations? SmallTreeFirePictures { get; set; }
	[InLua("smoke")]
    public SmokeSource[]? Smoke { get; set; }
	[InLua("smoke_fade_in_duration")]
    public uint? SmokeFadeInDuration { get; set; }
	[InLua("smoke_fade_out_duration")]
    public uint? SmokeFadeOutDuration { get; set; }
	[InLua("smoke_source_pictures")]
    public AnimationVariations? SmokeSourcePictures { get; set; }
	[InLua("spawn_entity")]
    public EntityID? SpawnEntity { get; set; }
	[InLua("spread_delay")]
    public uint SpreadDelay { get; set; }
	[InLua("spread_delay_deviation")]
    public uint SpreadDelayDeviation { get; set; }
	[InLua("tree_dying_factor")]
    public float? TreeDyingFactor { get; set; }
	[InLua("uses_alternative_behavior")]
    public bool? UsesAlternativeBehavior { get; set; }

    
    
    
    

    

    
}
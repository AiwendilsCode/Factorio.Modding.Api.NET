using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("RocketSiloRocketPrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class RocketSiloRocketPrototype : EntityPrototype
{
    [InLua("dying_explosion")]
    public EntityID? DyingExplosion { get; set; }
	[InLua("effects_fade_in_end_distance")]
    public double EffectsFadeInEndDistance { get; set; }
	[InLua("effects_fade_in_start_distance")]
    public double EffectsFadeInStartDistance { get; set; }
	[InLua("engine_starting_speed")]
    public double EngineStartingSpeed { get; set; }
	[InLua("flying_acceleration")]
    public double FlyingAcceleration { get; set; }
	[InLua("flying_speed")]
    public double FlyingSpeed { get; set; }
	[InLua("flying_trigger")]
    public TriggerEffect? FlyingTrigger { get; set; }
	[InLua("full_render_layer_switch_distance")]
    public double FullRenderLayerSwitchDistance { get; set; }
	[InLua("glow_light")]
    public LightDefinition? GlowLight { get; set; }
	[InLua("inventory_size")]
    public ItemStackIndex InventorySize { get; set; }
	[InLua("rising_speed")]
    public double RisingSpeed { get; set; }
	[InLua("rocket_above_wires_slice_offset_from_center")]
    public float? RocketAboveWiresSliceOffsetFromCenter { get; set; }
	[InLua("rocket_air_object_slice_offset_from_center")]
    public float? RocketAirObjectSliceOffsetFromCenter { get; set; }
	[InLua("rocket_flame_animation")]
    public Animation RocketFlameAnimation { get; set; }
	[InLua("rocket_flame_left_animation")]
    public Animation RocketFlameLeftAnimation { get; set; }
	[InLua("rocket_flame_left_rotation")]
    public float RocketFlameLeftRotation { get; set; }
	[InLua("rocket_flame_right_animation")]
    public Animation RocketFlameRightAnimation { get; set; }
	[InLua("rocket_flame_right_rotation")]
    public float RocketFlameRightRotation { get; set; }
	[InLua("rocket_glare_overlay_sprite")]
    public Sprite RocketGlareOverlaySprite { get; set; }
	[InLua("rocket_initial_offset")]
    public Vector? RocketInitialOffset { get; set; }
	[InLua("rocket_launch_offset")]
    public Vector RocketLaunchOffset { get; set; }
	[InLua("rocket_render_layer_switch_distance")]
    public double RocketRenderLayerSwitchDistance { get; set; }
	[InLua("rocket_rise_offset")]
    public Vector RocketRiseOffset { get; set; }
	[InLua("rocket_shadow_sprite")]
    public Sprite RocketShadowSprite { get; set; }
	[InLua("rocket_smoke_bottom1_animation")]
    public Animation RocketSmokeBottom1Animation { get; set; }
	[InLua("rocket_smoke_bottom2_animation")]
    public Animation RocketSmokeBottom2Animation { get; set; }
	[InLua("rocket_smoke_top1_animation")]
    public Animation RocketSmokeTop1Animation { get; set; }
	[InLua("rocket_smoke_top2_animation")]
    public Animation RocketSmokeTop2Animation { get; set; }
	[InLua("rocket_smoke_top3_animation")]
    public Animation RocketSmokeTop3Animation { get; set; }
	[InLua("rocket_sprite")]
    public Sprite RocketSprite { get; set; }
	[InLua("rocket_visible_distance_from_center")]
    public float RocketVisibleDistanceFromCenter { get; set; }
	[InLua("shadow_fade_out_end_ratio")]
    public double ShadowFadeOutEndRatio { get; set; }
	[InLua("shadow_fade_out_start_ratio")]
    public double ShadowFadeOutStartRatio { get; set; }
	[InLua("shadow_slave_entity")]
    public EntityID? ShadowSlaveEntity { get; set; }

    
    
    
    

    

    
}
using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("RocketSiloPrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class RocketSiloPrototype : AssemblingMachinePrototype
{
    [InLua("active_energy_usage")]
    public Energy ActiveEnergyUsage { get; set; }
	[InLua("alarm_sound")]
    public Sound? AlarmSound { get; set; }
	[InLua("alarm_trigger")]
    public TriggerEffect? AlarmTrigger { get; set; }
	[InLua("arm_01_back_animation")]
    public Animation Arm01_BackAnimation { get; set; }
	[InLua("arm_02_right_animation")]
    public Animation Arm02_RightAnimation { get; set; }
	[InLua("arm_03_front_animation")]
    public Animation Arm03_FrontAnimation { get; set; }
	[InLua("base_day_sprite")]
    public Sprite BaseDaySprite { get; set; }
	[InLua("base_engine_light")]
    public LightDefinition? BaseEngineLight { get; set; }
	[InLua("base_front_sprite")]
    public Sprite BaseFrontSprite { get; set; }
	[InLua("base_light")]
    public LightDefinition? BaseLight { get; set; }
	[InLua("base_night_sprite")]
    public Sprite? BaseNightSprite { get; set; }
	[InLua("clamps_off_sound")]
    public Sound? ClampsOffSound { get; set; }
	[InLua("clamps_off_trigger")]
    public TriggerEffect? ClampsOffTrigger { get; set; }
	[InLua("clamps_on_sound")]
    public Sound? ClampsOnSound { get; set; }
	[InLua("clamps_on_trigger")]
    public TriggerEffect? ClampsOnTrigger { get; set; }
	[InLua("door_back_open_offset")]
    public Vector DoorBackOpenOffset { get; set; }
	[InLua("door_back_sprite")]
    public Sprite DoorBackSprite { get; set; }
	[InLua("door_front_open_offset")]
    public Vector DoorFrontOpenOffset { get; set; }
	[InLua("door_front_sprite")]
    public Sprite DoorFrontSprite { get; set; }
	[InLua("door_opening_speed")]
    public double DoorOpeningSpeed { get; set; }
	[InLua("doors_sound")]
    public Sound? DoorsSound { get; set; }
	[InLua("doors_trigger")]
    public TriggerEffect? DoorsTrigger { get; set; }
	[InLua("flying_sound")]
    public Sound? FlyingSound { get; set; }
	[InLua("hole_clipping_box")]
    public BoundingBox HoleClippingBox { get; set; }
	[InLua("hole_light_sprite")]
    public Sprite HoleLightSprite { get; set; }
	[InLua("hole_sprite")]
    public Sprite HoleSprite { get; set; }
	[InLua("lamp_energy_usage")]
    public Energy LampEnergyUsage { get; set; }
	[InLua("launch_wait_time")]
    public byte? LaunchWaitTime { get; set; }
	[InLua("light_blinking_speed")]
    public double LightBlinkingSpeed { get; set; }
	[InLua("raise_rocket_sound")]
    public Sound? RaiseRocketSound { get; set; }
	[InLua("raise_rocket_trigger")]
    public TriggerEffect? RaiseRocketTrigger { get; set; }
	[InLua("red_lights_back_sprites")]
    public Sprite RedLightsBackSprites { get; set; }
	[InLua("red_lights_front_sprites")]
    public Sprite RedLightsFrontSprites { get; set; }
	[InLua("rocket_entity")]
    public EntityID RocketEntity { get; set; }
	[InLua("rocket_glow_overlay_sprite")]
    public Sprite RocketGlowOverlaySprite { get; set; }
	[InLua("rocket_parts_required")]
    public uint RocketPartsRequired { get; set; }
	[InLua("rocket_result_inventory_size")]
    public ItemStackIndex? RocketResultInventorySize { get; set; }
	[InLua("rocket_rising_delay")]
    public byte? RocketRisingDelay { get; set; }
	[InLua("rocket_shadow_overlay_sprite")]
    public Sprite RocketShadowOverlaySprite { get; set; }
	[InLua("satellite_animation")]
    public Animation? SatelliteAnimation { get; set; }
	[InLua("satellite_shadow_animation")]
    public Animation? SatelliteShadowAnimation { get; set; }
	[InLua("shadow_sprite")]
    public Sprite ShadowSprite { get; set; }
	[InLua("silo_fade_out_end_distance")]
    public double SiloFadeOutEndDistance { get; set; }
	[InLua("silo_fade_out_start_distance")]
    public double SiloFadeOutStartDistance { get; set; }
	[InLua("times_to_blink")]
    public byte TimesToBlink { get; set; }

    
    
    
    

    

    
}
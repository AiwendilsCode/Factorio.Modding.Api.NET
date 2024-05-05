using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("ParticlePrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class ParticlePrototype : PrototypeBase
{
    [InLua("draw_shadow_when_on_ground")]
    public bool? DrawShadowWhenOnGround { get; set; }
	[InLua("ended_in_water_trigger_effect")]
    public TriggerEffect? EndedInWaterTriggerEffect { get; set; }
	[InLua("ended_on_ground_trigger_effect")]
    public TriggerEffect? EndedOnGroundTriggerEffect { get; set; }
	[InLua("fade_away_duration")]
    public ushort? FadeAwayDuration { get; set; }
	[InLua("life_time")]
    public ushort LifeTime { get; set; }
	[InLua("mining_particle_frame_speed")]
    public float? MiningParticleFrameSpeed { get; set; }
	[InLua("movement_modifier")]
    public float? MovementModifier { get; set; }
	[InLua("movement_modifier_when_on_ground")]
    public float? MovementModifierWhenOnGround { get; set; }
	[InLua("pictures")]
    public AnimationVariations Pictures { get; set; }
	[InLua("regular_trigger_effect")]
    public TriggerEffect? RegularTriggerEffect { get; set; }
	[InLua("regular_trigger_effect_frequency")]
    public uint? RegularTriggerEffectFrequency { get; set; }
	[InLua("render_layer")]
    public RenderLayer? RenderLayer { get; set; }
	[InLua("render_layer_when_on_ground")]
    public RenderLayer? RenderLayerWhenOnGround { get; set; }
	[InLua("shadows")]
    public AnimationVariations? Shadows { get; set; }
	[InLua("vertical_acceleration")]
    public float? VerticalAcceleration { get; set; }

    
    
    
    

    

    
}
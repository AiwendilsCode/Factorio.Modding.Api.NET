using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("ArtilleryFlarePrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class ArtilleryFlarePrototype : EntityPrototype
{
    [InLua("collision_mask")]
    public CollisionMask? CollisionMask { get; set; }
	[InLua("creation_shift")]
    public Vector? CreationShift { get; set; }
	[InLua("early_death_ticks")]
    public uint? EarlyDeathTicks { get; set; }
	[InLua("ended_in_water_trigger_effect")]
    public TriggerEffect? EndedInWaterTriggerEffect { get; set; }
	[InLua("initial_frame_speed")]
    public float? InitialFrameSpeed { get; set; }
	[InLua("initial_height")]
    public float? InitialHeight { get; set; }
	[InLua("initial_speed")]
    public Vector? InitialSpeed { get; set; }
	[InLua("initial_vertical_speed")]
    public float? InitialVerticalSpeed { get; set; }
	[InLua("life_time")]
    public ushort LifeTime { get; set; }
	[InLua("map_color")]
    public Color MapColor { get; set; }
	[InLua("movement_modifier")]
    public double? MovementModifier { get; set; }
	[InLua("movement_modifier_when_on_ground")]
    public double? MovementModifierWhenOnGround { get; set; }
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
	[InLua("selection_priority")]
    public byte? SelectionPriority { get; set; }
	[InLua("shadows")]
    public AnimationVariations? Shadows { get; set; }
	[InLua("shot_category")]
    public AmmoCategoryID? ShotCategory { get; set; }
	[InLua("shots_per_flare")]
    public uint? ShotsPerFlare { get; set; }

    
    
    
    

    

    
}
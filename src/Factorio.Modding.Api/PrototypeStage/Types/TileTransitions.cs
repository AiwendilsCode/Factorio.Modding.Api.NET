using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("TileTransitions")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class TileTransitions 
{
    [InLua("apply_effect_color_to_overlay")]
    public bool? ApplyEffectColorToOverlay { get; set; }
	[InLua("background_layer_group")]
    public TileRenderLayer? BackgroundLayerGroup { get; set; }
	[InLua("background_layer_offset")]
    public sbyte? BackgroundLayerOffset { get; set; }
	[InLua("effect_mask")]
    public Animation? EffectMask { get; set; }
	[InLua("empty_transitions")]
    public bool? EmptyTransitions { get; set; }
	[InLua("inner_corner")]
    public TileTransitionSprite InnerCorner { get; set; }
	[InLua("inner_corner_background")]
    public TileTransitionSprite? InnerCornerBackground { get; set; }
	[InLua("inner_corner_background_mask")]
    public TileTransitionSprite? InnerCornerBackgroundMask { get; set; }
	[InLua("inner_corner_effect_map")]
    public TileTransitionSprite? InnerCornerEffectMap { get; set; }
	[InLua("inner_corner_mask")]
    public TileTransitionSprite InnerCornerMask { get; set; }
	[InLua("inner_corner_weights")]
    public float[]? InnerCornerWeights { get; set; }
	[InLua("layer")]
    public byte? Layer { get; set; }
	[InLua("masked_background_layer_offset")]
    public sbyte? MaskedBackgroundLayerOffset { get; set; }
	[InLua("masked_overlay_layer_offset")]
    public sbyte? MaskedOverlayLayerOffset { get; set; }
	[InLua("o_transition")]
    public TileSprite? OTransition { get; set; }
	[InLua("o_transition_background")]
    public TileSprite? OTransitionBackground { get; set; }
	[InLua("o_transition_background_mask")]
    public TileSprite? OTransitionBackgroundMask { get; set; }
	[InLua("o_transition_effect_map")]
    public TileSprite? OTransitionEffectMap { get; set; }
	[InLua("o_transition_mask")]
    public TileSprite? OTransitionMask { get; set; }
	[InLua("offset_background_layer_by_tile_layer")]
    public bool? OffsetBackgroundLayerByTileLayer { get; set; }
	[InLua("outer_corner")]
    public TileTransitionSprite OuterCorner { get; set; }
	[InLua("outer_corner_background")]
    public TileTransitionSprite? OuterCornerBackground { get; set; }
	[InLua("outer_corner_background_mask")]
    public TileTransitionSprite? OuterCornerBackgroundMask { get; set; }
	[InLua("outer_corner_effect_map")]
    public TileTransitionSprite? OuterCornerEffectMap { get; set; }
	[InLua("outer_corner_mask")]
    public TileTransitionSprite OuterCornerMask { get; set; }
	[InLua("outer_corner_weights")]
    public float[]? OuterCornerWeights { get; set; }
	[InLua("overlay_layer_group")]
    public TileRenderLayer? OverlayLayerGroup { get; set; }
	[InLua("overlay_layer_offset")]
    public sbyte? OverlayLayerOffset { get; set; }
	[InLua("side")]
    public TileTransitionSprite Side { get; set; }
	[InLua("side_background")]
    public TileTransitionSprite? SideBackground { get; set; }
	[InLua("side_background_mask")]
    public TileTransitionSprite? SideBackgroundMask { get; set; }
	[InLua("side_effect_map")]
    public TileTransitionSprite? SideEffectMap { get; set; }
	[InLua("side_mask")]
    public TileTransitionSprite SideMask { get; set; }
	[InLua("side_weights")]
    public float[]? SideWeights { get; set; }
	[InLua("u_transition")]
    public TileTransitionSprite? UTransition { get; set; }
	[InLua("u_transition_background")]
    public TileTransitionSprite? UTransitionBackground { get; set; }
	[InLua("u_transition_background_mask")]
    public TileTransitionSprite? UTransitionBackgroundMask { get; set; }
	[InLua("u_transition_effect_map")]
    public TileTransitionSprite? UTransitionEffectMap { get; set; }
	[InLua("u_transition_mask")]
    public TileTransitionSprite? UTransitionMask { get; set; }
	[InLua("u_transition_weights")]
    public float[]? UTransitionWeights { get; set; }
	[InLua("water_patch")]
    public Sprite? WaterPatch { get; set; }

    
    
    
    

    

    
}
using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("CorpsePrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class CorpsePrototype : EntityPrototype
{
    [InLua("animation")]
    public RotatedAnimationVariations? Animation { get; set; }
	[InLua("animation_overlay")]
    public RotatedAnimationVariations? AnimationOverlay { get; set; }
	[InLua("animation_overlay_final_render_layer")]
    public RenderLayer? AnimationOverlayFinalRenderLayer { get; set; }
	[InLua("animation_overlay_render_layer")]
    public RenderLayer? AnimationOverlayRenderLayer { get; set; }
	[InLua("animation_render_layer")]
    public RenderLayer? AnimationRenderLayer { get; set; }
	[InLua("collision_mask")]
    public CollisionMask? CollisionMask { get; set; }
	[InLua("direction_shuffle")]
    public ushort[][]? DirectionShuffle { get; set; }
	[InLua("dying_speed")]
    public float? DyingSpeed { get; set; }
	[InLua("final_render_layer")]
    public RenderLayer? FinalRenderLayer { get; set; }
	[InLua("ground_patch")]
    public AnimationVariations? GroundPatch { get; set; }
	[InLua("ground_patch_fade_in_delay")]
    public float? GroundPatchFadeInDelay { get; set; }
	[InLua("ground_patch_fade_in_speed")]
    public float? GroundPatchFadeInSpeed { get; set; }
	[InLua("ground_patch_fade_out_duration")]
    public float? GroundPatchFadeOutDuration { get; set; }
	[InLua("ground_patch_fade_out_start")]
    public float? GroundPatchFadeOutStart { get; set; }
	[InLua("ground_patch_higher")]
    public AnimationVariations? GroundPatchHigher { get; set; }
	[InLua("ground_patch_render_layer")]
    public RenderLayer? GroundPatchRenderLayer { get; set; }
	[InLua("remove_on_entity_placement")]
    public bool? RemoveOnEntityPlacement { get; set; }
	[InLua("remove_on_tile_placement")]
    public bool? RemoveOnTilePlacement { get; set; }
	[InLua("shuffle_directions_at_frame")]
    public byte? ShuffleDirectionsAtFrame { get; set; }
	[InLua("splash")]
    public AnimationVariations? Splash { get; set; }
	[InLua("splash_render_layer")]
    public RenderLayer? SplashRenderLayer { get; set; }
	[InLua("splash_speed")]
    public float? SplashSpeed { get; set; }
	[InLua("time_before_removed")]
    public uint? TimeBeforeRemoved { get; set; }
	[InLua("time_before_shading_off")]
    public uint? TimeBeforeShadingOff { get; set; }
	[InLua("use_tile_color_for_ground_patch_tint")]
    public bool? UseTileColorForGroundPatchTint { get; set; }

    
    
    
    

    

    
}
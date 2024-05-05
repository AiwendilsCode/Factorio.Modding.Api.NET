using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("TilePrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class TilePrototype : PrototypeBase
{
    [InLua("allowed_neighbors")]
    public TileID[]? AllowedNeighbors { get; set; }
	[InLua("autoplace")]
    public AutoplaceSpecification? Autoplace { get; set; }
	[InLua("build_sound")]
    public OneOf<Sound, TileBuildSound>? BuildSound { get; set; }
	[InLua("can_be_part_of_blueprint")]
    public bool? CanBePartOfBlueprint { get; set; }
	[InLua("check_collision_with_entities")]
    public bool? CheckCollisionWithEntities { get; set; }
	[InLua("collision_mask")]
    public CollisionMask CollisionMask { get; set; }
	[InLua("decorative_removal_probability")]
    public float? DecorativeRemovalProbability { get; set; }
	[InLua("draw_in_water_layer")]
    public bool? DrawInWaterLayer { get; set; }
	[InLua("effect")]
    public string? Effect { get; set; }
	[InLua("effect_color")]
    public Color? EffectColor { get; set; }
	[InLua("effect_color_secondary")]
    public Color? EffectColorSecondary { get; set; }
	[InLua("effect_is_opaque")]
    public bool? EffectIsOpaque { get; set; }
	[InLua("icon")]
    public FileName? Icon { get; set; }
	[InLua("icon_mipmaps")]
    public IconMipMapType? IconMipmaps { get; set; }
	[InLua("icon_size")]
    public SpriteSizeType? IconSize { get; set; }
	[InLua("icons")]
    public IconData[]? Icons { get; set; }
	[InLua("layer")]
    public byte Layer { get; set; }
	[InLua("layer_group")]
    public TileRenderLayer? LayerGroup { get; set; }
	[InLua("map_color")]
    public Color MapColor { get; set; }
	[InLua("minable")]
    public MinableProperties? Minable { get; set; }
	[InLua("mined_sound")]
    public Sound? MinedSound { get; set; }
	[InLua("needs_correction")]
    public bool? NeedsCorrection { get; set; }
	[InLua("next_direction")]
    public TileID? NextDirection { get; set; }
	[InLua("placeable_by")]
    public OneOf<ItemToPlace, ItemToPlace[]>? PlaceableBy { get; set; }
	[InLua("pollution_absorption_per_second")]
    public double PollutionAbsorptionPerSecond { get; set; }
	[InLua("scorch_mark_color")]
    public Color? ScorchMarkColor { get; set; }
	[InLua("tint")]
    public Color? Tint { get; set; }
	[InLua("transition_merges_with_tile")]
    public TileID? TransitionMergesWithTile { get; set; }
	[InLua("transition_overlay_layer_offset")]
    public sbyte? TransitionOverlayLayerOffset { get; set; }
	[InLua("transitions")]
    public TileTransitionsToTiles[]? Transitions { get; set; }
	[InLua("transitions_between_transitions")]
    public TileTransitionsBetweenTransitions[]? TransitionsBetweenTransitions { get; set; }
	[InLua("trigger_effect")]
    public TriggerEffect? TriggerEffect { get; set; }
	[InLua("variants")]
    public TileTransitionsVariants Variants { get; set; }
	[InLua("vehicle_friction_modifier")]
    public double? VehicleFrictionModifier { get; set; }
	[InLua("walking_sound")]
    public Sound? WalkingSound { get; set; }
	[InLua("walking_speed_modifier")]
    public double? WalkingSpeedModifier { get; set; }

    
    
    
    

    

    
}
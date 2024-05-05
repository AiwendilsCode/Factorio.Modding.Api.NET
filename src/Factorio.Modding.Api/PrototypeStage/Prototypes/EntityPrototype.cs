using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("EntityPrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class EntityPrototype : PrototypeBase
{
    [InLua("additional_pastable_entities")]
    public EntityID[]? AdditionalPastableEntities { get; set; }
	[InLua("alert_icon_scale")]
    public float? AlertIconScale { get; set; }
	[InLua("alert_icon_shift")]
    public Vector? AlertIconShift { get; set; }
	[InLua("allow_copy_paste")]
    public bool? AllowCopyPaste { get; set; }
	[InLua("autoplace")]
    public AutoplaceSpecification? Autoplace { get; set; }
	[InLua("build_base_evolution_requirement")]
    public double? BuildBaseEvolutionRequirement { get; set; }
	[InLua("build_grid_size")]
    public byte? BuildGridSize { get; set; }
	[InLua("build_sound")]
    public Sound? BuildSound { get; set; }
	[InLua("close_sound")]
    public Sound? CloseSound { get; set; }
	[InLua("collision_box")]
    public BoundingBox? CollisionBox { get; set; }
	[InLua("collision_mask")]
    public CollisionMask? CollisionMask { get; set; }
	[InLua("created_effect")]
    public Trigger? CreatedEffect { get; set; }
	[InLua("created_smoke")]
    public CreateTrivialSmokeEffectItem? CreatedSmoke { get; set; }
	[InLua("drawing_box")]
    public BoundingBox? DrawingBox { get; set; }
	[InLua("emissions_per_second")]
    public double? EmissionsPerSecond { get; set; }
	[InLua("enemy_map_color")]
    public Color? EnemyMapColor { get; set; }
	[InLua("fast_replaceable_group")]
    public string? FastReplaceableGroup { get; set; }
	[InLua("flags")]
    public EntityPrototypeFlags? Flags { get; set; }
	[InLua("friendly_map_color")]
    public Color? FriendlyMapColor { get; set; }
	[InLua("hit_visualization_box")]
    public BoundingBox? HitVisualizationBox { get; set; }
	[InLua("icon")]
    public FileName? Icon { get; set; }
	[InLua("icon_mipmaps")]
    public IconMipMapType? IconMipmaps { get; set; }
	[InLua("icon_size")]
    public SpriteSizeType? IconSize { get; set; }
	[InLua("icons")]
    public IconData[]? Icons { get; set; }
	[InLua("map_color")]
    public Color? MapColor { get; set; }
	[InLua("map_generator_bounding_box")]
    public BoundingBox? MapGeneratorBoundingBox { get; set; }
	[InLua("minable")]
    public MinableProperties? Minable { get; set; }
	[InLua("mined_sound")]
    public Sound? MinedSound { get; set; }
	[InLua("mining_sound")]
    public Sound? MiningSound { get; set; }
	[InLua("next_upgrade")]
    public EntityID? NextUpgrade { get; set; }
	[InLua("open_sound")]
    public Sound? OpenSound { get; set; }
	[InLua("order")]
    public Order? Order { get; set; }
	[InLua("placeable_by")]
    public OneOf<ItemToPlace, ItemToPlace[]>? PlaceableBy { get; set; }
	[InLua("protected_from_tile_building")]
    public bool? ProtectedFromTileBuilding { get; set; }
	[InLua("radius_visualisation_specification")]
    public RadiusVisualisationSpecification? RadiusVisualisationSpecification { get; set; }
	[InLua("remains_when_mined")]
    public OneOf<EntityID, EntityID[]>? RemainsWhenMined { get; set; }
	[InLua("remove_decoratives")]
    public RemoveDecorativesEnum? RemoveDecoratives { get; set; }
	[InLua("rotated_sound")]
    public Sound? RotatedSound { get; set; }
	[InLua("selectable_in_game")]
    public bool? SelectableInGame { get; set; }
	[InLua("selection_box")]
    public BoundingBox? SelectionBox { get; set; }
	[InLua("selection_priority")]
    public byte? SelectionPriority { get; set; }
	[InLua("shooting_cursor_size")]
    public float? ShootingCursorSize { get; set; }
	[InLua("sticker_box")]
    public BoundingBox? StickerBox { get; set; }
	[InLua("subgroup")]
    public ItemSubGroupID? Subgroup { get; set; }
	[InLua("tile_height")]
    public uint? TileHeight { get; set; }
	[InLua("tile_width")]
    public uint? TileWidth { get; set; }
	[InLua("trigger_target_mask")]
    public TriggerTargetMask? TriggerTargetMask { get; set; }
	[InLua("vehicle_impact_sound")]
    public Sound? VehicleImpactSound { get; set; }
	[InLua("water_reflection")]
    public WaterReflectionDefinition? WaterReflection { get; set; }
	[InLua("working_sound")]
    public WorkingSound? WorkingSound { get; set; }

    
    
    
    

    

    
}
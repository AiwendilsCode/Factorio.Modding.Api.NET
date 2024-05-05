using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("UtilityConstants")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class UtilityConstants : PrototypeBase
{
    [InLua("artillery_range_visualization_color")]
    public Color ArtilleryRangeVisualizationColor { get; set; }
	[InLua("bonus_gui_ordering")]
    public BonusGuiOrdering BonusGuiOrdering { get; set; }
	[InLua("building_buildable_tint")]
    public Color BuildingBuildableTint { get; set; }
	[InLua("building_buildable_too_far_tint")]
    public Color BuildingBuildableTooFarTint { get; set; }
	[InLua("building_ignorable_tint")]
    public Color BuildingIgnorableTint { get; set; }
	[InLua("building_no_tint")]
    public Color BuildingNoTint { get; set; }
	[InLua("building_not_buildable_tint")]
    public Color BuildingNotBuildableTint { get; set; }
	[InLua("capsule_range_visualization_color")]
    public Color CapsuleRangeVisualizationColor { get; set; }
	[InLua("chart")]
    public ChartUtilityConstants Chart { get; set; }
	[InLua("checkerboard_black")]
    public Color CheckerboardBlack { get; set; }
	[InLua("checkerboard_white")]
    public Color CheckerboardWhite { get; set; }
	[InLua("clipboard_history_size")]
    public uint ClipboardHistorySize { get; set; }
	[InLua("color_filters")]
    public ColorFilterData[] ColorFilters { get; set; }
	[InLua("count_button_size")]
    public int CountButtonSize { get; set; }
	[InLua("daytime_color_lookup")]
    public DaytimeColorLookupTable DaytimeColorLookup { get; set; }
	[InLua("deconstruct_mark_tint")]
    public Color DeconstructMarkTint { get; set; }
	[InLua("default_alert_icon_scale")]
    public float DefaultAlertIconScale { get; set; }
	[InLua("default_alert_icon_scale_by_type")]
    public Dictionary<string, float>? DefaultAlertIconScaleByType { get; set; }
	[InLua("default_alert_icon_shift_by_type")]
    public Dictionary<string, Vector>? DefaultAlertIconShiftByType { get; set; }
	[InLua("default_enemy_force_color")]
    public Color DefaultEnemyForceColor { get; set; }
	[InLua("default_other_force_color")]
    public Color DefaultOtherForceColor { get; set; }
	[InLua("default_player_force_color")]
    public Color DefaultPlayerForceColor { get; set; }
	[InLua("default_scorch_mark_color")]
    public Color DefaultScorchMarkColor { get; set; }
	[InLua("default_trigger_target_mask_by_type")]
    public Dictionary<string, TriggerTargetMask>? DefaultTriggerTargetMaskByType { get; set; }
	[InLua("disabled_recipe_slot_background_tint")]
    public Color DisabledRecipeSlotBackgroundTint { get; set; }
	[InLua("disabled_recipe_slot_tint")]
    public Color DisabledRecipeSlotTint { get; set; }
	[InLua("dynamic_recipe_overload_factor")]
    public double DynamicRecipeOverloadFactor { get; set; }
	[InLua("enabled_recipe_slot_tint")]
    public Color EnabledRecipeSlotTint { get; set; }
	[InLua("entity_button_background_color")]
    public Color EntityButtonBackgroundColor { get; set; }
	[InLua("entity_renderer_search_box_limits")]
    public EntityRendererSearchBoxLimits EntityRendererSearchBoxLimits { get; set; }
	[InLua("equipment_default_background_border_color")]
    public Color EquipmentDefaultBackgroundBorderColor { get; set; }
	[InLua("equipment_default_background_color")]
    public Color EquipmentDefaultBackgroundColor { get; set; }
	[InLua("equipment_default_grabbed_background_color")]
    public Color EquipmentDefaultGrabbedBackgroundColor { get; set; }
	[InLua("filter_outline_color")]
    public Color FilterOutlineColor { get; set; }
	[InLua("flying_text_ttl")]
    public uint FlyingTextTtl { get; set; }
	[InLua("forced_enabled_recipe_slot_background_tint")]
    public Color ForcedEnabledRecipeSlotBackgroundTint { get; set; }
	[InLua("ghost_tint")]
    public Color GhostTint { get; set; }
	[InLua("gui_remark_color")]
    public Color GuiRemarkColor { get; set; }
	[InLua("icon_shadow_color")]
    public Color IconShadowColor { get; set; }
	[InLua("icon_shadow_inset")]
    public float IconShadowInset { get; set; }
	[InLua("icon_shadow_radius")]
    public float IconShadowRadius { get; set; }
	[InLua("icon_shadow_sharpness")]
    public float IconShadowSharpness { get; set; }
	[InLua("inventory_width")]
    public uint InventoryWidth { get; set; }
	[InLua("item_outline_color")]
    public Color ItemOutlineColor { get; set; }
	[InLua("item_outline_inset")]
    public float ItemOutlineInset { get; set; }
	[InLua("item_outline_radius")]
    public float ItemOutlineRadius { get; set; }
	[InLua("item_outline_sharpness")]
    public float ItemOutlineSharpness { get; set; }
	[InLua("light_renderer_search_distance_limit")]
    public byte LightRendererSearchDistanceLimit { get; set; }
	[InLua("main_menu_background_image_location")]
    public FileName MainMenuBackgroundImageLocation { get; set; }
	[InLua("main_menu_background_vignette_intensity")]
    public float MainMenuBackgroundVignetteIntensity { get; set; }
	[InLua("main_menu_background_vignette_sharpness")]
    public float MainMenuBackgroundVignetteSharpness { get; set; }
	[InLua("main_menu_simulations")]
    public Dictionary<string, SimulationDefinition> MainMenuSimulations { get; set; }
	[InLua("manual_rail_building_reach_modifier")]
    public double ManualRailBuildingReachModifier { get; set; }
	[InLua("map_editor")]
    public MapEditorConstants MapEditor { get; set; }
	[InLua("max_terrain_building_size")]
    public byte MaxTerrainBuildingSize { get; set; }
	[InLua("maximum_recipe_overload_multiplier")]
    public uint MaximumRecipeOverloadMultiplier { get; set; }
	[InLua("medium_area_size")]
    public float MediumAreaSize { get; set; }
	[InLua("medium_blueprint_area_size")]
    public float MediumBlueprintAreaSize { get; set; }
	[InLua("minimum_recipe_overload_multiplier")]
    public uint MinimumRecipeOverloadMultiplier { get; set; }
	[InLua("missing_preview_sprite_location")]
    public FileName MissingPreviewSpriteLocation { get; set; }
	[InLua("module_inventory_width")]
    public uint ModuleInventoryWidth { get; set; }
	[InLua("normalised_achievement_icon_size")]
    public uint NormalisedAchievementIconSize { get; set; }
	[InLua("player_colors")]
    public PlayerColorData[] PlayerColors { get; set; }
	[InLua("rail_planner_count_button_color")]
    public Color RailPlannerCountButtonColor { get; set; }
	[InLua("rail_segment_colors")]
    public Color[] RailSegmentColors { get; set; }
	[InLua("recipe_step_limit")]
    public uint RecipeStepLimit { get; set; }
	[InLua("script_command_console_chat_color")]
    public Color ScriptCommandConsoleChatColor { get; set; }
	[InLua("select_group_row_count")]
    public byte SelectGroupRowCount { get; set; }
	[InLua("select_slot_row_count")]
    public uint SelectSlotRowCount { get; set; }
	[InLua("server_command_console_chat_color")]
    public Color ServerCommandConsoleChatColor { get; set; }
	[InLua("small_area_size")]
    public float SmallAreaSize { get; set; }
	[InLua("small_blueprint_area_size")]
    public float SmallBlueprintAreaSize { get; set; }
	[InLua("tile_ghost_tint")]
    public Color TileGhostTint { get; set; }
	[InLua("tooltip_monitor_edge_border")]
    public int TooltipMonitorEdgeBorder { get; set; }
	[InLua("train_button_hovered_tint")]
    public Color TrainButtonHoveredTint { get; set; }
	[InLua("train_destination_full_color")]
    public Color TrainDestinationFullColor { get; set; }
	[InLua("train_inactivity_wait_condition_default")]
    public uint TrainInactivityWaitConditionDefault { get; set; }
	[InLua("train_no_path_color")]
    public Color TrainNoPathColor { get; set; }
	[InLua("train_path_finding")]
    public TrainPathFinderConstants TrainPathFinding { get; set; }
	[InLua("train_temporary_stop_wait_time")]
    public uint TrainTemporaryStopWaitTime { get; set; }
	[InLua("train_time_wait_condition_default")]
    public uint TrainTimeWaitConditionDefault { get; set; }
	[InLua("tree_leaf_distortion_distortion_far")]
    public Vector TreeLeafDistortionDistortionFar { get; set; }
	[InLua("tree_leaf_distortion_distortion_near")]
    public Vector TreeLeafDistortionDistortionNear { get; set; }
	[InLua("tree_leaf_distortion_speed_far")]
    public Vector TreeLeafDistortionSpeedFar { get; set; }
	[InLua("tree_leaf_distortion_speed_near")]
    public Vector TreeLeafDistortionSpeedNear { get; set; }
	[InLua("tree_leaf_distortion_strength_far")]
    public Vector TreeLeafDistortionStrengthFar { get; set; }
	[InLua("tree_leaf_distortion_strength_near")]
    public Vector TreeLeafDistortionStrengthNear { get; set; }
	[InLua("tree_shadow_roughness")]
    public float TreeShadowRoughness { get; set; }
	[InLua("tree_shadow_speed")]
    public float TreeShadowSpeed { get; set; }
	[InLua("turret_range_visualization_color")]
    public Color TurretRangeVisualizationColor { get; set; }
	[InLua("tutorial_notice_icon_size")]
    public uint TutorialNoticeIconSize { get; set; }
	[InLua("unit_group_max_pursue_distance")]
    public double UnitGroupMaxPursueDistance { get; set; }
	[InLua("unit_group_pathfind_resolution")]
    public sbyte UnitGroupPathfindResolution { get; set; }
	[InLua("zoom_to_world_can_use_nightvision")]
    public bool ZoomToWorldCanUseNightvision { get; set; }
	[InLua("zoom_to_world_daytime_color_lookup")]
    public DaytimeColorLookupTable ZoomToWorldDaytimeColorLookup { get; set; }
	[InLua("zoom_to_world_effect_strength")]
    public float ZoomToWorldEffectStrength { get; set; }

    
    
    
    

    

    
}
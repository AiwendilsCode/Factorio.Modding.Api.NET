using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("UtilitySprites")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class UtilitySprites : PrototypeBase
{
    [InLua("achievement_label_failed")]
    public Sprite AchievementLabelFailed { get; set; }
	[InLua("achievement_label_locked")]
    public Sprite AchievementLabelLocked { get; set; }
	[InLua("achievement_label_unlocked")]
    public Sprite AchievementLabelUnlocked { get; set; }
	[InLua("achievement_label_unlocked_off")]
    public Sprite AchievementLabelUnlockedOff { get; set; }
	[InLua("add")]
    public Sprite Add { get; set; }
	[InLua("alert_arrow")]
    public Sprite AlertArrow { get; set; }
	[InLua("ammo_damage_modifier_constant")]
    public Sprite? AmmoDamageModifierConstant { get; set; }
	[InLua("ammo_damage_modifier_icon")]
    public Sprite AmmoDamageModifierIcon { get; set; }
	[InLua("ammo_icon")]
    public Sprite AmmoIcon { get; set; }
	[InLua("and_or")]
    public Sprite AndOr { get; set; }
	[InLua("area_icon")]
    public Sprite AreaIcon { get; set; }
	[InLua("arrow_button")]
    public Animation ArrowButton { get; set; }
	[InLua("artillery_range_modifier_constant")]
    public Sprite? ArtilleryRangeModifierConstant { get; set; }
	[InLua("artillery_range_modifier_icon")]
    public Sprite ArtilleryRangeModifierIcon { get; set; }
	[InLua("bar_gray_pip")]
    public Sprite BarGrayPip { get; set; }
	[InLua("battery")]
    public Sprite Battery { get; set; }
	[InLua("bookmark")]
    public Sprite Bookmark { get; set; }
	[InLua("brush_circle_shape")]
    public Sprite BrushCircleShape { get; set; }
	[InLua("brush_icon")]
    public Sprite BrushIcon { get; set; }
	[InLua("brush_square_shape")]
    public Sprite BrushSquareShape { get; set; }
	[InLua("cable_editor_icon")]
    public Sprite CableEditorIcon { get; set; }
	[InLua("center")]
    public Sprite Center { get; set; }
	[InLua("change_recipe")]
    public Sprite ChangeRecipe { get; set; }
	[InLua("character_additional_mining_categories_modifier_constant")]
    public Sprite? CharacterAdditionalMiningCategoriesModifierConstant { get; set; }
	[InLua("character_additional_mining_categories_modifier_icon")]
    public Sprite CharacterAdditionalMiningCategoriesModifierIcon { get; set; }
	[InLua("character_build_distance_modifier_constant")]
    public Sprite? CharacterBuildDistanceModifierConstant { get; set; }
	[InLua("character_build_distance_modifier_icon")]
    public Sprite CharacterBuildDistanceModifierIcon { get; set; }
	[InLua("character_crafting_speed_modifier_constant")]
    public Sprite? CharacterCraftingSpeedModifierConstant { get; set; }
	[InLua("character_crafting_speed_modifier_icon")]
    public Sprite CharacterCraftingSpeedModifierIcon { get; set; }
	[InLua("character_health_bonus_modifier_constant")]
    public Sprite? CharacterHealthBonusModifierConstant { get; set; }
	[InLua("character_health_bonus_modifier_icon")]
    public Sprite CharacterHealthBonusModifierIcon { get; set; }
	[InLua("character_inventory_slots_bonus_modifier_constant")]
    public Sprite? CharacterInventorySlotsBonusModifierConstant { get; set; }
	[InLua("character_inventory_slots_bonus_modifier_icon")]
    public Sprite CharacterInventorySlotsBonusModifierIcon { get; set; }
	[InLua("character_item_drop_distance_modifier_constant")]
    public Sprite? CharacterItemDropDistanceModifierConstant { get; set; }
	[InLua("character_item_drop_distance_modifier_icon")]
    public Sprite CharacterItemDropDistanceModifierIcon { get; set; }
	[InLua("character_item_pickup_distance_modifier_constant")]
    public Sprite? CharacterItemPickupDistanceModifierConstant { get; set; }
	[InLua("character_item_pickup_distance_modifier_icon")]
    public Sprite CharacterItemPickupDistanceModifierIcon { get; set; }
	[InLua("character_logistic_requests_modifier_constant")]
    public Sprite? CharacterLogisticRequestsModifierConstant { get; set; }
	[InLua("character_logistic_requests_modifier_icon")]
    public Sprite CharacterLogisticRequestsModifierIcon { get; set; }
	[InLua("character_logistic_slots_modifier_constant")]
    public Sprite? CharacterLogisticSlotsModifierConstant { get; set; }
	[InLua("character_logistic_slots_modifier_icon")]
    public Sprite CharacterLogisticSlotsModifierIcon { get; set; }
	[InLua("character_logistic_trash_slots_modifier_constant")]
    public Sprite? CharacterLogisticTrashSlotsModifierConstant { get; set; }
	[InLua("character_logistic_trash_slots_modifier_icon")]
    public Sprite CharacterLogisticTrashSlotsModifierIcon { get; set; }
	[InLua("character_loot_pickup_distance_modifier_constant")]
    public Sprite? CharacterLootPickupDistanceModifierConstant { get; set; }
	[InLua("character_loot_pickup_distance_modifier_icon")]
    public Sprite CharacterLootPickupDistanceModifierIcon { get; set; }
	[InLua("character_mining_speed_modifier_constant")]
    public Sprite? CharacterMiningSpeedModifierConstant { get; set; }
	[InLua("character_mining_speed_modifier_icon")]
    public Sprite CharacterMiningSpeedModifierIcon { get; set; }
	[InLua("character_reach_distance_modifier_constant")]
    public Sprite? CharacterReachDistanceModifierConstant { get; set; }
	[InLua("character_reach_distance_modifier_icon")]
    public Sprite CharacterReachDistanceModifierIcon { get; set; }
	[InLua("character_resource_reach_distance_modifier_constant")]
    public Sprite? CharacterResourceReachDistanceModifierConstant { get; set; }
	[InLua("character_resource_reach_distance_modifier_icon")]
    public Sprite CharacterResourceReachDistanceModifierIcon { get; set; }
	[InLua("character_running_speed_modifier_constant")]
    public Sprite? CharacterRunningSpeedModifierConstant { get; set; }
	[InLua("character_running_speed_modifier_icon")]
    public Sprite CharacterRunningSpeedModifierIcon { get; set; }
	[InLua("check_mark")]
    public Sprite CheckMark { get; set; }
	[InLua("check_mark_dark_green")]
    public Sprite CheckMarkDarkGreen { get; set; }
	[InLua("check_mark_green")]
    public Sprite CheckMarkGreen { get; set; }
	[InLua("check_mark_white")]
    public Sprite CheckMarkWhite { get; set; }
	[InLua("circuit_network_panel_black")]
    public Sprite CircuitNetworkPanelBlack { get; set; }
	[InLua("circuit_network_panel_white")]
    public Sprite CircuitNetworkPanelWhite { get; set; }
	[InLua("cliff_editor_icon")]
    public Sprite CliffEditorIcon { get; set; }
	[InLua("clock")]
    public Sprite Clock { get; set; }
	[InLua("clone")]
    public Sprite Clone { get; set; }
	[InLua("clone_editor_icon")]
    public Sprite CloneEditorIcon { get; set; }
	[InLua("close_black")]
    public Sprite CloseBlack { get; set; }
	[InLua("close_fat")]
    public Sprite CloseFat { get; set; }
	[InLua("close_map_preview")]
    public Sprite CloseMapPreview { get; set; }
	[InLua("close_white")]
    public Sprite CloseWhite { get; set; }
	[InLua("clouds")]
    public Animation Clouds { get; set; }
	[InLua("collapse")]
    public Sprite Collapse { get; set; }
	[InLua("collapse_dark")]
    public Sprite CollapseDark { get; set; }
	[InLua("color_effect")]
    public Sprite ColorEffect { get; set; }
	[InLua("color_picker")]
    public Sprite ColorPicker { get; set; }
	[InLua("confirm_slot")]
    public Sprite ConfirmSlot { get; set; }
	[InLua("construction_radius_visualization")]
    public Sprite ConstructionRadiusVisualization { get; set; }
	[InLua("controller_joycon_a")]
    public Sprite ControllerJoyconA { get; set; }
	[InLua("controller_joycon_b")]
    public Sprite ControllerJoyconB { get; set; }
	[InLua("controller_joycon_back")]
    public Sprite ControllerJoyconBack { get; set; }
	[InLua("controller_joycon_black_a")]
    public Sprite ControllerJoyconBlackA { get; set; }
	[InLua("controller_joycon_black_b")]
    public Sprite ControllerJoyconBlackB { get; set; }
	[InLua("controller_joycon_black_back")]
    public Sprite ControllerJoyconBlackBack { get; set; }
	[InLua("controller_joycon_black_dpdown")]
    public Sprite ControllerJoyconBlackDpdown { get; set; }
	[InLua("controller_joycon_black_dpleft")]
    public Sprite ControllerJoyconBlackDpleft { get; set; }
	[InLua("controller_joycon_black_dpright")]
    public Sprite ControllerJoyconBlackDpright { get; set; }
	[InLua("controller_joycon_black_dpup")]
    public Sprite ControllerJoyconBlackDpup { get; set; }
	[InLua("controller_joycon_black_left_stick")]
    public Sprite ControllerJoyconBlackLeftStick { get; set; }
	[InLua("controller_joycon_black_leftshoulder")]
    public Sprite ControllerJoyconBlackLeftshoulder { get; set; }
	[InLua("controller_joycon_black_leftstick")]
    public Sprite ControllerJoyconBlackLeftstick { get; set; }
	[InLua("controller_joycon_black_lefttrigger")]
    public Sprite ControllerJoyconBlackLefttrigger { get; set; }
	[InLua("controller_joycon_black_paddle1")]
    public Sprite ControllerJoyconBlackPaddle1 { get; set; }
	[InLua("controller_joycon_black_paddle2")]
    public Sprite ControllerJoyconBlackPaddle2 { get; set; }
	[InLua("controller_joycon_black_paddle3")]
    public Sprite ControllerJoyconBlackPaddle3 { get; set; }
	[InLua("controller_joycon_black_paddle4")]
    public Sprite ControllerJoyconBlackPaddle4 { get; set; }
	[InLua("controller_joycon_black_right_stick")]
    public Sprite ControllerJoyconBlackRightStick { get; set; }
	[InLua("controller_joycon_black_rightshoulder")]
    public Sprite ControllerJoyconBlackRightshoulder { get; set; }
	[InLua("controller_joycon_black_rightstick")]
    public Sprite ControllerJoyconBlackRightstick { get; set; }
	[InLua("controller_joycon_black_righttrigger")]
    public Sprite ControllerJoyconBlackRighttrigger { get; set; }
	[InLua("controller_joycon_black_start")]
    public Sprite ControllerJoyconBlackStart { get; set; }
	[InLua("controller_joycon_black_x")]
    public Sprite ControllerJoyconBlackX { get; set; }
	[InLua("controller_joycon_black_y")]
    public Sprite ControllerJoyconBlackY { get; set; }
	[InLua("controller_joycon_dpdown")]
    public Sprite ControllerJoyconDpdown { get; set; }
	[InLua("controller_joycon_dpleft")]
    public Sprite ControllerJoyconDpleft { get; set; }
	[InLua("controller_joycon_dpright")]
    public Sprite ControllerJoyconDpright { get; set; }
	[InLua("controller_joycon_dpup")]
    public Sprite ControllerJoyconDpup { get; set; }
	[InLua("controller_joycon_left_stick")]
    public Sprite ControllerJoyconLeftStick { get; set; }
	[InLua("controller_joycon_leftshoulder")]
    public Sprite ControllerJoyconLeftshoulder { get; set; }
	[InLua("controller_joycon_leftstick")]
    public Sprite ControllerJoyconLeftstick { get; set; }
	[InLua("controller_joycon_lefttrigger")]
    public Sprite ControllerJoyconLefttrigger { get; set; }
	[InLua("controller_joycon_paddle1")]
    public Sprite ControllerJoyconPaddle1 { get; set; }
	[InLua("controller_joycon_paddle2")]
    public Sprite ControllerJoyconPaddle2 { get; set; }
	[InLua("controller_joycon_paddle3")]
    public Sprite ControllerJoyconPaddle3 { get; set; }
	[InLua("controller_joycon_paddle4")]
    public Sprite ControllerJoyconPaddle4 { get; set; }
	[InLua("controller_joycon_right_stick")]
    public Sprite ControllerJoyconRightStick { get; set; }
	[InLua("controller_joycon_rightshoulder")]
    public Sprite ControllerJoyconRightshoulder { get; set; }
	[InLua("controller_joycon_rightstick")]
    public Sprite ControllerJoyconRightstick { get; set; }
	[InLua("controller_joycon_righttrigger")]
    public Sprite ControllerJoyconRighttrigger { get; set; }
	[InLua("controller_joycon_start")]
    public Sprite ControllerJoyconStart { get; set; }
	[InLua("controller_joycon_x")]
    public Sprite ControllerJoyconX { get; set; }
	[InLua("controller_joycon_y")]
    public Sprite ControllerJoyconY { get; set; }
	[InLua("controller_ps_a")]
    public Sprite ControllerPsA { get; set; }
	[InLua("controller_ps_b")]
    public Sprite ControllerPsB { get; set; }
	[InLua("controller_ps_back")]
    public Sprite ControllerPsBack { get; set; }
	[InLua("controller_ps_black_a")]
    public Sprite ControllerPsBlackA { get; set; }
	[InLua("controller_ps_black_b")]
    public Sprite ControllerPsBlackB { get; set; }
	[InLua("controller_ps_black_back")]
    public Sprite ControllerPsBlackBack { get; set; }
	[InLua("controller_ps_black_dpdown")]
    public Sprite ControllerPsBlackDpdown { get; set; }
	[InLua("controller_ps_black_dpleft")]
    public Sprite ControllerPsBlackDpleft { get; set; }
	[InLua("controller_ps_black_dpright")]
    public Sprite ControllerPsBlackDpright { get; set; }
	[InLua("controller_ps_black_dpup")]
    public Sprite ControllerPsBlackDpup { get; set; }
	[InLua("controller_ps_black_left_stick")]
    public Sprite ControllerPsBlackLeftStick { get; set; }
	[InLua("controller_ps_black_leftshoulder")]
    public Sprite ControllerPsBlackLeftshoulder { get; set; }
	[InLua("controller_ps_black_leftstick")]
    public Sprite ControllerPsBlackLeftstick { get; set; }
	[InLua("controller_ps_black_lefttrigger")]
    public Sprite ControllerPsBlackLefttrigger { get; set; }
	[InLua("controller_ps_black_right_stick")]
    public Sprite ControllerPsBlackRightStick { get; set; }
	[InLua("controller_ps_black_rightshoulder")]
    public Sprite ControllerPsBlackRightshoulder { get; set; }
	[InLua("controller_ps_black_rightstick")]
    public Sprite ControllerPsBlackRightstick { get; set; }
	[InLua("controller_ps_black_righttrigger")]
    public Sprite ControllerPsBlackRighttrigger { get; set; }
	[InLua("controller_ps_black_start")]
    public Sprite ControllerPsBlackStart { get; set; }
	[InLua("controller_ps_black_x")]
    public Sprite ControllerPsBlackX { get; set; }
	[InLua("controller_ps_black_y")]
    public Sprite ControllerPsBlackY { get; set; }
	[InLua("controller_ps_dpdown")]
    public Sprite ControllerPsDpdown { get; set; }
	[InLua("controller_ps_dpleft")]
    public Sprite ControllerPsDpleft { get; set; }
	[InLua("controller_ps_dpright")]
    public Sprite ControllerPsDpright { get; set; }
	[InLua("controller_ps_dpup")]
    public Sprite ControllerPsDpup { get; set; }
	[InLua("controller_ps_left_stick")]
    public Sprite ControllerPsLeftStick { get; set; }
	[InLua("controller_ps_leftshoulder")]
    public Sprite ControllerPsLeftshoulder { get; set; }
	[InLua("controller_ps_leftstick")]
    public Sprite ControllerPsLeftstick { get; set; }
	[InLua("controller_ps_lefttrigger")]
    public Sprite ControllerPsLefttrigger { get; set; }
	[InLua("controller_ps_right_stick")]
    public Sprite ControllerPsRightStick { get; set; }
	[InLua("controller_ps_rightshoulder")]
    public Sprite ControllerPsRightshoulder { get; set; }
	[InLua("controller_ps_rightstick")]
    public Sprite ControllerPsRightstick { get; set; }
	[InLua("controller_ps_righttrigger")]
    public Sprite ControllerPsRighttrigger { get; set; }
	[InLua("controller_ps_start")]
    public Sprite ControllerPsStart { get; set; }
	[InLua("controller_ps_x")]
    public Sprite ControllerPsX { get; set; }
	[InLua("controller_ps_y")]
    public Sprite ControllerPsY { get; set; }
	[InLua("controller_steamdeck_a")]
    public Sprite ControllerSteamdeckA { get; set; }
	[InLua("controller_steamdeck_b")]
    public Sprite ControllerSteamdeckB { get; set; }
	[InLua("controller_steamdeck_back")]
    public Sprite ControllerSteamdeckBack { get; set; }
	[InLua("controller_steamdeck_black_a")]
    public Sprite ControllerSteamdeckBlackA { get; set; }
	[InLua("controller_steamdeck_black_b")]
    public Sprite ControllerSteamdeckBlackB { get; set; }
	[InLua("controller_steamdeck_black_back")]
    public Sprite ControllerSteamdeckBlackBack { get; set; }
	[InLua("controller_steamdeck_black_dpdown")]
    public Sprite ControllerSteamdeckBlackDpdown { get; set; }
	[InLua("controller_steamdeck_black_dpleft")]
    public Sprite ControllerSteamdeckBlackDpleft { get; set; }
	[InLua("controller_steamdeck_black_dpright")]
    public Sprite ControllerSteamdeckBlackDpright { get; set; }
	[InLua("controller_steamdeck_black_dpup")]
    public Sprite ControllerSteamdeckBlackDpup { get; set; }
	[InLua("controller_steamdeck_black_left_stick")]
    public Sprite ControllerSteamdeckBlackLeftStick { get; set; }
	[InLua("controller_steamdeck_black_leftshoulder")]
    public Sprite ControllerSteamdeckBlackLeftshoulder { get; set; }
	[InLua("controller_steamdeck_black_leftstick")]
    public Sprite ControllerSteamdeckBlackLeftstick { get; set; }
	[InLua("controller_steamdeck_black_lefttrigger")]
    public Sprite ControllerSteamdeckBlackLefttrigger { get; set; }
	[InLua("controller_steamdeck_black_paddle1")]
    public Sprite ControllerSteamdeckBlackPaddle1 { get; set; }
	[InLua("controller_steamdeck_black_paddle2")]
    public Sprite ControllerSteamdeckBlackPaddle2 { get; set; }
	[InLua("controller_steamdeck_black_paddle3")]
    public Sprite ControllerSteamdeckBlackPaddle3 { get; set; }
	[InLua("controller_steamdeck_black_paddle4")]
    public Sprite ControllerSteamdeckBlackPaddle4 { get; set; }
	[InLua("controller_steamdeck_black_right_stick")]
    public Sprite ControllerSteamdeckBlackRightStick { get; set; }
	[InLua("controller_steamdeck_black_rightshoulder")]
    public Sprite ControllerSteamdeckBlackRightshoulder { get; set; }
	[InLua("controller_steamdeck_black_rightstick")]
    public Sprite ControllerSteamdeckBlackRightstick { get; set; }
	[InLua("controller_steamdeck_black_righttrigger")]
    public Sprite ControllerSteamdeckBlackRighttrigger { get; set; }
	[InLua("controller_steamdeck_black_start")]
    public Sprite ControllerSteamdeckBlackStart { get; set; }
	[InLua("controller_steamdeck_black_x")]
    public Sprite ControllerSteamdeckBlackX { get; set; }
	[InLua("controller_steamdeck_black_y")]
    public Sprite ControllerSteamdeckBlackY { get; set; }
	[InLua("controller_steamdeck_dpdown")]
    public Sprite ControllerSteamdeckDpdown { get; set; }
	[InLua("controller_steamdeck_dpleft")]
    public Sprite ControllerSteamdeckDpleft { get; set; }
	[InLua("controller_steamdeck_dpright")]
    public Sprite ControllerSteamdeckDpright { get; set; }
	[InLua("controller_steamdeck_dpup")]
    public Sprite ControllerSteamdeckDpup { get; set; }
	[InLua("controller_steamdeck_left_stick")]
    public Sprite ControllerSteamdeckLeftStick { get; set; }
	[InLua("controller_steamdeck_leftshoulder")]
    public Sprite ControllerSteamdeckLeftshoulder { get; set; }
	[InLua("controller_steamdeck_leftstick")]
    public Sprite ControllerSteamdeckLeftstick { get; set; }
	[InLua("controller_steamdeck_lefttrigger")]
    public Sprite ControllerSteamdeckLefttrigger { get; set; }
	[InLua("controller_steamdeck_paddle1")]
    public Sprite ControllerSteamdeckPaddle1 { get; set; }
	[InLua("controller_steamdeck_paddle2")]
    public Sprite ControllerSteamdeckPaddle2 { get; set; }
	[InLua("controller_steamdeck_paddle3")]
    public Sprite ControllerSteamdeckPaddle3 { get; set; }
	[InLua("controller_steamdeck_paddle4")]
    public Sprite ControllerSteamdeckPaddle4 { get; set; }
	[InLua("controller_steamdeck_right_stick")]
    public Sprite ControllerSteamdeckRightStick { get; set; }
	[InLua("controller_steamdeck_rightshoulder")]
    public Sprite ControllerSteamdeckRightshoulder { get; set; }
	[InLua("controller_steamdeck_rightstick")]
    public Sprite ControllerSteamdeckRightstick { get; set; }
	[InLua("controller_steamdeck_righttrigger")]
    public Sprite ControllerSteamdeckRighttrigger { get; set; }
	[InLua("controller_steamdeck_start")]
    public Sprite ControllerSteamdeckStart { get; set; }
	[InLua("controller_steamdeck_x")]
    public Sprite ControllerSteamdeckX { get; set; }
	[InLua("controller_steamdeck_y")]
    public Sprite ControllerSteamdeckY { get; set; }
	[InLua("controller_xbox_a")]
    public Sprite ControllerXboxA { get; set; }
	[InLua("controller_xbox_b")]
    public Sprite ControllerXboxB { get; set; }
	[InLua("controller_xbox_back")]
    public Sprite ControllerXboxBack { get; set; }
	[InLua("controller_xbox_black_a")]
    public Sprite ControllerXboxBlackA { get; set; }
	[InLua("controller_xbox_black_b")]
    public Sprite ControllerXboxBlackB { get; set; }
	[InLua("controller_xbox_black_back")]
    public Sprite ControllerXboxBlackBack { get; set; }
	[InLua("controller_xbox_black_dpdown")]
    public Sprite ControllerXboxBlackDpdown { get; set; }
	[InLua("controller_xbox_black_dpleft")]
    public Sprite ControllerXboxBlackDpleft { get; set; }
	[InLua("controller_xbox_black_dpright")]
    public Sprite ControllerXboxBlackDpright { get; set; }
	[InLua("controller_xbox_black_dpup")]
    public Sprite ControllerXboxBlackDpup { get; set; }
	[InLua("controller_xbox_black_left_stick")]
    public Sprite ControllerXboxBlackLeftStick { get; set; }
	[InLua("controller_xbox_black_leftshoulder")]
    public Sprite ControllerXboxBlackLeftshoulder { get; set; }
	[InLua("controller_xbox_black_leftstick")]
    public Sprite ControllerXboxBlackLeftstick { get; set; }
	[InLua("controller_xbox_black_lefttrigger")]
    public Sprite ControllerXboxBlackLefttrigger { get; set; }
	[InLua("controller_xbox_black_right_stick")]
    public Sprite ControllerXboxBlackRightStick { get; set; }
	[InLua("controller_xbox_black_rightshoulder")]
    public Sprite ControllerXboxBlackRightshoulder { get; set; }
	[InLua("controller_xbox_black_rightstick")]
    public Sprite ControllerXboxBlackRightstick { get; set; }
	[InLua("controller_xbox_black_righttrigger")]
    public Sprite ControllerXboxBlackRighttrigger { get; set; }
	[InLua("controller_xbox_black_start")]
    public Sprite ControllerXboxBlackStart { get; set; }
	[InLua("controller_xbox_black_x")]
    public Sprite ControllerXboxBlackX { get; set; }
	[InLua("controller_xbox_black_y")]
    public Sprite ControllerXboxBlackY { get; set; }
	[InLua("controller_xbox_dpdown")]
    public Sprite ControllerXboxDpdown { get; set; }
	[InLua("controller_xbox_dpleft")]
    public Sprite ControllerXboxDpleft { get; set; }
	[InLua("controller_xbox_dpright")]
    public Sprite ControllerXboxDpright { get; set; }
	[InLua("controller_xbox_dpup")]
    public Sprite ControllerXboxDpup { get; set; }
	[InLua("controller_xbox_left_stick")]
    public Sprite ControllerXboxLeftStick { get; set; }
	[InLua("controller_xbox_leftshoulder")]
    public Sprite ControllerXboxLeftshoulder { get; set; }
	[InLua("controller_xbox_leftstick")]
    public Sprite ControllerXboxLeftstick { get; set; }
	[InLua("controller_xbox_lefttrigger")]
    public Sprite ControllerXboxLefttrigger { get; set; }
	[InLua("controller_xbox_right_stick")]
    public Sprite ControllerXboxRightStick { get; set; }
	[InLua("controller_xbox_rightshoulder")]
    public Sprite ControllerXboxRightshoulder { get; set; }
	[InLua("controller_xbox_rightstick")]
    public Sprite ControllerXboxRightstick { get; set; }
	[InLua("controller_xbox_righttrigger")]
    public Sprite ControllerXboxRighttrigger { get; set; }
	[InLua("controller_xbox_start")]
    public Sprite ControllerXboxStart { get; set; }
	[InLua("controller_xbox_x")]
    public Sprite ControllerXboxX { get; set; }
	[InLua("controller_xbox_y")]
    public Sprite ControllerXboxY { get; set; }
	[InLua("copper_wire")]
    public Sprite CopperWire { get; set; }
	[InLua("copy")]
    public Sprite Copy { get; set; }
	[InLua("covered_chunk")]
    public Sprite CoveredChunk { get; set; }
	[InLua("crafting_machine_recipe_not_unlocked")]
    public Sprite CraftingMachineRecipeNotUnlocked { get; set; }
	[InLua("cross_select")]
    public Sprite CrossSelect { get; set; }
	[InLua("cursor_box")]
    public CursorBoxSpecification CursorBox { get; set; }
	[InLua("cursor_icon")]
    public Sprite CursorIcon { get; set; }
	[InLua("custom_tag_icon")]
    public Sprite CustomTagIcon { get; set; }
	[InLua("custom_tag_in_map_view")]
    public Sprite CustomTagInMapView { get; set; }
	[InLua("danger_icon")]
    public Sprite DangerIcon { get; set; }
	[InLua("deconstruction_mark")]
    public Sprite DeconstructionMark { get; set; }
	[InLua("deconstruction_time_to_live_modifier_constant")]
    public Sprite? DeconstructionTimeToLiveModifierConstant { get; set; }
	[InLua("deconstruction_time_to_live_modifier_icon")]
    public Sprite DeconstructionTimeToLiveModifierIcon { get; set; }
	[InLua("decorative_editor_icon")]
    public Sprite DecorativeEditorIcon { get; set; }
	[InLua("default_ammo_damage_modifier_icon")]
    public Sprite DefaultAmmoDamageModifierIcon { get; set; }
	[InLua("default_gun_speed_modifier_icon")]
    public Sprite DefaultGunSpeedModifierIcon { get; set; }
	[InLua("default_turret_attack_modifier_icon")]
    public Sprite DefaultTurretAttackModifierIcon { get; set; }
	[InLua("destroyed_icon")]
    public Sprite DestroyedIcon { get; set; }
	[InLua("down_arrow")]
    public Sprite DownArrow { get; set; }
	[InLua("downloaded")]
    public Sprite Downloaded { get; set; }
	[InLua("downloaded_white")]
    public Sprite DownloadedWhite { get; set; }
	[InLua("downloading")]
    public Sprite Downloading { get; set; }
	[InLua("downloading_white")]
    public Sprite DownloadingWhite { get; set; }
	[InLua("dropdown")]
    public Sprite Dropdown { get; set; }
	[InLua("editor_pause")]
    public Sprite EditorPause { get; set; }
	[InLua("editor_play")]
    public Sprite EditorPlay { get; set; }
	[InLua("editor_selection")]
    public Sprite EditorSelection { get; set; }
	[InLua("editor_speed_down")]
    public Sprite EditorSpeedDown { get; set; }
	[InLua("editor_speed_up")]
    public Sprite EditorSpeedUp { get; set; }
	[InLua("electricity_icon")]
    public Sprite ElectricityIcon { get; set; }
	[InLua("electricity_icon_unplugged")]
    public Sprite ElectricityIconUnplugged { get; set; }
	[InLua("enemy_force_icon")]
    public Sprite EnemyForceIcon { get; set; }
	[InLua("enter")]
    public Sprite Enter { get; set; }
	[InLua("entity_editor_icon")]
    public Sprite EntityEditorIcon { get; set; }
	[InLua("entity_info_dark_background")]
    public Sprite EntityInfoDarkBackground { get; set; }
	[InLua("equipment_collision")]
    public Sprite EquipmentCollision { get; set; }
	[InLua("equipment_grid")]
    public Sprite EquipmentGrid { get; set; }
	[InLua("equipment_slot")]
    public Sprite EquipmentSlot { get; set; }
	[InLua("expand")]
    public Sprite Expand { get; set; }
	[InLua("expand_dark")]
    public Sprite ExpandDark { get; set; }
	[InLua("expand_dots")]
    public Sprite ExpandDots { get; set; }
	[InLua("expand_dots_white")]
    public Sprite ExpandDotsWhite { get; set; }
	[InLua("explosion_chart_visualization")]
    public Animation ExplosionChartVisualization { get; set; }
	[InLua("export")]
    public Sprite Export { get; set; }
	[InLua("export_slot")]
    public Sprite ExportSlot { get; set; }
	[InLua("favourite_server_icon")]
    public Sprite FavouriteServerIcon { get; set; }
	[InLua("fluid_icon")]
    public Sprite FluidIcon { get; set; }
	[InLua("fluid_indication_arrow")]
    public Sprite FluidIndicationArrow { get; set; }
	[InLua("fluid_indication_arrow_both_ways")]
    public Sprite FluidIndicationArrowBothWays { get; set; }
	[InLua("follower_robot_lifetime_modifier_constant")]
    public Sprite? FollowerRobotLifetimeModifierConstant { get; set; }
	[InLua("follower_robot_lifetime_modifier_icon")]
    public Sprite FollowerRobotLifetimeModifierIcon { get; set; }
	[InLua("force_editor_icon")]
    public Sprite ForceEditorIcon { get; set; }
	[InLua("fuel_icon")]
    public Sprite FuelIcon { get; set; }
	[InLua("game_stopped_visualization")]
    public Sprite GameStoppedVisualization { get; set; }
	[InLua("ghost_bar_pip")]
    public Sprite GhostBarPip { get; set; }
	[InLua("ghost_cursor")]
    public Sprite GhostCursor { get; set; }
	[InLua("ghost_time_to_live_modifier_constant")]
    public Sprite? GhostTimeToLiveModifierConstant { get; set; }
	[InLua("ghost_time_to_live_modifier_icon")]
    public Sprite GhostTimeToLiveModifierIcon { get; set; }
	[InLua("give_item_modifier_constant")]
    public Sprite? GiveItemModifierConstant { get; set; }
	[InLua("give_item_modifier_icon")]
    public Sprite GiveItemModifierIcon { get; set; }
	[InLua("go_to_arrow")]
    public Sprite GoToArrow { get; set; }
	[InLua("gps_map_icon")]
    public Sprite GpsMapIcon { get; set; }
	[InLua("gradient")]
    public Sprite Gradient { get; set; }
	[InLua("green_circle")]
    public Sprite GreenCircle { get; set; }
	[InLua("green_dot")]
    public Sprite GreenDot { get; set; }
	[InLua("green_wire")]
    public Sprite GreenWire { get; set; }
	[InLua("green_wire_hightlight")]
    public Sprite GreenWireHightlight { get; set; }
	[InLua("grey_placement_indicator_leg")]
    public Sprite GreyPlacementIndicatorLeg { get; set; }
	[InLua("grey_rail_signal_placement_indicator")]
    public Sprite GreyRailSignalPlacementIndicator { get; set; }
	[InLua("grid_view")]
    public Sprite GridView { get; set; }
	[InLua("gun_speed_modifier_constant")]
    public Sprite? GunSpeedModifierConstant { get; set; }
	[InLua("gun_speed_modifier_icon")]
    public Sprite GunSpeedModifierIcon { get; set; }
	[InLua("hand")]
    public Sprite Hand { get; set; }
	[InLua("hand_black")]
    public Sprite HandBlack { get; set; }
	[InLua("health_bar_green_pip")]
    public Sprite HealthBarGreenPip { get; set; }
	[InLua("health_bar_red_pip")]
    public Sprite HealthBarRedPip { get; set; }
	[InLua("health_bar_yellow_pip")]
    public Sprite HealthBarYellowPip { get; set; }
	[InLua("heat_exchange_indication")]
    public Sprite HeatExchangeIndication { get; set; }
	[InLua("hint_arrow_down")]
    public Sprite HintArrowDown { get; set; }
	[InLua("hint_arrow_left")]
    public Sprite HintArrowLeft { get; set; }
	[InLua("hint_arrow_right")]
    public Sprite HintArrowRight { get; set; }
	[InLua("hint_arrow_up")]
    public Sprite HintArrowUp { get; set; }
	[InLua("import")]
    public Sprite Import { get; set; }
	[InLua("import_slot")]
    public Sprite ImportSlot { get; set; }
	[InLua("indication_arrow")]
    public Sprite IndicationArrow { get; set; }
	[InLua("indication_line")]
    public Sprite IndicationLine { get; set; }
	[InLua("inserter_stack_size_bonus_modifier_constant")]
    public Sprite? InserterStackSizeBonusModifierConstant { get; set; }
	[InLua("inserter_stack_size_bonus_modifier_icon")]
    public Sprite InserterStackSizeBonusModifierIcon { get; set; }
	[InLua("item_editor_icon")]
    public Sprite ItemEditorIcon { get; set; }
	[InLua("laboratory_productivity_modifier_constant")]
    public Sprite? LaboratoryProductivityModifierConstant { get; set; }
	[InLua("laboratory_productivity_modifier_icon")]
    public Sprite LaboratoryProductivityModifierIcon { get; set; }
	[InLua("laboratory_speed_modifier_constant")]
    public Sprite? LaboratorySpeedModifierConstant { get; set; }
	[InLua("laboratory_speed_modifier_icon")]
    public Sprite LaboratorySpeedModifierIcon { get; set; }
	[InLua("left_arrow")]
    public Sprite LeftArrow { get; set; }
	[InLua("light_cone")]
    public Sprite LightCone { get; set; }
	[InLua("light_medium")]
    public Sprite LightMedium { get; set; }
	[InLua("light_small")]
    public Sprite LightSmall { get; set; }
	[InLua("line_icon")]
    public Sprite LineIcon { get; set; }
	[InLua("list_view")]
    public Sprite ListView { get; set; }
	[InLua("logistic_network_panel_black")]
    public Sprite LogisticNetworkPanelBlack { get; set; }
	[InLua("logistic_network_panel_white")]
    public Sprite LogisticNetworkPanelWhite { get; set; }
	[InLua("logistic_radius_visualization")]
    public Sprite LogisticRadiusVisualization { get; set; }
	[InLua("lua_snippet_tool_icon")]
    public Sprite LuaSnippetToolIcon { get; set; }
	[InLua("map")]
    public Sprite Map { get; set; }
	[InLua("map_exchange_string")]
    public Sprite MapExchangeString { get; set; }
	[InLua("max_failed_attempts_per_tick_per_construction_queue_modifier_constant")]
    public Sprite? MaxFailedAttemptsPerTickPerConstructionQueueModifierConstant { get; set; }
	[InLua("max_failed_attempts_per_tick_per_construction_queue_modifier_icon")]
    public Sprite MaxFailedAttemptsPerTickPerConstructionQueueModifierIcon { get; set; }
	[InLua("max_successful_attempts_per_tick_per_construction_queue_modifier_constant")]
    public Sprite? MaxSuccessfulAttemptsPerTickPerConstructionQueueModifierConstant { get; set; }
	[InLua("max_successful_attempts_per_tick_per_construction_queue_modifier_icon")]
    public Sprite MaxSuccessfulAttemptsPerTickPerConstructionQueueModifierIcon { get; set; }
	[InLua("maximum_following_robots_count_modifier_constant")]
    public Sprite? MaximumFollowingRobotsCountModifierConstant { get; set; }
	[InLua("maximum_following_robots_count_modifier_icon")]
    public Sprite MaximumFollowingRobotsCountModifierIcon { get; set; }
	[InLua("medium_gui_arrow")]
    public Sprite MediumGuiArrow { get; set; }
	[InLua("mining_drill_productivity_bonus_modifier_constant")]
    public Sprite? MiningDrillProductivityBonusModifierConstant { get; set; }
	[InLua("mining_drill_productivity_bonus_modifier_icon")]
    public Sprite MiningDrillProductivityBonusModifierIcon { get; set; }
	[InLua("missing_icon")]
    public Sprite MissingIcon { get; set; }
	[InLua("missing_mod_icon")]
    public Sprite MissingModIcon { get; set; }
	[InLua("mod_dependency_arrow")]
    public Sprite ModDependencyArrow { get; set; }
	[InLua("mouse_cursor")]
    public Sprite MouseCursor { get; set; }
	[InLua("multiplayer_waiting_icon")]
    public Sprite MultiplayerWaitingIcon { get; set; }
	[InLua("nature_icon")]
    public Sprite NatureIcon { get; set; }
	[InLua("neutral_force_icon")]
    public Sprite NeutralForceIcon { get; set; }
	[InLua("no_building_material_icon")]
    public Sprite NoBuildingMaterialIcon { get; set; }
	[InLua("no_nature_icon")]
    public Sprite NoNatureIcon { get; set; }
	[InLua("no_storage_space_icon")]
    public Sprite NoStorageSpaceIcon { get; set; }
	[InLua("none_editor_icon")]
    public Sprite NoneEditorIcon { get; set; }
	[InLua("not_available")]
    public Sprite NotAvailable { get; set; }
	[InLua("not_enough_construction_robots_icon")]
    public Sprite NotEnoughConstructionRobotsIcon { get; set; }
	[InLua("not_enough_repair_packs_icon")]
    public Sprite NotEnoughRepairPacksIcon { get; set; }
	[InLua("not_played_yet_dark_green")]
    public Sprite NotPlayedYetDarkGreen { get; set; }
	[InLua("not_played_yet_green")]
    public Sprite NotPlayedYetGreen { get; set; }
	[InLua("nothing_modifier_constant")]
    public Sprite? NothingModifierConstant { get; set; }
	[InLua("nothing_modifier_icon")]
    public Sprite NothingModifierIcon { get; set; }
	[InLua("notification")]
    public Sprite Notification { get; set; }
	[InLua("output_console_gradient")]
    public Sprite OutputConsoleGradient { get; set; }
	[InLua("paint_bucket_icon")]
    public Sprite PaintBucketIcon { get; set; }
	[InLua("pause")]
    public Sprite Pause { get; set; }
	[InLua("placement_indicator_leg")]
    public Sprite PlacementIndicatorLeg { get; set; }
	[InLua("play")]
    public Sprite Play { get; set; }
	[InLua("played_dark_green")]
    public Sprite PlayedDarkGreen { get; set; }
	[InLua("played_green")]
    public Sprite PlayedGreen { get; set; }
	[InLua("player_force_icon")]
    public Sprite PlayerForceIcon { get; set; }
	[InLua("preset")]
    public Sprite Preset { get; set; }
	[InLua("pump_cannot_connect_icon")]
    public Sprite PumpCannotConnectIcon { get; set; }
	[InLua("questionmark")]
    public Sprite Questionmark { get; set; }
	[InLua("rail_path_not_possible")]
    public Sprite RailPathNotPossible { get; set; }
	[InLua("rail_planner_indication_arrow")]
    public Sprite RailPlannerIndicationArrow { get; set; }
	[InLua("rail_planner_indication_arrow_too_far")]
    public Sprite RailPlannerIndicationArrowTooFar { get; set; }
	[InLua("rail_signal_placement_indicator")]
    public Sprite RailSignalPlacementIndicator { get; set; }
	[InLua("reassign")]
    public Sprite Reassign { get; set; }
	[InLua("recharge_icon")]
    public Sprite RechargeIcon { get; set; }
	[InLua("red_wire")]
    public Sprite RedWire { get; set; }
	[InLua("red_wire_hightlight")]
    public Sprite RedWireHightlight { get; set; }
	[InLua("reference_point")]
    public Sprite ReferencePoint { get; set; }
	[InLua("refresh")]
    public Sprite Refresh { get; set; }
	[InLua("refresh_white")]
    public Animation RefreshWhite { get; set; }
	[InLua("rename_icon_normal")]
    public Sprite RenameIconNormal { get; set; }
	[InLua("rename_icon_small_black")]
    public Sprite RenameIconSmallBlack { get; set; }
	[InLua("rename_icon_small_white")]
    public Sprite RenameIconSmallWhite { get; set; }
	[InLua("reset")]
    public Sprite Reset { get; set; }
	[InLua("reset_white")]
    public Sprite ResetWhite { get; set; }
	[InLua("resource_editor_icon")]
    public Sprite ResourceEditorIcon { get; set; }
	[InLua("right_arrow")]
    public Sprite RightArrow { get; set; }
	[InLua("robot_slot")]
    public Sprite RobotSlot { get; set; }
	[InLua("scripting_editor_icon")]
    public Sprite ScriptingEditorIcon { get; set; }
	[InLua("search_black")]
    public Sprite SearchBlack { get; set; }
	[InLua("search_icon")]
    public Sprite SearchIcon { get; set; }
	[InLua("search_white")]
    public Sprite SearchWhite { get; set; }
	[InLua("select_icon_black")]
    public Sprite SelectIconBlack { get; set; }
	[InLua("select_icon_white")]
    public Sprite SelectIconWhite { get; set; }
	[InLua("set_bar_slot")]
    public Sprite SetBarSlot { get; set; }
	[InLua("shield_bar_pip")]
    public Sprite ShieldBarPip { get; set; }
	[InLua("shoot_cursor_green")]
    public Sprite ShootCursorGreen { get; set; }
	[InLua("shoot_cursor_red")]
    public Sprite ShootCursorRed { get; set; }
	[InLua("short_indication_line")]
    public Sprite ShortIndicationLine { get; set; }
	[InLua("short_indication_line_green")]
    public Sprite ShortIndicationLineGreen { get; set; }
	[InLua("show_electric_network_in_map_view")]
    public Sprite ShowElectricNetworkInMapView { get; set; }
	[InLua("show_electric_network_in_map_view_black")]
    public Sprite ShowElectricNetworkInMapViewBlack { get; set; }
	[InLua("show_logistics_network_in_map_view")]
    public Sprite ShowLogisticsNetworkInMapView { get; set; }
	[InLua("show_logistics_network_in_map_view_black")]
    public Sprite ShowLogisticsNetworkInMapViewBlack { get; set; }
	[InLua("show_player_names_in_map_view")]
    public Sprite ShowPlayerNamesInMapView { get; set; }
	[InLua("show_player_names_in_map_view_black")]
    public Sprite ShowPlayerNamesInMapViewBlack { get; set; }
	[InLua("show_pollution_in_map_view")]
    public Sprite ShowPollutionInMapView { get; set; }
	[InLua("show_pollution_in_map_view_black")]
    public Sprite ShowPollutionInMapViewBlack { get; set; }
	[InLua("show_rail_signal_states_in_map_view")]
    public Sprite ShowRailSignalStatesInMapView { get; set; }
	[InLua("show_rail_signal_states_in_map_view_black")]
    public Sprite ShowRailSignalStatesInMapViewBlack { get; set; }
	[InLua("show_recipe_icons_in_map_view")]
    public Sprite ShowRecipeIconsInMapView { get; set; }
	[InLua("show_recipe_icons_in_map_view_black")]
    public Sprite ShowRecipeIconsInMapViewBlack { get; set; }
	[InLua("show_tags_in_map_view")]
    public Sprite ShowTagsInMapView { get; set; }
	[InLua("show_tags_in_map_view_black")]
    public Sprite ShowTagsInMapViewBlack { get; set; }
	[InLua("show_train_station_names_in_map_view")]
    public Sprite ShowTrainStationNamesInMapView { get; set; }
	[InLua("show_train_station_names_in_map_view_black")]
    public Sprite ShowTrainStationNamesInMapViewBlack { get; set; }
	[InLua("show_turret_range_in_map_view")]
    public Sprite ShowTurretRangeInMapView { get; set; }
	[InLua("show_turret_range_in_map_view_black")]
    public Sprite ShowTurretRangeInMapViewBlack { get; set; }
	[InLua("show_worker_robots_in_map_view")]
    public Sprite ShowWorkerRobotsInMapView { get; set; }
	[InLua("show_worker_robots_in_map_view_black")]
    public Sprite ShowWorkerRobotsInMapViewBlack { get; set; }
	[InLua("shuffle")]
    public Sprite Shuffle { get; set; }
	[InLua("side_menu_achievements_hover_icon")]
    public Sprite SideMenuAchievementsHoverIcon { get; set; }
	[InLua("side_menu_achievements_icon")]
    public Sprite SideMenuAchievementsIcon { get; set; }
	[InLua("side_menu_blueprint_library_hover_icon")]
    public Sprite SideMenuBlueprintLibraryHoverIcon { get; set; }
	[InLua("side_menu_blueprint_library_icon")]
    public Sprite SideMenuBlueprintLibraryIcon { get; set; }
	[InLua("side_menu_bonus_hover_icon")]
    public Sprite SideMenuBonusHoverIcon { get; set; }
	[InLua("side_menu_bonus_icon")]
    public Sprite SideMenuBonusIcon { get; set; }
	[InLua("side_menu_logistic_network_hover_icon")]
    public Sprite SideMenuLogisticNetworkHoverIcon { get; set; }
	[InLua("side_menu_map_hover_icon")]
    public Sprite SideMenuMapHoverIcon { get; set; }
	[InLua("side_menu_map_icon")]
    public Sprite SideMenuMapIcon { get; set; }
	[InLua("side_menu_menu_hover_icon")]
    public Sprite SideMenuMenuHoverIcon { get; set; }
	[InLua("side_menu_menu_icon")]
    public Sprite SideMenuMenuIcon { get; set; }
	[InLua("side_menu_production_hover_icon")]
    public Sprite SideMenuProductionHoverIcon { get; set; }
	[InLua("side_menu_production_icon")]
    public Sprite SideMenuProductionIcon { get; set; }
	[InLua("side_menu_technology_hover_icon")]
    public Sprite SideMenuTechnologyHoverIcon { get; set; }
	[InLua("side_menu_train_hover_icon")]
    public Sprite SideMenuTrainHoverIcon { get; set; }
	[InLua("side_menu_train_icon")]
    public Sprite SideMenuTrainIcon { get; set; }
	[InLua("side_menu_tutorials_hover_icon")]
    public Sprite SideMenuTutorialsHoverIcon { get; set; }
	[InLua("side_menu_tutorials_icon")]
    public Sprite SideMenuTutorialsIcon { get; set; }
	[InLua("slot")]
    public Sprite Slot { get; set; }
	[InLua("slot_icon_ammo")]
    public Sprite SlotIconAmmo { get; set; }
	[InLua("slot_icon_ammo_black")]
    public Sprite SlotIconAmmoBlack { get; set; }
	[InLua("slot_icon_armor")]
    public Sprite SlotIconArmor { get; set; }
	[InLua("slot_icon_armor_black")]
    public Sprite SlotIconArmorBlack { get; set; }
	[InLua("slot_icon_fuel")]
    public Sprite SlotIconFuel { get; set; }
	[InLua("slot_icon_fuel_black")]
    public Sprite SlotIconFuelBlack { get; set; }
	[InLua("slot_icon_gun")]
    public Sprite SlotIconGun { get; set; }
	[InLua("slot_icon_gun_black")]
    public Sprite SlotIconGunBlack { get; set; }
	[InLua("slot_icon_inserter_hand")]
    public Sprite SlotIconInserterHand { get; set; }
	[InLua("slot_icon_inserter_hand_black")]
    public Sprite SlotIconInserterHandBlack { get; set; }
	[InLua("slot_icon_module")]
    public Sprite SlotIconModule { get; set; }
	[InLua("slot_icon_module_black")]
    public Sprite SlotIconModuleBlack { get; set; }
	[InLua("slot_icon_resource")]
    public Sprite SlotIconResource { get; set; }
	[InLua("slot_icon_resource_black")]
    public Sprite SlotIconResourceBlack { get; set; }
	[InLua("slot_icon_result")]
    public Sprite SlotIconResult { get; set; }
	[InLua("slot_icon_result_black")]
    public Sprite SlotIconResultBlack { get; set; }
	[InLua("slot_icon_robot")]
    public Sprite SlotIconRobot { get; set; }
	[InLua("slot_icon_robot_black")]
    public Sprite SlotIconRobotBlack { get; set; }
	[InLua("slot_icon_robot_material")]
    public Sprite SlotIconRobotMaterial { get; set; }
	[InLua("slot_icon_robot_material_black")]
    public Sprite SlotIconRobotMaterialBlack { get; set; }
	[InLua("small_gui_arrow")]
    public Sprite SmallGuiArrow { get; set; }
	[InLua("spawn_flag")]
    public Sprite SpawnFlag { get; set; }
	[InLua("speed_down")]
    public Sprite SpeedDown { get; set; }
	[InLua("speed_up")]
    public Sprite SpeedUp { get; set; }
	[InLua("spray_icon")]
    public Sprite SprayIcon { get; set; }
	[InLua("stack_inserter_capacity_bonus_modifier_constant")]
    public Sprite? StackInserterCapacityBonusModifierConstant { get; set; }
	[InLua("stack_inserter_capacity_bonus_modifier_icon")]
    public Sprite StackInserterCapacityBonusModifierIcon { get; set; }
	[InLua("station_name")]
    public Sprite StationName { get; set; }
	[InLua("status_not_working")]
    public Sprite StatusNotWorking { get; set; }
	[InLua("status_working")]
    public Sprite StatusWorking { get; set; }
	[InLua("status_yellow")]
    public Sprite StatusYellow { get; set; }
	[InLua("stop")]
    public Sprite Stop { get; set; }
	[InLua("surface_editor_icon")]
    public Sprite SurfaceEditorIcon { get; set; }
	[InLua("sync_mods")]
    public Sprite SyncMods { get; set; }
	[InLua("technology_black")]
    public Sprite TechnologyBlack { get; set; }
	[InLua("technology_white")]
    public Sprite TechnologyWhite { get; set; }
	[InLua("tick_custom")]
    public Sprite TickCustom { get; set; }
	[InLua("tick_once")]
    public Sprite TickOnce { get; set; }
	[InLua("tick_sixty")]
    public Sprite TickSixty { get; set; }
	[InLua("tile_editor_icon")]
    public Sprite TileEditorIcon { get; set; }
	[InLua("tile_ghost_cursor")]
    public Sprite TileGhostCursor { get; set; }
	[InLua("time_editor_icon")]
    public Sprite TimeEditorIcon { get; set; }
	[InLua("too_far")]
    public Sprite TooFar { get; set; }
	[InLua("too_far_from_roboport_icon")]
    public Sprite TooFarFromRoboportIcon { get; set; }
	[InLua("track_button")]
    public Sprite TrackButton { get; set; }
	[InLua("train_braking_force_bonus_modifier_constant")]
    public Sprite? TrainBrakingForceBonusModifierConstant { get; set; }
	[InLua("train_braking_force_bonus_modifier_icon")]
    public Sprite TrainBrakingForceBonusModifierIcon { get; set; }
	[InLua("train_stop_disabled_in_map_view")]
    public Sprite TrainStopDisabledInMapView { get; set; }
	[InLua("train_stop_full_in_map_view")]
    public Sprite TrainStopFullInMapView { get; set; }
	[InLua("train_stop_in_map_view")]
    public Sprite TrainStopInMapView { get; set; }
	[InLua("train_stop_placement_indicator")]
    public Sprite TrainStopPlacementIndicator { get; set; }
	[InLua("trash")]
    public Sprite Trash { get; set; }
	[InLua("trash_white")]
    public Sprite TrashWhite { get; set; }
	[InLua("turret_attack_modifier_constant")]
    public Sprite? TurretAttackModifierConstant { get; set; }
	[InLua("turret_attack_modifier_icon")]
    public Sprite TurretAttackModifierIcon { get; set; }
	[InLua("underground_pipe_connection")]
    public Sprite UndergroundPipeConnection { get; set; }
	[InLua("underground_remove_belts")]
    public Sprite UndergroundRemoveBelts { get; set; }
	[InLua("underground_remove_pipes")]
    public Sprite UndergroundRemovePipes { get; set; }
	[InLua("unlock_recipe_modifier_constant")]
    public Sprite? UnlockRecipeModifierConstant { get; set; }
	[InLua("unlock_recipe_modifier_icon")]
    public Sprite UnlockRecipeModifierIcon { get; set; }
	[InLua("upgrade_blueprint")]
    public Sprite UpgradeBlueprint { get; set; }
	[InLua("upgrade_mark")]
    public Sprite UpgradeMark { get; set; }
	[InLua("variations_tool_icon")]
    public Sprite VariationsToolIcon { get; set; }
	[InLua("warning")]
    public Sprite Warning { get; set; }
	[InLua("warning_icon")]
    public Sprite WarningIcon { get; set; }
	[InLua("warning_white")]
    public Sprite WarningWhite { get; set; }
	[InLua("white_mask")]
    public Sprite WhiteMask { get; set; }
	[InLua("white_square")]
    public Sprite WhiteSquare { get; set; }
	[InLua("wire_shadow")]
    public Sprite WireShadow { get; set; }
	[InLua("worker_robot_battery_modifier_constant")]
    public Sprite? WorkerRobotBatteryModifierConstant { get; set; }
	[InLua("worker_robot_battery_modifier_icon")]
    public Sprite WorkerRobotBatteryModifierIcon { get; set; }
	[InLua("worker_robot_speed_modifier_constant")]
    public Sprite? WorkerRobotSpeedModifierConstant { get; set; }
	[InLua("worker_robot_speed_modifier_icon")]
    public Sprite WorkerRobotSpeedModifierIcon { get; set; }
	[InLua("worker_robot_storage_modifier_constant")]
    public Sprite? WorkerRobotStorageModifierConstant { get; set; }
	[InLua("worker_robot_storage_modifier_icon")]
    public Sprite WorkerRobotStorageModifierIcon { get; set; }
	[InLua("zoom_to_world_blueprint_enabled_modifier_constant")]
    public Sprite? ZoomToWorldBlueprintEnabledModifierConstant { get; set; }
	[InLua("zoom_to_world_blueprint_enabled_modifier_icon")]
    public Sprite ZoomToWorldBlueprintEnabledModifierIcon { get; set; }
	[InLua("zoom_to_world_deconstruction_planner_enabled_modifier_constant")]
    public Sprite? ZoomToWorldDeconstructionPlannerEnabledModifierConstant { get; set; }
	[InLua("zoom_to_world_deconstruction_planner_enabled_modifier_icon")]
    public Sprite ZoomToWorldDeconstructionPlannerEnabledModifierIcon { get; set; }
	[InLua("zoom_to_world_enabled_modifier_constant")]
    public Sprite? ZoomToWorldEnabledModifierConstant { get; set; }
	[InLua("zoom_to_world_enabled_modifier_icon")]
    public Sprite ZoomToWorldEnabledModifierIcon { get; set; }
	[InLua("zoom_to_world_ghost_building_enabled_modifier_constant")]
    public Sprite? ZoomToWorldGhostBuildingEnabledModifierConstant { get; set; }
	[InLua("zoom_to_world_ghost_building_enabled_modifier_icon")]
    public Sprite ZoomToWorldGhostBuildingEnabledModifierIcon { get; set; }
	[InLua("zoom_to_world_selection_tool_enabled_modifier_constant")]
    public Sprite? ZoomToWorldSelectionToolEnabledModifierConstant { get; set; }
	[InLua("zoom_to_world_selection_tool_enabled_modifier_icon")]
    public Sprite ZoomToWorldSelectionToolEnabledModifierIcon { get; set; }
	[InLua("zoom_to_world_upgrade_planner_enabled_modifier_constant")]
    public Sprite? ZoomToWorldUpgradePlannerEnabledModifierConstant { get; set; }
	[InLua("zoom_to_world_upgrade_planner_enabled_modifier_icon")]
    public Sprite ZoomToWorldUpgradePlannerEnabledModifierIcon { get; set; }

    
    
    
    

    

    
}
using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("UtilitySounds")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class UtilitySounds : PrototypeBase
{
    [InLua("achievement_unlocked")]
    public Sound AchievementUnlocked { get; set; }
	[InLua("alert_destroyed")]
    public Sound AlertDestroyed { get; set; }
	[InLua("armor_insert")]
    public Sound ArmorInsert { get; set; }
	[InLua("armor_remove")]
    public Sound ArmorRemove { get; set; }
	[InLua("axe_fighting")]
    public Sound AxeFighting { get; set; }
	[InLua("axe_mining_ore")]
    public Sound AxeMiningOre { get; set; }
	[InLua("blueprint_selection_ended")]
    public Sound BlueprintSelectionEnded { get; set; }
	[InLua("blueprint_selection_started")]
    public Sound BlueprintSelectionStarted { get; set; }
	[InLua("build_blueprint_large")]
    public Sound BuildBlueprintLarge { get; set; }
	[InLua("build_blueprint_medium")]
    public Sound BuildBlueprintMedium { get; set; }
	[InLua("build_blueprint_small")]
    public Sound BuildBlueprintSmall { get; set; }
	[InLua("build_large")]
    public Sound BuildLarge { get; set; }
	[InLua("build_medium")]
    public Sound BuildMedium { get; set; }
	[InLua("build_small")]
    public Sound BuildSmall { get; set; }
	[InLua("cancel_deconstruction_selection_ended")]
    public Sound CancelDeconstructionSelectionEnded { get; set; }
	[InLua("cancel_deconstruction_selection_started")]
    public Sound CancelDeconstructionSelectionStarted { get; set; }
	[InLua("cannot_build")]
    public Sound CannotBuild { get; set; }
	[InLua("clear_cursor")]
    public Sound ClearCursor { get; set; }
	[InLua("confirm")]
    public Sound Confirm { get; set; }
	[InLua("console_message")]
    public Sound ConsoleMessage { get; set; }
	[InLua("copy_activated")]
    public Sound CopyActivated { get; set; }
	[InLua("crafting_finished")]
    public Sound CraftingFinished { get; set; }
	[InLua("cut_activated")]
    public Sound CutActivated { get; set; }
	[InLua("deconstruct_big")]
    public Sound DeconstructBig { get; set; }
	[InLua("deconstruct_medium")]
    public Sound DeconstructMedium { get; set; }
	[InLua("deconstruct_robot")]
    public Sound DeconstructRobot { get; set; }
	[InLua("deconstruct_small")]
    public Sound DeconstructSmall { get; set; }
	[InLua("deconstruction_selection_ended")]
    public Sound DeconstructionSelectionEnded { get; set; }
	[InLua("deconstruction_selection_started")]
    public Sound DeconstructionSelectionStarted { get; set; }
	[InLua("default_manual_repair")]
    public Sound DefaultManualRepair { get; set; }
	[InLua("drop_item")]
    public Sound DropItem { get; set; }
	[InLua("entity_settings_copied")]
    public Sound EntitySettingsCopied { get; set; }
	[InLua("entity_settings_pasted")]
    public Sound EntitySettingsPasted { get; set; }
	[InLua("game_lost")]
    public Sound GameLost { get; set; }
	[InLua("game_won")]
    public Sound GameWon { get; set; }
	[InLua("gui_click")]
    public Sound GuiClick { get; set; }
	[InLua("inventory_click")]
    public Sound InventoryClick { get; set; }
	[InLua("inventory_move")]
    public Sound InventoryMove { get; set; }
	[InLua("item_deleted")]
    public Sound ItemDeleted { get; set; }
	[InLua("item_spawned")]
    public Sound ItemSpawned { get; set; }
	[InLua("list_box_click")]
    public Sound ListBoxClick { get; set; }
	[InLua("metal_walking_sound")]
    public Sound MetalWalkingSound { get; set; }
	[InLua("mining_wood")]
    public Sound MiningWood { get; set; }
	[InLua("new_objective")]
    public Sound NewObjective { get; set; }
	[InLua("paste_activated")]
    public Sound PasteActivated { get; set; }
	[InLua("picked_up_item")]
    public Sound PickedUpItem { get; set; }
	[InLua("rail_plan_start")]
    public Sound RailPlanStart { get; set; }
	[InLua("research_completed")]
    public Sound ResearchCompleted { get; set; }
	[InLua("rotated_big")]
    public Sound RotatedBig { get; set; }
	[InLua("rotated_medium")]
    public Sound RotatedMedium { get; set; }
	[InLua("rotated_small")]
    public Sound RotatedSmall { get; set; }
	[InLua("scenario_message")]
    public Sound ScenarioMessage { get; set; }
	[InLua("smart_pipette")]
    public Sound SmartPipette { get; set; }
	[InLua("switch_gun")]
    public Sound SwitchGun { get; set; }
	[InLua("tutorial_notice")]
    public Sound TutorialNotice { get; set; }
	[InLua("undo")]
    public Sound Undo { get; set; }
	[InLua("upgrade_selection_ended")]
    public Sound UpgradeSelectionEnded { get; set; }
	[InLua("upgrade_selection_started")]
    public Sound UpgradeSelectionStarted { get; set; }
	[InLua("wire_connect_pole")]
    public Sound WireConnectPole { get; set; }
	[InLua("wire_disconnect")]
    public Sound WireDisconnect { get; set; }
	[InLua("wire_pickup")]
    public Sound WirePickup { get; set; }

    
    
    
    

    

    
}
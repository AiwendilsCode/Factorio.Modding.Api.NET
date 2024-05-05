using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("EditorControllerPrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class EditorControllerPrototype 
{
    [InLua("adjust_speed_based_off_zoom")]
    public bool AdjustSpeedBasedOffZoom { get; set; }
	[InLua("enable_flash_light")]
    public bool EnableFlashLight { get; set; }
	[InLua("fill_built_entity_energy_buffers")]
    public bool FillBuiltEntityEnergyBuffers { get; set; }
	[InLua("generate_neighbor_chunks")]
    public bool GenerateNeighborChunks { get; set; }
	[InLua("gun_inventory_size")]
    public ItemStackIndex GunInventorySize { get; set; }
	[InLua("instant_blueprint_building")]
    public bool InstantBlueprintBuilding { get; set; }
	[InLua("instant_deconstruction")]
    public bool InstantDeconstruction { get; set; }
	[InLua("instant_rail_planner")]
    public bool InstantRailPlanner { get; set; }
	[InLua("instant_upgrading")]
    public bool InstantUpgrading { get; set; }
	[InLua("inventory_size")]
    public ItemStackIndex InventorySize { get; set; }
	[InLua("item_pickup_distance")]
    public double ItemPickupDistance { get; set; }
	[InLua("loot_pickup_distance")]
    public double LootPickupDistance { get; set; }
	[InLua("mining_speed")]
    public double MiningSpeed { get; set; }
	[InLua("movement_speed")]
    public double MovementSpeed { get; set; }
	[InLua("name")]
    public string Name { get; set; }
	[InLua("placed_corpses_never_expire")]
    public bool PlacedCorpsesNeverExpire { get; set; }
	[InLua("render_as_day")]
    public bool RenderAsDay { get; set; }
	[InLua("show_additional_entity_info_gui")]
    public bool ShowAdditionalEntityInfoGui { get; set; }
	[InLua("show_character_tab_in_controller_gui")]
    public bool ShowCharacterTabInControllerGui { get; set; }
	[InLua("show_entity_health_bars")]
    public bool ShowEntityHealthBars { get; set; }
	[InLua("show_entity_tags")]
    public bool ShowEntityTags { get; set; }
	[InLua("show_hidden_entities")]
    public bool ShowHiddenEntities { get; set; }
	[InLua("show_infinity_filters_in_controller_gui")]
    public bool ShowInfinityFiltersInControllerGui { get; set; }
	[InLua("show_status_icons")]
    public bool ShowStatusIcons { get; set; }
	[InLua("type")]
    public string Type { get; } = "editor-controller";

    
    
    
    

    

    
}
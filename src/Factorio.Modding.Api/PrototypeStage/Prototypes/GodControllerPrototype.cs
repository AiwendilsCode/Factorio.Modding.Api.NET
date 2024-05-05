using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("GodControllerPrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class GodControllerPrototype 
{
    [InLua("crafting_categories")]
    public RecipeCategoryID[]? CraftingCategories { get; set; }
	[InLua("inventory_size")]
    public ItemStackIndex InventorySize { get; set; }
	[InLua("item_pickup_distance")]
    public double ItemPickupDistance { get; set; }
	[InLua("loot_pickup_distance")]
    public double LootPickupDistance { get; set; }
	[InLua("mining_categories")]
    public ResourceCategoryID[]? MiningCategories { get; set; }
	[InLua("mining_speed")]
    public double MiningSpeed { get; set; }
	[InLua("movement_speed")]
    public double MovementSpeed { get; set; }
	[InLua("name")]
    public string Name { get; set; }
	[InLua("type")]
    public string Type { get; } = "god-controller";

    
    
    
    

    

    
}
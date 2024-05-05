using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("ItemWithInventoryPrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class ItemWithInventoryPrototype : ItemWithLabelPrototype
{
    [InLua("extends_inventory_by_default")]
    public bool? ExtendsInventoryByDefault { get; set; }
	[InLua("filter_message_key")]
    public string? FilterMessageKey { get; set; }
	[InLua("filter_mode")]
    public FilterModeEnum? FilterMode { get; set; }
	[InLua("insertion_priority_mode")]
    public InsertionPriorityModeEnum? InsertionPriorityMode { get; set; }
	[InLua("inventory_size")]
    public ItemStackIndex InventorySize { get; set; }
	[InLua("item_filters")]
    public ItemID[]? ItemFilters { get; set; }
	[InLua("item_group_filters")]
    public ItemGroupID[]? ItemGroupFilters { get; set; }
	[InLua("item_subgroup_filters")]
    public ItemSubGroupID[]? ItemSubgroupFilters { get; set; }
	[InLua("stack_size")]
    public double StackSize { get; } = 1;

    
    
    
    

    

    
}
using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("FurnacePrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class FurnacePrototype : CraftingMachinePrototype
{
    [InLua("cant_insert_at_source_message_key")]
    public string? CantInsertAtSourceMessageKey { get; set; }
	[InLua("entity_info_icon_shift")]
    public Vector? EntityInfoIconShift { get; set; }
	[InLua("result_inventory_size")]
    public ItemStackIndex ResultInventorySize { get; set; }
	[InLua("source_inventory_size")]
    public ItemStackIndex SourceInventorySize { get; set; }

    
    
    
    

    

    
}
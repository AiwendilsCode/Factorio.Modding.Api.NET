using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
using Factorio.Modding.Api.Common.Extensions;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("BlueprintBookPrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class BlueprintBookPrototype : ItemWithInventoryPrototype
{
    [InLua("draw_label_for_cursor_render")]
    public bool? DrawLabelForCursorRender { get; set; }
	[InLua("inventory_size")]
    public StringOr<ItemStackIndex> InventorySize {
                get
                {
                    return _inventorySize;
                }
                        
                set
                {
                    if (value is null)
                                    _inventorySize = new StringOr<ItemStackIndex>("dynamic", default);
                                else
                                    _inventorySize = new StringOr<ItemStackIndex>("dynamic", value.Value.GetAs<ItemStackIndex>());
                }
            }
	[InLua("stack_size")]
    public double StackSize { get; } = 1;

    private StringOr<ItemStackIndex> _inventorySize ;
    
    
    

    

    
}
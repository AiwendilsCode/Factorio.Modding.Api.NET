using Factorio.Modding.Api.Attributes;
using System.CodeDom.Compiler;

namespace Factorio.Modding.Api.PrototypeStage.Enums;
                    

[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Builders.CSharpClassBuilder", "unknown")]
public enum EventTypeEnum
{
    [InLua("crafting-of-single-item-ordered")]
    CraftingOfSingleItemOrdered,
	[InLua("crafting-of-multiple-items-ordered")]
    CraftingOfMultipleItemsOrdered,
	[InLua("crafting-finished")]
    CraftingFinished
}
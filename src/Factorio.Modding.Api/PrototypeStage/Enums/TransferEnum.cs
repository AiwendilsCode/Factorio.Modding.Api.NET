using Factorio.Modding.Api.Attributes;
using System.CodeDom.Compiler;

namespace Factorio.Modding.Api.PrototypeStage.Enums;
                    

[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Builders.CSharpClassBuilder", "unknown")]
public enum TransferEnum
{
    [InLua("stack")]
    Stack,
	[InLua("inventory")]
    Inventory,
	[InLua("whole-inventory")]
    WholeInventory
}
using Factorio.Modding.Api.Attributes;
using System.CodeDom.Compiler;

namespace Factorio.Modding.Api.PrototypeStage.Enums;
                    

[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Builders.CSharpClassBuilder", "unknown")]
public enum ActivationTypeEnum
{
    [InLua("shoot")]
    Shoot,
	[InLua("throw")]
    Throw,
	[InLua("consume")]
    Consume,
	[InLua("activate")]
    Activate
}
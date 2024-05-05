using Factorio.Modding.Api.Attributes;
using System.CodeDom.Compiler;

namespace Factorio.Modding.Api.PrototypeStage.Enums;
                    

[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Builders.CSharpClassBuilder", "unknown")]
public enum ApplyTintEnum
{
    [InLua("resource-color")]
    ResourceColor,
	[InLua("input-fluid-base-color")]
    InputFluidBaseColor,
	[InLua("input-fluid-flow-color")]
    InputFluidFlowColor,
	[InLua("status")]
    Status,
	[InLua("none")]
    None
}
using Factorio.Modding.Api.Attributes;
using System.CodeDom.Compiler;

namespace Factorio.Modding.Api.PrototypeStage.Enums;
                    

[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Builders.CSharpClassBuilder", "unknown")]
public enum ProductionTypeEnum
{
    [InLua("None")]
    None,
	[InLua("none")]
    none,
	[InLua("input")]
    Input,
	[InLua("input-output")]
    InputOutput,
	[InLua("output")]
    Output
}
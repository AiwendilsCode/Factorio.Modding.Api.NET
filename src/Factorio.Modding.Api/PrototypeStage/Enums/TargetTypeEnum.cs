using Factorio.Modding.Api.Attributes;
using System.CodeDom.Compiler;

namespace Factorio.Modding.Api.PrototypeStage.Enums;
                    

[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Builders.CSharpClassBuilder", "unknown")]
public enum TargetTypeEnum
{
    [InLua("entity")]
    Entity,
	[InLua("position")]
    Position,
	[InLua("direction")]
    Direction
}
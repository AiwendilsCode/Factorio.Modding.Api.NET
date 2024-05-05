using Factorio.Modding.Api.Attributes;
using System.CodeDom.Compiler;

namespace Factorio.Modding.Api.PrototypeStage.Enums;
                    

[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Builders.CSharpClassBuilder", "unknown")]
public enum AmmoSourceTypeEnum
{
    [InLua("default")]
    Default,
	[InLua("player")]
    Player,
	[InLua("turret")]
    Turret,
	[InLua("vehicle")]
    Vehicle
}
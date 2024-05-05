using Factorio.Modding.Api.Attributes;
using System.CodeDom.Compiler;

namespace Factorio.Modding.Api.PrototypeStage.Enums;
                    

[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Builders.CSharpClassBuilder", "unknown")]
public enum EffectTypeLimitationEnum
{
    [InLua("speed")]
    Speed,
	[InLua("productivity")]
    Productivity,
	[InLua("consumption")]
    Consumption,
	[InLua("pollution")]
    Pollution
}
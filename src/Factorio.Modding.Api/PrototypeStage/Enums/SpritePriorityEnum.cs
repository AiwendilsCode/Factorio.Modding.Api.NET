using Factorio.Modding.Api.Attributes;
using System.CodeDom.Compiler;

namespace Factorio.Modding.Api.PrototypeStage.Enums;
                    

[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Builders.CSharpClassBuilder", "unknown")]
public enum SpritePriorityEnum
{
    [InLua("extra-high-no-scale")]
    ExtraHighNoScale,
	[InLua("extra-high")]
    ExtraHigh,
	[InLua("high")]
    High,
	[InLua("medium")]
    Medium,
	[InLua("low")]
    Low,
	[InLua("very-low")]
    VeryLow,
	[InLua("no-atlas")]
    NoAtlas
}
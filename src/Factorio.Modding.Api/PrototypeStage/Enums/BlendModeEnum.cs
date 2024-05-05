using Factorio.Modding.Api.Attributes;
using System.CodeDom.Compiler;

namespace Factorio.Modding.Api.PrototypeStage.Enums;
                    

[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Builders.CSharpClassBuilder", "unknown")]
public enum BlendModeEnum
{
    [InLua("normal")]
    Normal,
	[InLua("additive")]
    Additive,
	[InLua("additive-soft")]
    AdditiveSoft,
	[InLua("multiplicative")]
    Multiplicative,
	[InLua("multiplicative-with-alpha")]
    MultiplicativeWithAlpha,
	[InLua("overwrite")]
    Overwrite
}
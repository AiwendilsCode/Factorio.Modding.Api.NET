using Factorio.Modding.Api.Attributes;
using System.CodeDom.Compiler;

namespace Factorio.Modding.Api.PrototypeStage.Enums;
                    

[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Builders.CSharpClassBuilder", "unknown")]
public enum SoundTypeEnum
{
    [InLua("game-effect")]
    GameEffect,
	[InLua("gui-effect")]
    GuiEffect,
	[InLua("ambient")]
    Ambient,
	[InLua("environment")]
    Environment,
	[InLua("walking")]
    Walking,
	[InLua("alert")]
    Alert,
	[InLua("wind")]
    Wind
}
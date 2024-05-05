using Factorio.Modding.Api.Attributes;
using System.CodeDom.Compiler;

namespace Factorio.Modding.Api.PrototypeStage.Enums;
                    

[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Builders.CSharpClassBuilder", "unknown")]
public enum PlayerInputMethodFilterEnum
{
    [InLua("all")]
    All,
	[InLua("keyboard_and_mouse")]
    KeyboardAndMouse,
	[InLua("game_controller")]
    GameController
}
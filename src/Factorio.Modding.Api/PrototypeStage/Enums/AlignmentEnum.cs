using Factorio.Modding.Api.Attributes;
using System.CodeDom.Compiler;

namespace Factorio.Modding.Api.PrototypeStage.Enums;
                    

[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Builders.CSharpClassBuilder", "unknown")]
public enum AlignmentEnum
{
    [InLua("center")]
    Center,
	[InLua("left")]
    Left,
	[InLua("right")]
    Right,
	[InLua("top-left")]
    TopLeft,
	[InLua("middle-left")]
    MiddleLeft,
	[InLua("bottom-left")]
    BottomLeft,
	[InLua("top-center")]
    TopCenter,
	[InLua("middle-center")]
    MiddleCenter,
	[InLua("bottom-center")]
    BottomCenter,
	[InLua("top-right")]
    TopRight,
	[InLua("middle-right")]
    MiddleRight,
	[InLua("bottom-right")]
    BottomRight
}
using Factorio.Modding.Api.Attributes;
using System.CodeDom.Compiler;

namespace Factorio.Modding.Api.PrototypeStage.Enums;
                    

[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Builders.CSharpClassBuilder", "unknown")]
public enum RunModeEnum
{
    [InLua("forward")]
    Forward,
	[InLua("backward")]
    Backward,
	[InLua("forward-then-backward")]
    ForwardThenBackward
}
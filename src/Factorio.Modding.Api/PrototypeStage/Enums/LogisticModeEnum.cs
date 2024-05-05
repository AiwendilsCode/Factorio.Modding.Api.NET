using Factorio.Modding.Api.Attributes;
using System.CodeDom.Compiler;

namespace Factorio.Modding.Api.PrototypeStage.Enums;
                    

[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Builders.CSharpClassBuilder", "unknown")]
public enum LogisticModeEnum
{
    [InLua("active-provider")]
    ActiveProvider,
	[InLua("passive-provider")]
    PassiveProvider,
	[InLua("requester")]
    Requester,
	[InLua("storage")]
    Storage,
	[InLua("buffer")]
    Buffer
}
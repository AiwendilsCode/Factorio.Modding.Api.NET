using Factorio.Modding.Api.Attributes;
using System.CodeDom.Compiler;

namespace Factorio.Modding.Api.PrototypeStage.Enums;
                    

[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Builders.CSharpClassBuilder", "unknown")]
public enum ResearchQueueSettingEnum
{
    [InLua("always")]
    Always,
	[InLua("after-victory")]
    AfterVictory,
	[InLua("never")]
    Never
}
using Factorio.Modding.Api.Attributes;
using System.CodeDom.Compiler;

namespace Factorio.Modding.Api.PrototypeStage.Enums;
                    

[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Builders.CSharpClassBuilder", "unknown")]
public enum InsertionPriorityModeEnum
{
    [InLua("default")]
    Default,
	[InLua("never")]
    Never,
	[InLua("always")]
    Always,
	[InLua("when-manually-filtered")]
    WhenManuallyFiltered
}
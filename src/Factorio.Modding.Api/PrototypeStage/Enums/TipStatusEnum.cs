using Factorio.Modding.Api.Attributes;
using System.CodeDom.Compiler;

namespace Factorio.Modding.Api.PrototypeStage.Enums;
                    

[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Builders.CSharpClassBuilder", "unknown")]
public enum TipStatusEnum
{
    [InLua("locked")]
    Locked,
	[InLua("optional")]
    Optional,
	[InLua("dependencies-not-met")]
    DependenciesNotMet,
	[InLua("unlocked")]
    Unlocked,
	[InLua("suggested")]
    Suggested,
	[InLua("not-to-be-suggested")]
    NotToBeSuggested,
	[InLua("completed-without-tutorial")]
    CompletedWithoutTutorial,
	[InLua("completed")]
    Completed
}
using Factorio.Modding.Api.Attributes;
using System.CodeDom.Compiler;

namespace Factorio.Modding.Api.PrototypeStage.Enums;
                    

[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Builders.CSharpClassBuilder", "unknown")]
public enum StretchRuleEnum
{
    [InLua("on")]
    On,
	[InLua("off")]
    Off,
	[InLua("auto")]
    Auto,
	[InLua("stretch_and_expand")]
    StretchAndExpand
}
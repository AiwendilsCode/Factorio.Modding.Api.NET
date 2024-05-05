using Factorio.Modding.Api.Attributes;
using System.CodeDom.Compiler;

namespace Factorio.Modding.Api.PrototypeStage.Enums;
                    

[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Builders.CSharpClassBuilder", "unknown")]
public enum ForceConditionEnum
{
    [InLua("all")]
    All,
	[InLua("enemy")]
    Enemy,
	[InLua("ally")]
    Ally,
	[InLua("friend")]
    Friend,
	[InLua("not-friend")]
    NotFriend,
	[InLua("same")]
    Same,
	[InLua("not-same")]
    NotSame
}
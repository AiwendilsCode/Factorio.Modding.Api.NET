using Factorio.Modding.Api.Attributes;
using System.CodeDom.Compiler;

namespace Factorio.Modding.Api.PrototypeStage.Enums;
                    

[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Builders.CSharpClassBuilder", "unknown")]
public enum TrackTypeEnum
{
    [InLua("menu-track")]
    MenuTrack,
	[InLua("main-track")]
    MainTrack,
	[InLua("early-game")]
    EarlyGame,
	[InLua("late-game")]
    LateGame,
	[InLua("interlude")]
    Interlude
}
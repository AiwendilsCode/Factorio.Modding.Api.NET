using Factorio.Modding.Api.Attributes;
using System.CodeDom.Compiler;

namespace Factorio.Modding.Api.PrototypeStage.Enums;
                    

[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Builders.CSharpClassBuilder", "unknown")]
public enum CollisionMaskEnum
{
    [InLua("not-colliding-with-itself")]
    NotCollidingWithItself,
	[InLua("consider-tile-transitions")]
    ConsiderTileTransitions,
	[InLua("colliding-with-tiles-only")]
    CollidingWithTilesOnly
}
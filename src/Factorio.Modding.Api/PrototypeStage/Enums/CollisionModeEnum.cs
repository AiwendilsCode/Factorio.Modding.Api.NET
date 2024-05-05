using Factorio.Modding.Api.Attributes;
using System.CodeDom.Compiler;

namespace Factorio.Modding.Api.PrototypeStage.Enums;
                    

[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Builders.CSharpClassBuilder", "unknown")]
public enum CollisionModeEnum
{
    [InLua("distance-from-collision-box")]
    DistanceFromCollisionBox,
	[InLua("distance-from-center")]
    DistanceFromCenter
}
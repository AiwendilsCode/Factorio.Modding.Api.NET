using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("EntityGhostPrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class EntityGhostPrototype : EntityPrototype
{
    [InLua("collision_mask")]
    public CollisionMask? CollisionMask { get; set; }
	[InLua("large_build_sound")]
    public Sound? LargeBuildSound { get; set; }
	[InLua("medium_build_sound")]
    public Sound? MediumBuildSound { get; set; }

    
    
    
    

    

    
}
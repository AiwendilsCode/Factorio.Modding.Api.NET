using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("CliffPrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class CliffPrototype : EntityPrototype
{
    [InLua("cliff_explosive")]
    public ItemID? CliffExplosive { get; set; }
	[InLua("cliff_height")]
    public float? CliffHeight { get; set; }
	[InLua("collision_mask")]
    public CollisionMask? CollisionMask { get; set; }
	[InLua("grid_offset")]
    public Vector GridOffset { get; set; }
	[InLua("grid_size")]
    public Vector GridSize { get; set; }
	[InLua("orientations")]
    public OrientedCliffPrototypeSet Orientations { get; set; }

    
    
    
    

    

    
}
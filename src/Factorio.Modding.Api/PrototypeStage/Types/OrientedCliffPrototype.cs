using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("OrientedCliffPrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class OrientedCliffPrototype 
{
    [InLua("collision_bounding_box")]
    public BoundingBox CollisionBoundingBox { get; set; }
	[InLua("fill_volume")]
    public uint FillVolume { get; set; }
	[InLua("pictures")]
    public SpriteVariations Pictures { get; set; }

    
    
    
    

    

    
}
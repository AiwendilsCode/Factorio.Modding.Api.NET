using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("RailPrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class RailPrototype : EntityWithOwnerPrototype
{
    [InLua("build_grid_size")]
    public double? BuildGridSize { get; } = 2;
	[InLua("collision_box")]
    public BoundingBox? CollisionBox { get; set; }
	[InLua("collision_mask")]
    public CollisionMask? CollisionMask { get; set; }
	[InLua("pictures")]
    public RailPictureSet Pictures { get; set; }
	[InLua("selection_box")]
    public BoundingBox? SelectionBox { get; set; }
	[InLua("walking_sound")]
    public Sound? WalkingSound { get; set; }

    
    
    
    

    

    
}
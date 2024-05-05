using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("PipePrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class PipePrototype : EntityWithOwnerPrototype
{
    [InLua("fluid_box")]
    public FluidBox FluidBox { get; set; }
	[InLua("horizontal_window_bounding_box")]
    public BoundingBox HorizontalWindowBoundingBox { get; set; }
	[InLua("pictures")]
    public PipePictures Pictures { get; set; }
	[InLua("vertical_window_bounding_box")]
    public BoundingBox VerticalWindowBoundingBox { get; set; }

    
    
    
    

    

    
}
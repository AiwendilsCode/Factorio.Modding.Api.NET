using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("ArrowPrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class ArrowPrototype : EntityPrototype
{
    [InLua("arrow_picture")]
    public Sprite ArrowPicture { get; set; }
	[InLua("blinking")]
    public bool? Blinking { get; set; }
	[InLua("circle_picture")]
    public Sprite? CirclePicture { get; set; }
	[InLua("collision_mask")]
    public CollisionMask? CollisionMask { get; set; }

    
    
    
    

    

    
}
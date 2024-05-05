using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("WaterReflectionDefinition")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class WaterReflectionDefinition 
{
    [InLua("orientation_to_variation")]
    public bool? OrientationToVariation { get; set; }
	[InLua("pictures")]
    public SpriteVariations? Pictures { get; set; }
	[InLua("rotate")]
    public bool? Rotate { get; set; }

    
    
    
    

    

    
}
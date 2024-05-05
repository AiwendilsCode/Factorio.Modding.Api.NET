using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("ColorFilterData")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class ColorFilterData 
{
    [InLua("localised_name")]
    public LocalisedString LocalisedName { get; set; }
	[InLua("matrix")]
    public float[][] Matrix { get; set; }
	[InLua("name")]
    public string Name { get; set; }

    
    
    
    

    

    
}
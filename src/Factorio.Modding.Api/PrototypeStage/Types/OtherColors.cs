using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("OtherColors")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class OtherColors 
{
    [InLua("bar")]
    public ElementImageSet? Bar { get; set; }
	[InLua("color")]
    public Color? Color { get; set; }
	[InLua("less_than")]
    public double LessThan { get; set; }

    
    
    
    

    

    
}
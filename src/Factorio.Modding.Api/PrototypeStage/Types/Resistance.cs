using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("Resistance")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class Resistance 
{
    [InLua("decrease")]
    public float? Decrease { get; set; }
	[InLua("percent")]
    public float? Percent { get; set; }
	[InLua("type")]
    public DamageTypeID Type { get; set; }

    
    
    
    

    

    
}
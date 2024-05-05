using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("AmmoCategoryID")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class AmmoCategoryID 
{
    
    public string Value { get; set; }

    
    
    
    private AmmoCategoryID(string value)
    {
        Value = value;
    }

    public static implicit operator AmmoCategoryID(string value) => new(value);

    
}
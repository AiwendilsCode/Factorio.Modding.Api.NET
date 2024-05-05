using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("RecipeCategoryID")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class RecipeCategoryID 
{
    
    public string Value { get; set; }

    
    
    
    private RecipeCategoryID(string value)
    {
        Value = value;
    }

    public static implicit operator RecipeCategoryID(string value) => new(value);

    
}
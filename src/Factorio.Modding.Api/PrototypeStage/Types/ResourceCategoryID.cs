using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("ResourceCategoryID")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class ResourceCategoryID 
{
    
    public string Value { get; set; }

    
    
    
    private ResourceCategoryID(string value)
    {
        Value = value;
    }

    public static implicit operator ResourceCategoryID(string value) => new(value);

    
}
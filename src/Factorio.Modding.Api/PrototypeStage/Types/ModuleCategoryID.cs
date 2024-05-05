using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("ModuleCategoryID")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class ModuleCategoryID 
{
    
    public string Value { get; set; }

    
    
    
    private ModuleCategoryID(string value)
    {
        Value = value;
    }

    public static implicit operator ModuleCategoryID(string value) => new(value);

    
}
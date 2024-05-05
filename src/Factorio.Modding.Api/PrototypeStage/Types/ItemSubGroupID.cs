using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("ItemSubGroupID")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class ItemSubGroupID 
{
    
    public string Value { get; set; }

    
    
    
    private ItemSubGroupID(string value)
    {
        Value = value;
    }

    public static implicit operator ItemSubGroupID(string value) => new(value);

    
}
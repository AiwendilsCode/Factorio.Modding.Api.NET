using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("ItemPrototypeFlags")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class ItemPrototypeFlags 
{
    
    public ItemPrototypeFlagsEnum[] Value { get; set; }

    
    
    
    private ItemPrototypeFlags(ItemPrototypeFlagsEnum[] value)
    {
        Value = value;
    }

    public static implicit operator ItemPrototypeFlags(ItemPrototypeFlagsEnum[] value) => new(value);

    
}
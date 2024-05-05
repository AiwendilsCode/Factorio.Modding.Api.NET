using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("TipStatus")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class TipStatus 
{
    
    public TipStatusEnum Value { get; set; }

    
    
    
    private TipStatus(TipStatusEnum value)
    {
        Value = value;
    }

    public static implicit operator TipStatus(TipStatusEnum value) => new(value);

    
}
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("MaterialAmountType")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class MaterialAmountType 
{
    
    public double Value { get; set; }

    
    
    
    private MaterialAmountType(double value)
    {
        Value = value;
    }

    public static implicit operator MaterialAmountType(double value) => new(value);

    
}
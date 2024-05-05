using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("LinkedGameControl")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class LinkedGameControl 
{
    
    public LinkedGameControlEnum Value { get; set; }

    
    
    
    private LinkedGameControl(LinkedGameControlEnum value)
    {
        Value = value;
    }

    public static implicit operator LinkedGameControl(LinkedGameControlEnum value) => new(value);

    
}
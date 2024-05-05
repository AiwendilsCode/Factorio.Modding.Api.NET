using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("ElectricUsagePriority")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class ElectricUsagePriority 
{
    
    public ElectricUsagePriorityEnum Value { get; set; }

    
    
    
    private ElectricUsagePriority(ElectricUsagePriorityEnum value)
    {
        Value = value;
    }

    public static implicit operator ElectricUsagePriority(ElectricUsagePriorityEnum value) => new(value);

    
}
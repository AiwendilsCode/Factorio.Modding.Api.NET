using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("AmmoSourceType")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class AmmoSourceType 
{
    
    public AmmoSourceTypeEnum Value { get; set; }

    
    
    
    private AmmoSourceType(AmmoSourceTypeEnum value)
    {
        Value = value;
    }

    public static implicit operator AmmoSourceType(AmmoSourceTypeEnum value) => new(value);

    
}
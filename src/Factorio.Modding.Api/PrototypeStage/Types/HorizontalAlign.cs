using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("HorizontalAlign")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class HorizontalAlign 
{
    
    public HorizontalAlignEnum Value { get; set; }

    
    
    
    private HorizontalAlign(HorizontalAlignEnum value)
    {
        Value = value;
    }

    public static implicit operator HorizontalAlign(HorizontalAlignEnum value) => new(value);

    
}
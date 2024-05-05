using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("RenderLayer")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class RenderLayer 
{
    
    public RenderLayerEnum Value { get; set; }

    
    
    
    private RenderLayer(RenderLayerEnum value)
    {
        Value = value;
    }

    public static implicit operator RenderLayer(RenderLayerEnum value) => new(value);

    
}
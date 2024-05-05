using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("TileRenderLayer")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class TileRenderLayer 
{
    
    public TileRenderLayerEnum Value { get; set; }

    
    
    
    private TileRenderLayer(TileRenderLayerEnum value)
    {
        Value = value;
    }

    public static implicit operator TileRenderLayer(TileRenderLayerEnum value) => new(value);

    
}
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("CollisionMaskLayer")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class CollisionMaskLayer 
{
    
    public CollisionMaskLayerEnum Value { get; set; }

    
    
    
    private CollisionMaskLayer(CollisionMaskLayerEnum value)
    {
        Value = value;
    }

    public static implicit operator CollisionMaskLayer(CollisionMaskLayerEnum value) => new(value);

    
}
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("CollisionMask")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class CollisionMask 
{
    
    public OneOf<CollisionMaskLayer, CollisionMaskEnum>[] Value { get; set; }

    
    
    
    private CollisionMask(OneOf<CollisionMaskLayer, CollisionMaskEnum>[] value)
    {
        Value = value;
    }

    public static implicit operator CollisionMask(OneOf<CollisionMaskLayer, CollisionMaskEnum>[] value) => new(value);

    
}
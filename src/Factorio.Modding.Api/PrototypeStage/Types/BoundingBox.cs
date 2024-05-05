using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("BoundingBox")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class BoundingBox 
{
    
    public (MapPosition, MapPosition) Value { get; set; }

    
    
    
    private BoundingBox((MapPosition, MapPosition) value)
    {
        Value = value;

    }

    public static implicit operator BoundingBox((MapPosition, MapPosition) value) => new(value);

    
}
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("MapGenSize")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class MapGenSize 
{
    
    public OneOf<float, MapGenSizeEnum> Value { get; set; }

    
    
    
    private MapGenSize(float value)
    {
        Value = value;
    }

	private MapGenSize(MapGenSizeEnum value)
    {
        Value = value;
    }

    public static implicit operator MapGenSize(float value) => new(value);

	public static implicit operator MapGenSize(MapGenSizeEnum value) => new(value);

    
}
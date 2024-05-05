using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("ConstantNoiseBoolean")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class ConstantNoiseBoolean 
{
    
    public OneOf<NoiseLiteralBoolean, ConstantNoiseNumber> Value { get; set; }

    
    
    
    private ConstantNoiseBoolean(NoiseLiteralBoolean value)
    {
        Value = value;
    }

	private ConstantNoiseBoolean(ConstantNoiseNumber value)
    {
        Value = value;
    }

    public static implicit operator ConstantNoiseBoolean(NoiseLiteralBoolean value) => new(value);

	public static implicit operator ConstantNoiseBoolean(ConstantNoiseNumber value) => new(value);

    
}
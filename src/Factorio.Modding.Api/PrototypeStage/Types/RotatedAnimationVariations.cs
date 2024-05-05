using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("RotatedAnimationVariations")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class RotatedAnimationVariations 
{
    
    public OneOf<RotatedAnimation, RotatedAnimation[]> Value { get; set; }

    
    
    
    private RotatedAnimationVariations(RotatedAnimation value)
    {
        Value = value;
    }

	private RotatedAnimationVariations(RotatedAnimation[] value)
    {
        Value = value;
    }

    public static implicit operator RotatedAnimationVariations(RotatedAnimation value) => new(value);

	public static implicit operator RotatedAnimationVariations(RotatedAnimation[] value) => new(value);

    
}
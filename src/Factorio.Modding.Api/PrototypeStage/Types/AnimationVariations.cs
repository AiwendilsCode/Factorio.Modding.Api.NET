using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("AnimationVariations")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class AnimationVariations 
{
    [InLua("sheet")]
    public AnimationSheet? Sheet { get; set; }
	[InLua("sheets")]
    public AnimationSheet[]? Sheets { get; set; }
	
    public Animation? Animation { get; set; }
	
    public Animation[]? AnimationArray { get; set; }

    
    
    public AnimationVariations() {}
    private AnimationVariations(Animation value)
    {
        Animation = value;
    }

	private AnimationVariations(Animation[] value)
    {
        AnimationArray = value;
    }

    public static implicit operator AnimationVariations(Animation value) => new(value);

	public static implicit operator AnimationVariations(Animation[] value) => new(value);

    
}
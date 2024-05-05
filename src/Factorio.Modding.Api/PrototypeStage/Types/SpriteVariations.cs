using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("SpriteVariations")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class SpriteVariations 
{
    [InLua("sheet")]
    public SpriteSheet Sheet { get; set; }
	
    public Sprite[]? SpriteArray { get; set; }

    
    
    public SpriteVariations() {}
    private SpriteVariations(SpriteSheet value)
    {
        Sheet = value;
    }

	private SpriteVariations(Sprite[] value)
    {
        SpriteArray = value;
    }

    public static implicit operator SpriteVariations(SpriteSheet value) => new(value);

	public static implicit operator SpriteVariations(Sprite[] value) => new(value);

    
}
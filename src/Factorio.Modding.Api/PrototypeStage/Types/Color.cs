using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("Color")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class Color 
{
    [InLua("a")]
    public float? A { get; set; }
	[InLua("b")]
    public float? B { get; set; }
	[InLua("g")]
    public float? G { get; set; }
	[InLua("r")]
    public float? R { get; set; }

    
    
    public Color() {}
    private Color((float, float, float) value)
    {
        R = value.Item1;
G = value.Item2;
B = value.Item3;
    }

	private Color((float, float, float, float) value)
    {
        R = value.Item1;
G = value.Item2;
B = value.Item3;
A = value.Item4;
    }

    public static implicit operator Color((float, float, float) value) => new(value);

	public static implicit operator Color((float, float, float, float) value) => new(value);

    
}
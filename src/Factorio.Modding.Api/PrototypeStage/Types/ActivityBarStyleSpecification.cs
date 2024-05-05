using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("ActivityBarStyleSpecification")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class ActivityBarStyleSpecification : BaseStyleSpecification
{
    [InLua("bar")]
    public Sprite? Bar { get; set; }
	[InLua("bar_background")]
    public Sprite? BarBackground { get; set; }
	[InLua("bar_size_ratio")]
    public float? BarSizeRatio { get; set; }
	[InLua("bar_width")]
    public uint? BarWidth { get; set; }
	[InLua("color")]
    public Color? Color { get; set; }
	[InLua("speed")]
    public float? Speed { get; set; }
	[InLua("type")]
    public string Type { get; } = "activity_bar_style";

    
    
    
    

    

    
}
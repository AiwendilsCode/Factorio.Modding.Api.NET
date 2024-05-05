using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("SliderStyleSpecification")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class SliderStyleSpecification : BaseStyleSpecification
{
    [InLua("button")]
    public ButtonStyleSpecification? Button { get; set; }
	[InLua("draw_notches")]
    public bool? DrawNotches { get; set; }
	[InLua("empty_bar")]
    public ElementImageSet? EmptyBar { get; set; }
	[InLua("empty_bar_disabled")]
    public ElementImageSet? EmptyBarDisabled { get; set; }
	[InLua("full_bar")]
    public ElementImageSet? FullBar { get; set; }
	[InLua("full_bar_disabled")]
    public ElementImageSet? FullBarDisabled { get; set; }
	[InLua("high_button")]
    public ButtonStyleSpecification? HighButton { get; set; }
	[InLua("notch")]
    public ElementImageSet? Notch { get; set; }
	[InLua("type")]
    public string Type { get; } = "slider_style";

    
    
    
    

    

    
}
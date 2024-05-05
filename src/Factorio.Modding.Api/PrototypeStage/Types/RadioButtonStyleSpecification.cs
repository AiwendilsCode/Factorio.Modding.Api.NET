using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("RadioButtonStyleSpecification")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class RadioButtonStyleSpecification : StyleWithClickableGraphicalSetSpecification
{
    [InLua("disabled_font_color")]
    public Color? DisabledFontColor { get; set; }
	[InLua("font")]
    public string? Font { get; set; }
	[InLua("font_color")]
    public Color? FontColor { get; set; }
	[InLua("text_padding")]
    public uint? TextPadding { get; set; }
	[InLua("type")]
    public string Type { get; } = "radiobutton_style";

    
    
    
    

    

    
}
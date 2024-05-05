using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("LabelStyleSpecification")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class LabelStyleSpecification : BaseStyleSpecification
{
    [InLua("clicked_font_color")]
    public Color? ClickedFontColor { get; set; }
	[InLua("disabled_font_color")]
    public Color? DisabledFontColor { get; set; }
	[InLua("font")]
    public string? Font { get; set; }
	[InLua("font_color")]
    public Color? FontColor { get; set; }
	[InLua("game_controller_hovered_font_color")]
    public Color? GameControllerHoveredFontColor { get; set; }
	[InLua("hovered_font_color")]
    public Color? HoveredFontColor { get; set; }
	[InLua("rich_text_highlight_error_color")]
    public Color? RichTextHighlightErrorColor { get; set; }
	[InLua("rich_text_highlight_ok_color")]
    public Color? RichTextHighlightOkColor { get; set; }
	[InLua("rich_text_highlight_warning_color")]
    public Color? RichTextHighlightWarningColor { get; set; }
	[InLua("rich_text_setting")]
    public RichTextSetting? RichTextSetting { get; set; }
	[InLua("single_line")]
    public bool? SingleLine { get; set; }
	[InLua("type")]
    public string Type { get; } = "label_style";
	[InLua("underlined")]
    public bool? Underlined { get; set; }

    
    
    
    

    

    
}
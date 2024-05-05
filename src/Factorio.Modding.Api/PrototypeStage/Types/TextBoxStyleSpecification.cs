using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("TextBoxStyleSpecification")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class TextBoxStyleSpecification : BaseStyleSpecification
{
    [InLua("active_background")]
    public ElementImageSet? ActiveBackground { get; set; }
	[InLua("default_background")]
    public ElementImageSet? DefaultBackground { get; set; }
	[InLua("disabled_background")]
    public ElementImageSet? DisabledBackground { get; set; }
	[InLua("disabled_font_color")]
    public Color? DisabledFontColor { get; set; }
	[InLua("font")]
    public string? Font { get; set; }
	[InLua("font_color")]
    public Color? FontColor { get; set; }
	[InLua("game_controller_hovered_background")]
    public ElementImageSet? GameControllerHoveredBackground { get; set; }
	[InLua("rich_text_highlight_error_color")]
    public Color? RichTextHighlightErrorColor { get; set; }
	[InLua("rich_text_highlight_ok_color")]
    public Color? RichTextHighlightOkColor { get; set; }
	[InLua("rich_text_highlight_warning_color")]
    public Color? RichTextHighlightWarningColor { get; set; }
	[InLua("rich_text_setting")]
    public RichTextSetting? RichTextSetting { get; set; }
	[InLua("selected_rich_text_highlight_error_color")]
    public Color? SelectedRichTextHighlightErrorColor { get; set; }
	[InLua("selected_rich_text_highlight_ok_color")]
    public Color? SelectedRichTextHighlightOkColor { get; set; }
	[InLua("selected_rich_text_highlight_warning_color")]
    public Color? SelectedRichTextHighlightWarningColor { get; set; }
	[InLua("selection_background_color")]
    public Color? SelectionBackgroundColor { get; set; }
	[InLua("type")]
    public string Type { get; } = "textbox_style";

    
    
    
    

    

    
}
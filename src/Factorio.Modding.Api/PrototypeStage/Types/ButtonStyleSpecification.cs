using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("ButtonStyleSpecification")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class ButtonStyleSpecification : StyleWithClickableGraphicalSetSpecification
{
    [InLua("clicked_font_color")]
    public Color? ClickedFontColor { get; set; }
	[InLua("clicked_vertical_offset")]
    public uint? ClickedVerticalOffset { get; set; }
	[InLua("default_font_color")]
    public Color? DefaultFontColor { get; set; }
	[InLua("disabled_font_color")]
    public Color? DisabledFontColor { get; set; }
	[InLua("draw_grayscale_picture")]
    public bool? DrawGrayscalePicture { get; set; }
	[InLua("draw_shadow_under_picture")]
    public bool? DrawShadowUnderPicture { get; set; }
	[InLua("font")]
    public string? Font { get; set; }
	[InLua("hovered_font_color")]
    public Color? HoveredFontColor { get; set; }
	[InLua("icon_horizontal_align")]
    public HorizontalAlign? IconHorizontalAlign { get; set; }
	[InLua("pie_progress_color")]
    public Color? PieProgressColor { get; set; }
	[InLua("selected_clicked_font_color")]
    public Color? SelectedClickedFontColor { get; set; }
	[InLua("selected_font_color")]
    public Color? SelectedFontColor { get; set; }
	[InLua("selected_hovered_font_color")]
    public Color? SelectedHoveredFontColor { get; set; }
	[InLua("strikethrough_color")]
    public Color? StrikethroughColor { get; set; }
	[InLua("type")]
    public string Type { get; } = "button_style";

    
    
    
    

    

    
}
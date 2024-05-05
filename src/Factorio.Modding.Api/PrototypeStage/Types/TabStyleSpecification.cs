using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("TabStyleSpecification")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class TabStyleSpecification : BaseStyleSpecification
{
    [InLua("badge_font")]
    public string? BadgeFont { get; set; }
	[InLua("badge_horizontal_spacing")]
    public short? BadgeHorizontalSpacing { get; set; }
	[InLua("default_badge_font_color")]
    public Color? DefaultBadgeFontColor { get; set; }
	[InLua("default_badge_graphical_set")]
    public ElementImageSet? DefaultBadgeGraphicalSet { get; set; }
	[InLua("default_font_color")]
    public Color? DefaultFontColor { get; set; }
	[InLua("default_graphical_set")]
    public ElementImageSet? DefaultGraphicalSet { get; set; }
	[InLua("disabled_badge_font_color")]
    public Color? DisabledBadgeFontColor { get; set; }
	[InLua("disabled_badge_graphical_set")]
    public ElementImageSet? DisabledBadgeGraphicalSet { get; set; }
	[InLua("disabled_font_color")]
    public Color? DisabledFontColor { get; set; }
	[InLua("disabled_graphical_set")]
    public ElementImageSet? DisabledGraphicalSet { get; set; }
	[InLua("draw_grayscale_picture")]
    public bool? DrawGrayscalePicture { get; set; }
	[InLua("font")]
    public string? Font { get; set; }
	[InLua("game_controller_selected_hover_graphical_set")]
    public ElementImageSet? GameControllerSelectedHoverGraphicalSet { get; set; }
	[InLua("hover_badge_graphical_set")]
    public ElementImageSet? HoverBadgeGraphicalSet { get; set; }
	[InLua("hover_graphical_set")]
    public ElementImageSet? HoverGraphicalSet { get; set; }
	[InLua("left_click_sound")]
    public Sound? LeftClickSound { get; set; }
	[InLua("left_edge_selected_graphical_set")]
    public ElementImageSet? LeftEdgeSelectedGraphicalSet { get; set; }
	[InLua("override_graphics_on_edges")]
    public bool? OverrideGraphicsOnEdges { get; set; }
	[InLua("press_badge_graphical_set")]
    public ElementImageSet? PressBadgeGraphicalSet { get; set; }
	[InLua("press_graphical_set")]
    public ElementImageSet? PressGraphicalSet { get; set; }
	[InLua("right_edge_selected_graphical_set")]
    public ElementImageSet? RightEdgeSelectedGraphicalSet { get; set; }
	[InLua("selected_badge_font_color")]
    public Color? SelectedBadgeFontColor { get; set; }
	[InLua("selected_badge_graphical_set")]
    public ElementImageSet? SelectedBadgeGraphicalSet { get; set; }
	[InLua("selected_font_color")]
    public Color? SelectedFontColor { get; set; }
	[InLua("selected_graphical_set")]
    public ElementImageSet? SelectedGraphicalSet { get; set; }
	[InLua("type")]
    public string Type { get; } = "tab_style";

    
    
    
    

    

    
}
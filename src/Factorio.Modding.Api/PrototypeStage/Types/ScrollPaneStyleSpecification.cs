using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("ScrollPaneStyleSpecification")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class ScrollPaneStyleSpecification : BaseStyleSpecification
{
    [InLua("background_graphical_set")]
    public ElementImageSet? BackgroundGraphicalSet { get; set; }
	[InLua("dont_force_clipping_rect_for_contents")]
    public bool? DontForceClippingRectForContents { get; set; }
	[InLua("extra_bottom_margin_when_activated")]
    public int? ExtraBottomMarginWhenActivated { get; set; }
	[InLua("extra_bottom_padding_when_activated")]
    public int? ExtraBottomPaddingWhenActivated { get; set; }
	[InLua("extra_left_margin_when_activated")]
    public int? ExtraLeftMarginWhenActivated { get; set; }
	[InLua("extra_left_padding_when_activated")]
    public int? ExtraLeftPaddingWhenActivated { get; set; }
	[InLua("extra_margin_when_activated")]
    public int? ExtraMarginWhenActivated { get; set; }
	[InLua("extra_padding_when_activated")]
    public int? ExtraPaddingWhenActivated { get; set; }
	[InLua("extra_right_margin_when_activated")]
    public int? ExtraRightMarginWhenActivated { get; set; }
	[InLua("extra_right_padding_when_activated")]
    public int? ExtraRightPaddingWhenActivated { get; set; }
	[InLua("extra_top_margin_when_activated")]
    public int? ExtraTopMarginWhenActivated { get; set; }
	[InLua("extra_top_padding_when_activated")]
    public int? ExtraTopPaddingWhenActivated { get; set; }
	[InLua("graphical_set")]
    public ElementImageSet? GraphicalSet { get; set; }
	[InLua("horizontal_scrollbar_style")]
    public HorizontalScrollBarStyleSpecification? HorizontalScrollbarStyle { get; set; }
	[InLua("type")]
    public string Type { get; } = "scroll_pane_style";
	[InLua("vertical_flow_style")]
    public VerticalFlowStyleSpecification? VerticalFlowStyle { get; set; }
	[InLua("vertical_scrollbar_style")]
    public VerticalScrollBarStyleSpecification? VerticalScrollbarStyle { get; set; }

    
    
    
    

    

    
}
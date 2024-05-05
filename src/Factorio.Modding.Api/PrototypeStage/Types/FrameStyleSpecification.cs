using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("FrameStyleSpecification")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class FrameStyleSpecification : BaseStyleSpecification
{
    [InLua("background_graphical_set")]
    public ElementImageSet? BackgroundGraphicalSet { get; set; }
	[InLua("border")]
    public BorderImageSet? Border { get; set; }
	[InLua("drag_by_title")]
    public bool? DragByTitle { get; set; }
	[InLua("graphical_set")]
    public ElementImageSet? GraphicalSet { get; set; }
	[InLua("header_background")]
    public ElementImageSet? HeaderBackground { get; set; }
	[InLua("header_filler_style")]
    public EmptyWidgetStyleSpecification? HeaderFillerStyle { get; set; }
	[InLua("header_flow_style")]
    public HorizontalFlowStyleSpecification? HeaderFlowStyle { get; set; }
	[InLua("horizontal_flow_style")]
    public HorizontalFlowStyleSpecification? HorizontalFlowStyle { get; set; }
	[InLua("title_style")]
    public LabelStyleSpecification? TitleStyle { get; set; }
	[InLua("type")]
    public string Type { get; } = "frame_style";
	[InLua("use_header_filler")]
    public bool? UseHeaderFiller { get; set; }
	[InLua("vertical_flow_style")]
    public VerticalFlowStyleSpecification? VerticalFlowStyle { get; set; }

    
    
    
    

    

    
}
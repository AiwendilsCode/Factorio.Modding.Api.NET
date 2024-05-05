using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("GraphStyleSpecification")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class GraphStyleSpecification : BaseStyleSpecification
{
    [InLua("background_color")]
    public Color? BackgroundColor { get; set; }
	[InLua("data_line_highlight_distance")]
    public uint? DataLineHighlightDistance { get; set; }
	[InLua("graph_right_margin")]
    public uint? GraphRightMargin { get; set; }
	[InLua("graph_top_margin")]
    public uint? GraphTopMargin { get; set; }
	[InLua("grid_lines_color")]
    public Color? GridLinesColor { get; set; }
	[InLua("guide_lines_color")]
    public Color? GuideLinesColor { get; set; }
	[InLua("horizontal_label_style")]
    public LabelStyleSpecification? HorizontalLabelStyle { get; set; }
	[InLua("horizontal_labels_margin")]
    public uint? HorizontalLabelsMargin { get; set; }
	[InLua("line_colors")]
    public Color[]? LineColors { get; set; }
	[InLua("minimal_horizontal_label_spacing")]
    public uint? MinimalHorizontalLabelSpacing { get; set; }
	[InLua("minimal_vertical_label_spacing")]
    public uint? MinimalVerticalLabelSpacing { get; set; }
	[InLua("selection_dot_radius")]
    public uint? SelectionDotRadius { get; set; }
	[InLua("type")]
    public string Type { get; } = "graph_style";
	[InLua("vertical_label_style")]
    public LabelStyleSpecification? VerticalLabelStyle { get; set; }
	[InLua("vertical_labels_margin")]
    public uint? VerticalLabelsMargin { get; set; }

    
    
    
    

    

    
}
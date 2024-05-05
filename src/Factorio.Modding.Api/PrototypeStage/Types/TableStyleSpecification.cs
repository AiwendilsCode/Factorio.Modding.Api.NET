using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("TableStyleSpecification")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class TableStyleSpecification : BaseStyleSpecification
{
    [InLua("apply_row_graphical_set_per_column")]
    public bool? ApplyRowGraphicalSetPerColumn { get; set; }
	[InLua("background_graphical_set")]
    public ElementImageSet? BackgroundGraphicalSet { get; set; }
	[InLua("border")]
    public BorderImageSet? Border { get; set; }
	[InLua("bottom_cell_padding")]
    public short? BottomCellPadding { get; set; }
	[InLua("cell_padding")]
    public short? CellPadding { get; set; }
	[InLua("clicked_graphical_set")]
    public ElementImageSet? ClickedGraphicalSet { get; set; }
	[InLua("column_alignments")]
    public ColumnAlignment[]? ColumnAlignments { get; set; }
	[InLua("column_graphical_set")]
    public ElementImageSet? ColumnGraphicalSet { get; set; }
	[InLua("column_ordering_ascending_button_style")]
    public ButtonStyleSpecification? ColumnOrderingAscendingButtonStyle { get; set; }
	[InLua("column_ordering_descending_button_style")]
    public ButtonStyleSpecification? ColumnOrderingDescendingButtonStyle { get; set; }
	[InLua("column_widths")]
    public ColumnWidth[]? ColumnWidths { get; set; }
	[InLua("default_row_graphical_set")]
    public ElementImageSet? DefaultRowGraphicalSet { get; set; }
	[InLua("even_row_graphical_set")]
    public ElementImageSet? EvenRowGraphicalSet { get; set; }
	[InLua("horizontal_line_color")]
    public Color? HorizontalLineColor { get; set; }
	[InLua("horizontal_spacing")]
    public int? HorizontalSpacing { get; set; }
	[InLua("hovered_graphical_set")]
    public ElementImageSet? HoveredGraphicalSet { get; set; }
	[InLua("hovered_row_color")]
    public Color? HoveredRowColor { get; set; }
	[InLua("inactive_column_ordering_ascending_button_style")]
    public ButtonStyleSpecification? InactiveColumnOrderingAscendingButtonStyle { get; set; }
	[InLua("inactive_column_ordering_descending_button_style")]
    public ButtonStyleSpecification? InactiveColumnOrderingDescendingButtonStyle { get; set; }
	[InLua("left_cell_padding")]
    public short? LeftCellPadding { get; set; }
	[InLua("odd_row_graphical_set")]
    public ElementImageSet? OddRowGraphicalSet { get; set; }
	[InLua("right_cell_padding")]
    public short? RightCellPadding { get; set; }
	[InLua("selected_clicked_graphical_set")]
    public ElementImageSet? SelectedClickedGraphicalSet { get; set; }
	[InLua("selected_graphical_set")]
    public ElementImageSet? SelectedGraphicalSet { get; set; }
	[InLua("selected_hovered_graphical_set")]
    public ElementImageSet? SelectedHoveredGraphicalSet { get; set; }
	[InLua("selected_row_color")]
    public Color? SelectedRowColor { get; set; }
	[InLua("top_cell_padding")]
    public short? TopCellPadding { get; set; }
	[InLua("type")]
    public string Type { get; } = "table_style";
	[InLua("vertical_line_color")]
    public Color? VerticalLineColor { get; set; }
	[InLua("vertical_spacing")]
    public int? VerticalSpacing { get; set; }

    
    
    
    

    

    
}
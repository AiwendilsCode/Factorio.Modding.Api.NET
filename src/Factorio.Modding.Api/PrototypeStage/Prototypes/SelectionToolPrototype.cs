using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("SelectionToolPrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class SelectionToolPrototype : ItemWithLabelPrototype
{
    [InLua("alt_entity_filter_mode")]
    public AltEntityFilterModeEnum? AltEntityFilterMode { get; set; }
	[InLua("alt_entity_filters")]
    public EntityID[]? AltEntityFilters { get; set; }
	[InLua("alt_entity_type_filters")]
    public string[]? AltEntityTypeFilters { get; set; }
	[InLua("alt_reverse_entity_filter_mode")]
    public AltReverseEntityFilterModeEnum? AltReverseEntityFilterMode { get; set; }
	[InLua("alt_reverse_entity_filters")]
    public EntityID[]? AltReverseEntityFilters { get; set; }
	[InLua("alt_reverse_entity_type_filters")]
    public string[]? AltReverseEntityTypeFilters { get; set; }
	[InLua("alt_reverse_selection_color")]
    public Color? AltReverseSelectionColor { get; set; }
	[InLua("alt_reverse_selection_count_button_color")]
    public Color? AltReverseSelectionCountButtonColor { get; set; }
	[InLua("alt_reverse_selection_cursor_box_type")]
    public CursorBoxType? AltReverseSelectionCursorBoxType { get; set; }
	[InLua("alt_reverse_selection_mode")]
    public SelectionModeFlags? AltReverseSelectionMode { get; set; }
	[InLua("alt_reverse_tile_filter_mode")]
    public AltReverseTileFilterModeEnum? AltReverseTileFilterMode { get; set; }
	[InLua("alt_reverse_tile_filters")]
    public TileID[]? AltReverseTileFilters { get; set; }
	[InLua("alt_selection_color")]
    public Color AltSelectionColor { get; set; }
	[InLua("alt_selection_count_button_color")]
    public Color? AltSelectionCountButtonColor { get; set; }
	[InLua("alt_selection_cursor_box_type")]
    public CursorBoxType AltSelectionCursorBoxType { get; set; }
	[InLua("alt_selection_mode")]
    public SelectionModeFlags AltSelectionMode { get; set; }
	[InLua("alt_tile_filter_mode")]
    public AltTileFilterModeEnum? AltTileFilterMode { get; set; }
	[InLua("alt_tile_filters")]
    public TileID[]? AltTileFilters { get; set; }
	[InLua("always_include_tiles")]
    public bool? AlwaysIncludeTiles { get; set; }
	[InLua("chart_alt_reverse_selection_color")]
    public Color? ChartAltReverseSelectionColor { get; set; }
	[InLua("chart_alt_selection_color")]
    public Color? ChartAltSelectionColor { get; set; }
	[InLua("chart_reverse_selection_color")]
    public Color? ChartReverseSelectionColor { get; set; }
	[InLua("chart_selection_color")]
    public Color? ChartSelectionColor { get; set; }
	[InLua("entity_filter_mode")]
    public EntityFilterModeEnum? EntityFilterMode { get; set; }
	[InLua("entity_filters")]
    public EntityID[]? EntityFilters { get; set; }
	[InLua("entity_type_filters")]
    public string[]? EntityTypeFilters { get; set; }
	[InLua("mouse_cursor")]
    public MouseCursorID? MouseCursor { get; set; }
	[InLua("reverse_entity_filter_mode")]
    public ReverseEntityFilterModeEnum? ReverseEntityFilterMode { get; set; }
	[InLua("reverse_entity_filters")]
    public EntityID[]? ReverseEntityFilters { get; set; }
	[InLua("reverse_entity_type_filters")]
    public string[]? ReverseEntityTypeFilters { get; set; }
	[InLua("reverse_selection_color")]
    public Color? ReverseSelectionColor { get; set; }
	[InLua("reverse_selection_count_button_color")]
    public Color? ReverseSelectionCountButtonColor { get; set; }
	[InLua("reverse_selection_cursor_box_type")]
    public CursorBoxType? ReverseSelectionCursorBoxType { get; set; }
	[InLua("reverse_selection_mode")]
    public SelectionModeFlags? ReverseSelectionMode { get; set; }
	[InLua("reverse_tile_filter_mode")]
    public ReverseTileFilterModeEnum? ReverseTileFilterMode { get; set; }
	[InLua("reverse_tile_filters")]
    public TileID[]? ReverseTileFilters { get; set; }
	[InLua("selection_color")]
    public Color SelectionColor { get; set; }
	[InLua("selection_count_button_color")]
    public Color? SelectionCountButtonColor { get; set; }
	[InLua("selection_cursor_box_type")]
    public CursorBoxType SelectionCursorBoxType { get; set; }
	[InLua("selection_mode")]
    public SelectionModeFlags SelectionMode { get; set; }
	[InLua("tile_filter_mode")]
    public TileFilterModeEnum? TileFilterMode { get; set; }
	[InLua("tile_filters")]
    public TileID[]? TileFilters { get; set; }

    
    
    
    

    

    
}
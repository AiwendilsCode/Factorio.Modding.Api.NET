using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("MapEditorConstants")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class MapEditorConstants 
{
    [InLua("cliff_editor_remove_cliffs_color")]
    public Color CliffEditorRemoveCliffsColor { get; set; }
	[InLua("clone_editor_brush_cursor_preview_tint")]
    public Color CloneEditorBrushCursorPreviewTint { get; set; }
	[InLua("clone_editor_brush_destination_color")]
    public Color CloneEditorBrushDestinationColor { get; set; }
	[InLua("clone_editor_brush_source_color")]
    public Color CloneEditorBrushSourceColor { get; set; }
	[InLua("clone_editor_brush_world_preview_tint")]
    public Color CloneEditorBrushWorldPreviewTint { get; set; }
	[InLua("clone_editor_copy_destination_allowed_color")]
    public Color CloneEditorCopyDestinationAllowedColor { get; set; }
	[InLua("clone_editor_copy_destination_not_allowed_color")]
    public Color CloneEditorCopyDestinationNotAllowedColor { get; set; }
	[InLua("clone_editor_copy_source_color")]
    public Color CloneEditorCopySourceColor { get; set; }
	[InLua("decorative_editor_selection_preview_radius")]
    public byte DecorativeEditorSelectionPreviewRadius { get; set; }
	[InLua("decorative_editor_selection_preview_tint")]
    public Color DecorativeEditorSelectionPreviewTint { get; set; }
	[InLua("force_editor_select_area_color")]
    public Color ForceEditorSelectAreaColor { get; set; }
	[InLua("script_editor_drag_area_color")]
    public Color ScriptEditorDragAreaColor { get; set; }
	[InLua("script_editor_select_area_color")]
    public Color ScriptEditorSelectAreaColor { get; set; }
	[InLua("tile_editor_area_selection_color")]
    public Color TileEditorAreaSelectionColor { get; set; }
	[InLua("tile_editor_selection_preview_radius")]
    public byte TileEditorSelectionPreviewRadius { get; set; }
	[InLua("tile_editor_selection_preview_tint")]
    public Color TileEditorSelectionPreviewTint { get; set; }

    
    
    
    

    

    
}
using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("DeconstructionItemPrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class DeconstructionItemPrototype : SelectionToolPrototype
{
    [InLua("alt_entity_filter_mode")]
    public AltEntityFilterModeEnum? AltEntityFilterMode { get; set; }
	[InLua("alt_entity_filters")]
    public EntityID[]? AltEntityFilters { get; set; }
	[InLua("alt_entity_type_filters")]
    public string[]? AltEntityTypeFilters { get; set; }
	[InLua("alt_selection_mode")]
    public SelectionModeFlags? AltSelectionMode { get; set; }
	[InLua("alt_tile_filter_mode")]
    public AltTileFilterModeEnum? AltTileFilterMode { get; set; }
	[InLua("alt_tile_filters")]
    public TileID[]? AltTileFilters { get; set; }
	[InLua("always_include_tiles")]
    public bool? AlwaysIncludeTiles { get; set; }
	[InLua("entity_filter_count")]
    public ItemStackIndex? EntityFilterCount { get; set; }
	[InLua("entity_filter_mode")]
    public EntityFilterModeEnum? EntityFilterMode { get; set; }
	[InLua("entity_filters")]
    public EntityID[]? EntityFilters { get; set; }
	[InLua("entity_type_filters")]
    public string[]? EntityTypeFilters { get; set; }
	[InLua("selection_mode")]
    public SelectionModeFlags? SelectionMode { get; set; }
	[InLua("stack_size")]
    public double StackSize { get; } = 1;
	[InLua("tile_filter_count")]
    public ItemStackIndex? TileFilterCount { get; set; }
	[InLua("tile_filter_mode")]
    public TileFilterModeEnum? TileFilterMode { get; set; }
	[InLua("tile_filters")]
    public TileID[]? TileFilters { get; set; }

    
    
    
    

    

    
}
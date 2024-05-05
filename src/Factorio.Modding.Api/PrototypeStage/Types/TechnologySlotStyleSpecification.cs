using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("TechnologySlotStyleSpecification")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class TechnologySlotStyleSpecification : ButtonStyleSpecification
{
    [InLua("clicked_ingredients_background")]
    public ElementImageSet? ClickedIngredientsBackground { get; set; }
	[InLua("clicked_overlay")]
    public ElementImageSet? ClickedOverlay { get; set; }
	[InLua("default_background_shadow")]
    public ElementImageSet? DefaultBackgroundShadow { get; set; }
	[InLua("default_ingredients_background")]
    public ElementImageSet? DefaultIngredientsBackground { get; set; }
	[InLua("disabled_ingredients_background")]
    public ElementImageSet? DisabledIngredientsBackground { get; set; }
	[InLua("highlighted_graphical_set")]
    public ElementImageSet? HighlightedGraphicalSet { get; set; }
	[InLua("highlighted_ingredients_background")]
    public ElementImageSet? HighlightedIngredientsBackground { get; set; }
	[InLua("hovered_ingredients_background")]
    public ElementImageSet? HoveredIngredientsBackground { get; set; }
	[InLua("hovered_level_band")]
    public ElementImageSet? HoveredLevelBand { get; set; }
	[InLua("hovered_level_font_color")]
    public Color? HoveredLevelFontColor { get; set; }
	[InLua("hovered_level_range_band")]
    public ElementImageSet? HoveredLevelRangeBand { get; set; }
	[InLua("hovered_level_range_font_color")]
    public Color? HoveredLevelRangeFontColor { get; set; }
	[InLua("ingredient_icon_overlap")]
    public uint? IngredientIconOverlap { get; set; }
	[InLua("ingredient_icon_size")]
    public uint? IngredientIconSize { get; set; }
	[InLua("ingredients_height")]
    public uint? IngredientsHeight { get; set; }
	[InLua("ingredients_padding")]
    public uint? IngredientsPadding { get; set; }
	[InLua("level_band")]
    public ElementImageSet? LevelBand { get; set; }
	[InLua("level_band_height")]
    public uint? LevelBandHeight { get; set; }
	[InLua("level_band_width")]
    public uint? LevelBandWidth { get; set; }
	[InLua("level_font")]
    public string? LevelFont { get; set; }
	[InLua("level_font_color")]
    public Color? LevelFontColor { get; set; }
	[InLua("level_offset_x")]
    public int? LevelOffsetX { get; set; }
	[InLua("level_offset_y")]
    public int? LevelOffsetY { get; set; }
	[InLua("level_range_band")]
    public ElementImageSet? LevelRangeBand { get; set; }
	[InLua("level_range_font")]
    public string? LevelRangeFont { get; set; }
	[InLua("level_range_font_color")]
    public Color? LevelRangeFontColor { get; set; }
	[InLua("level_range_offset_x")]
    public int? LevelRangeOffsetX { get; set; }
	[InLua("level_range_offset_y")]
    public int? LevelRangeOffsetY { get; set; }
	[InLua("progress_bar")]
    public ElementImageSet? ProgressBar { get; set; }
	[InLua("progress_bar_background")]
    public ElementImageSet? ProgressBarBackground { get; set; }
	[InLua("progress_bar_color")]
    public Color? ProgressBarColor { get; set; }
	[InLua("progress_bar_height")]
    public uint? ProgressBarHeight { get; set; }
	[InLua("progress_bar_shadow")]
    public ElementImageSet? ProgressBarShadow { get; set; }
	[InLua("type")]
    public string Type { get; } = "technology_slot_style";

    
    
    
    

    

    
}
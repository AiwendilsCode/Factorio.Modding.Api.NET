using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("ElementImageSetLayer")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class ElementImageSetLayer 
{
    [InLua("background_blur")]
    public bool? BackgroundBlur { get; set; }
	[InLua("background_blur_sigma")]
    public float? BackgroundBlurSigma { get; set; }
	[InLua("border")]
    public int? Border { get; set; }
	[InLua("bottom")]
    public Sprite? Bottom { get; set; }
	[InLua("bottom_border")]
    public int? BottomBorder { get; set; }
	[InLua("bottom_outer_border_shift")]
    public int? BottomOuterBorderShift { get; set; }
	[InLua("bottom_tiling")]
    public bool? BottomTiling { get; set; }
	[InLua("bottom_width")]
    public SpriteSizeType? BottomWidth { get; set; }
	[InLua("center")]
    public Sprite? Center { get; set; }
	[InLua("center_height")]
    public SpriteSizeType? CenterHeight { get; set; }
	[InLua("center_tiling_horizontal")]
    public bool? CenterTilingHorizontal { get; set; }
	[InLua("center_tiling_vertical")]
    public bool? CenterTilingVertical { get; set; }
	[InLua("center_width")]
    public SpriteSizeType? CenterWidth { get; set; }
	[InLua("corner_size")]
    public OneOf<ushort, (ushort, ushort)>? CornerSize { get; set; }
	[InLua("custom_horizontal_tiling_sizes")]
    public uint[]? CustomHorizontalTilingSizes { get; set; }
	[InLua("draw_type")]
    public DrawTypeEnum? DrawType { get; set; }
	[InLua("filename")]
    public FileName? Filename { get; set; }
	[InLua("left")]
    public Sprite? Left { get; set; }
	[InLua("left_border")]
    public int? LeftBorder { get; set; }
	[InLua("left_bottom")]
    public Sprite? LeftBottom { get; set; }
	[InLua("left_height")]
    public SpriteSizeType? LeftHeight { get; set; }
	[InLua("left_outer_border_shift")]
    public int? LeftOuterBorderShift { get; set; }
	[InLua("left_tiling")]
    public bool? LeftTiling { get; set; }
	[InLua("left_top")]
    public Sprite? LeftTop { get; set; }
	[InLua("load_in_minimal_mode")]
    public bool? LoadInMinimalMode { get; set; }
	[InLua("opacity")]
    public double? Opacity { get; set; }
	[InLua("overall_tiling_horizontal_padding")]
    public ushort? OverallTilingHorizontalPadding { get; set; }
	[InLua("overall_tiling_horizontal_size")]
    public ushort? OverallTilingHorizontalSize { get; set; }
	[InLua("overall_tiling_horizontal_spacing")]
    public ushort? OverallTilingHorizontalSpacing { get; set; }
	[InLua("overall_tiling_vertical_padding")]
    public ushort? OverallTilingVerticalPadding { get; set; }
	[InLua("overall_tiling_vertical_size")]
    public ushort? OverallTilingVerticalSize { get; set; }
	[InLua("overall_tiling_vertical_spacing")]
    public ushort? OverallTilingVerticalSpacing { get; set; }
	[InLua("position")]
    public MapPosition? Position { get; set; }
	[InLua("right")]
    public Sprite? Right { get; set; }
	[InLua("right_border")]
    public int? RightBorder { get; set; }
	[InLua("right_bottom")]
    public Sprite? RightBottom { get; set; }
	[InLua("right_height")]
    public SpriteSizeType? RightHeight { get; set; }
	[InLua("right_outer_border_shift")]
    public int? RightOuterBorderShift { get; set; }
	[InLua("right_tiling")]
    public bool? RightTiling { get; set; }
	[InLua("right_top")]
    public Sprite? RightTop { get; set; }
	[InLua("scale")]
    public double? Scale { get; set; }
	[InLua("stretch_monolith_image_to_size")]
    public bool? StretchMonolithImageToSize { get; set; }
	[InLua("tint")]
    public Color? Tint { get; set; }
	[InLua("top")]
    public Sprite? Top { get; set; }
	[InLua("top_border")]
    public int? TopBorder { get; set; }
	[InLua("top_outer_border_shift")]
    public int? TopOuterBorderShift { get; set; }
	[InLua("top_tiling")]
    public bool? TopTiling { get; set; }
	[InLua("top_width")]
    public SpriteSizeType? TopWidth { get; set; }
	[InLua("type")]
    public TypeEnum? Type { get; set; }
	
    public Sprite? Sprite { get; set; }

    
    
    public ElementImageSetLayer() {}
    private ElementImageSetLayer(Sprite value)
    {
        Sprite = value;
    }

    public static implicit operator ElementImageSetLayer(Sprite value) => new(value);

    
}
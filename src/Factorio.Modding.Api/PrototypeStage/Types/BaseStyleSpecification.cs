using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("BaseStyleSpecification")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class BaseStyleSpecification 
{
    [InLua("bottom_margin")]
    public short? BottomMargin { get; set; }
	[InLua("bottom_padding")]
    public short? BottomPadding { get; set; }
	[InLua("effect")]
    public EffectEnum? Effect { get; set; }
	[InLua("effect_opacity")]
    public float? EffectOpacity { get; set; }
	[InLua("height")]
    public uint? Height { get; set; }
	[InLua("horizontal_align")]
    public HorizontalAlign? HorizontalAlign { get; set; }
	[InLua("horizontally_squashable")]
    public StretchRule? HorizontallySquashable { get; set; }
	[InLua("horizontally_stretchable")]
    public StretchRule? HorizontallyStretchable { get; set; }
	[InLua("ignored_by_search")]
    public bool? IgnoredBySearch { get; set; }
	[InLua("left_margin")]
    public short? LeftMargin { get; set; }
	[InLua("left_padding")]
    public short? LeftPadding { get; set; }
	[InLua("margin")]
    public short? Margin { get; set; }
	[InLua("maximal_height")]
    public uint? MaximalHeight { get; set; }
	[InLua("maximal_width")]
    public uint? MaximalWidth { get; set; }
	[InLua("minimal_height")]
    public uint? MinimalHeight { get; set; }
	[InLua("minimal_width")]
    public uint? MinimalWidth { get; set; }
	[InLua("natural_height")]
    public uint? NaturalHeight { get; set; }
	[InLua("natural_size")]
    public OneOf<uint, (uint, uint)>? NaturalSize { get; set; }
	[InLua("natural_width")]
    public uint? NaturalWidth { get; set; }
	[InLua("never_hide_by_search")]
    public bool? NeverHideBySearch { get; set; }
	[InLua("padding")]
    public short? Padding { get; set; }
	[InLua("parent")]
    public string? Parent { get; set; }
	[InLua("right_margin")]
    public short? RightMargin { get; set; }
	[InLua("right_padding")]
    public short? RightPadding { get; set; }
	[InLua("size")]
    public OneOf<uint, (uint, uint)>? Size { get; set; }
	[InLua("tooltip")]
    public LocalisedString? Tooltip { get; set; }
	[InLua("top_margin")]
    public short? TopMargin { get; set; }
	[InLua("top_padding")]
    public short? TopPadding { get; set; }
	[InLua("vertical_align")]
    public VerticalAlign? VerticalAlign { get; set; }
	[InLua("vertically_squashable")]
    public StretchRule? VerticallySquashable { get; set; }
	[InLua("vertically_stretchable")]
    public StretchRule? VerticallyStretchable { get; set; }
	[InLua("width")]
    public uint? Width { get; set; }

    
    
    
    

    

    
}
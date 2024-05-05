using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("BorderImageSet")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class BorderImageSet 
{
    [InLua("border_width")]
    public uint? BorderWidth { get; set; }
	[InLua("bottom_end")]
    public Sprite? BottomEnd { get; set; }
	[InLua("bottom_left_corner")]
    public Sprite? BottomLeftCorner { get; set; }
	[InLua("bottom_right_corner")]
    public Sprite? BottomRightCorner { get; set; }
	[InLua("bottom_t")]
    public Sprite? BottomT { get; set; }
	[InLua("cross")]
    public Sprite? Cross { get; set; }
	[InLua("horizontal_line")]
    public Sprite? HorizontalLine { get; set; }
	[InLua("left_end")]
    public Sprite? LeftEnd { get; set; }
	[InLua("left_t")]
    public Sprite? LeftT { get; set; }
	[InLua("right_end")]
    public Sprite? RightEnd { get; set; }
	[InLua("right_t")]
    public Sprite? RightT { get; set; }
	[InLua("scale")]
    public double? Scale { get; set; }
	[InLua("top_end")]
    public Sprite? TopEnd { get; set; }
	[InLua("top_left_coner")]
    public Sprite? TopLeftConer { get; set; }
	[InLua("top_right_corner")]
    public Sprite? TopRightCorner { get; set; }
	[InLua("top_t")]
    public Sprite? TopT { get; set; }
	[InLua("vertical_line")]
    public Sprite? VerticalLine { get; set; }

    
    
    
    

    

    
}
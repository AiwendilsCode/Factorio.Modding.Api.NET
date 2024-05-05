using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("RailPictureSet")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class RailPictureSet 
{
    [InLua("curved_rail_horizontal_left_bottom")]
    public RailPieceLayers CurvedRailHorizontalLeftBottom { get; set; }
	[InLua("curved_rail_horizontal_left_top")]
    public RailPieceLayers CurvedRailHorizontalLeftTop { get; set; }
	[InLua("curved_rail_horizontal_right_bottom")]
    public RailPieceLayers CurvedRailHorizontalRightBottom { get; set; }
	[InLua("curved_rail_horizontal_right_top")]
    public RailPieceLayers CurvedRailHorizontalRightTop { get; set; }
	[InLua("curved_rail_vertical_left_bottom")]
    public RailPieceLayers CurvedRailVerticalLeftBottom { get; set; }
	[InLua("curved_rail_vertical_left_top")]
    public RailPieceLayers CurvedRailVerticalLeftTop { get; set; }
	[InLua("curved_rail_vertical_right_bottom")]
    public RailPieceLayers CurvedRailVerticalRightBottom { get; set; }
	[InLua("curved_rail_vertical_right_top")]
    public RailPieceLayers CurvedRailVerticalRightTop { get; set; }
	[InLua("rail_endings")]
    public Sprite8Way RailEndings { get; set; }
	[InLua("straight_rail_diagonal_left_bottom")]
    public RailPieceLayers StraightRailDiagonalLeftBottom { get; set; }
	[InLua("straight_rail_diagonal_left_top")]
    public RailPieceLayers StraightRailDiagonalLeftTop { get; set; }
	[InLua("straight_rail_diagonal_right_bottom")]
    public RailPieceLayers StraightRailDiagonalRightBottom { get; set; }
	[InLua("straight_rail_diagonal_right_top")]
    public RailPieceLayers StraightRailDiagonalRightTop { get; set; }
	[InLua("straight_rail_horizontal")]
    public RailPieceLayers StraightRailHorizontal { get; set; }
	[InLua("straight_rail_vertical")]
    public RailPieceLayers StraightRailVertical { get; set; }

    
    
    
    

    

    
}
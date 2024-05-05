using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("WallPictures")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class WallPictures 
{
    [InLua("corner_left_down")]
    public SpriteVariations CornerLeftDown { get; set; }
	[InLua("corner_right_down")]
    public SpriteVariations CornerRightDown { get; set; }
	[InLua("ending_left")]
    public SpriteVariations EndingLeft { get; set; }
	[InLua("ending_right")]
    public SpriteVariations EndingRight { get; set; }
	[InLua("filling")]
    public SpriteVariations? Filling { get; set; }
	[InLua("gate_connection_patch")]
    public Sprite4Way? GateConnectionPatch { get; set; }
	[InLua("single")]
    public SpriteVariations Single { get; set; }
	[InLua("straight_horizontal")]
    public SpriteVariations StraightHorizontal { get; set; }
	[InLua("straight_vertical")]
    public SpriteVariations StraightVertical { get; set; }
	[InLua("t_up")]
    public SpriteVariations TUp { get; set; }
	[InLua("water_connection_patch")]
    public Sprite4Way? WaterConnectionPatch { get; set; }

    
    
    
    

    

    
}
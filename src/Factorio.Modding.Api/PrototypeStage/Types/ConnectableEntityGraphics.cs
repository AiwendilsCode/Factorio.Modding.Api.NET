using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("ConnectableEntityGraphics")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class ConnectableEntityGraphics 
{
    [InLua("corner_left_down")]
    public SpriteVariations CornerLeftDown { get; set; }
	[InLua("corner_left_up")]
    public SpriteVariations CornerLeftUp { get; set; }
	[InLua("corner_right_down")]
    public SpriteVariations CornerRightDown { get; set; }
	[InLua("corner_right_up")]
    public SpriteVariations CornerRightUp { get; set; }
	[InLua("cross")]
    public SpriteVariations Cross { get; set; }
	[InLua("ending_down")]
    public SpriteVariations EndingDown { get; set; }
	[InLua("ending_left")]
    public SpriteVariations EndingLeft { get; set; }
	[InLua("ending_right")]
    public SpriteVariations EndingRight { get; set; }
	[InLua("ending_up")]
    public SpriteVariations EndingUp { get; set; }
	[InLua("single")]
    public SpriteVariations Single { get; set; }
	[InLua("straight_horizontal")]
    public SpriteVariations StraightHorizontal { get; set; }
	[InLua("straight_vertical")]
    public SpriteVariations StraightVertical { get; set; }
	[InLua("t_down")]
    public SpriteVariations TDown { get; set; }
	[InLua("t_left")]
    public SpriteVariations TLeft { get; set; }
	[InLua("t_right")]
    public SpriteVariations TRight { get; set; }
	[InLua("t_up")]
    public SpriteVariations TUp { get; set; }

    
    
    
    

    

    
}
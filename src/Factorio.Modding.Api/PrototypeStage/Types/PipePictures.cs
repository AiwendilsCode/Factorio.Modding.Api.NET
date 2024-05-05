using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("PipePictures")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class PipePictures 
{
    [InLua("corner_down_left")]
    public Sprite CornerDownLeft { get; set; }
	[InLua("corner_down_right")]
    public Sprite CornerDownRight { get; set; }
	[InLua("corner_up_left")]
    public Sprite CornerUpLeft { get; set; }
	[InLua("corner_up_right")]
    public Sprite CornerUpRight { get; set; }
	[InLua("cross")]
    public Sprite Cross { get; set; }
	[InLua("ending_down")]
    public Sprite EndingDown { get; set; }
	[InLua("ending_left")]
    public Sprite EndingLeft { get; set; }
	[InLua("ending_right")]
    public Sprite EndingRight { get; set; }
	[InLua("ending_up")]
    public Sprite EndingUp { get; set; }
	[InLua("fluid_background")]
    public Sprite FluidBackground { get; set; }
	[InLua("gas_flow")]
    public Animation GasFlow { get; set; }
	[InLua("high_temperature_flow")]
    public Sprite HighTemperatureFlow { get; set; }
	[InLua("horizontal_window_background")]
    public Sprite HorizontalWindowBackground { get; set; }
	[InLua("low_temperature_flow")]
    public Sprite LowTemperatureFlow { get; set; }
	[InLua("middle_temperature_flow")]
    public Sprite MiddleTemperatureFlow { get; set; }
	[InLua("straight_horizontal")]
    public Sprite StraightHorizontal { get; set; }
	[InLua("straight_horizontal_window")]
    public Sprite StraightHorizontalWindow { get; set; }
	[InLua("straight_vertical")]
    public Sprite StraightVertical { get; set; }
	[InLua("straight_vertical_single")]
    public Sprite StraightVerticalSingle { get; set; }
	[InLua("straight_vertical_window")]
    public Sprite StraightVerticalWindow { get; set; }
	[InLua("t_down")]
    public Sprite TDown { get; set; }
	[InLua("t_left")]
    public Sprite TLeft { get; set; }
	[InLua("t_right")]
    public Sprite TRight { get; set; }
	[InLua("t_up")]
    public Sprite TUp { get; set; }
	[InLua("vertical_window_background")]
    public Sprite VerticalWindowBackground { get; set; }

    
    
    
    

    

    
}
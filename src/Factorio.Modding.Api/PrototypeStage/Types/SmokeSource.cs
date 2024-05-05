using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("SmokeSource")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class SmokeSource 
{
    [InLua("deviation")]
    public MapPosition? Deviation { get; set; }
	[InLua("east_position")]
    public Vector? EastPosition { get; set; }
	[InLua("frequency")]
    public double Frequency { get; set; }
	[InLua("height")]
    public float? Height { get; set; }
	[InLua("height_deviation")]
    public float? HeightDeviation { get; set; }
	[InLua("name")]
    public TrivialSmokeID Name { get; set; }
	[InLua("north_position")]
    public Vector? NorthPosition { get; set; }
	[InLua("offset")]
    public double? Offset { get; set; }
	[InLua("position")]
    public Vector? Position { get; set; }
	[InLua("slow_down_factor")]
    public byte? SlowDownFactor { get; set; }
	[InLua("south_position")]
    public Vector? SouthPosition { get; set; }
	[InLua("starting_frame")]
    public ushort? StartingFrame { get; set; }
	[InLua("starting_frame_deviation")]
    public double? StartingFrameDeviation { get; set; }
	[InLua("starting_frame_speed")]
    public ushort? StartingFrameSpeed { get; set; }
	[InLua("starting_frame_speed_deviation")]
    public double? StartingFrameSpeedDeviation { get; set; }
	[InLua("starting_vertical_speed")]
    public float? StartingVerticalSpeed { get; set; }
	[InLua("starting_vertical_speed_deviation")]
    public float? StartingVerticalSpeedDeviation { get; set; }
	[InLua("vertical_speed_slowdown")]
    public float? VerticalSpeedSlowdown { get; set; }
	[InLua("west_position")]
    public Vector? WestPosition { get; set; }

    
    
    
    

    

    
}
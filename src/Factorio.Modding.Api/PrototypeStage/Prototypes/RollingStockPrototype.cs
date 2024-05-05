using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("RollingStockPrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class RollingStockPrototype : VehiclePrototype
{
    [InLua("air_resistance")]
    public double AirResistance { get; set; }
	[InLua("allow_manual_color")]
    public bool? AllowManualColor { get; set; }
	[InLua("allow_robot_dispatch_in_automatic_mode")]
    public bool? AllowRobotDispatchInAutomaticMode { get; set; }
	[InLua("back_light")]
    public LightDefinition? BackLight { get; set; }
	[InLua("collision_mask")]
    public CollisionMask? CollisionMask { get; set; }
	[InLua("color")]
    public Color? Color { get; set; }
	[InLua("connection_distance")]
    public double ConnectionDistance { get; set; }
	[InLua("drive_over_tie_trigger")]
    public TriggerEffect? DriveOverTieTrigger { get; set; }
	[InLua("horizontal_doors")]
    public Animation? HorizontalDoors { get; set; }
	[InLua("joint_distance")]
    public double JointDistance { get; set; }
	[InLua("max_speed")]
    public double MaxSpeed { get; set; }
	[InLua("pictures")]
    public RotatedSprite Pictures { get; set; }
	[InLua("stand_by_light")]
    public LightDefinition? StandByLight { get; set; }
	[InLua("tie_distance")]
    public double? TieDistance { get; set; }
	[InLua("vertical_doors")]
    public Animation? VerticalDoors { get; set; }
	[InLua("vertical_selection_shift")]
    public double VerticalSelectionShift { get; set; }
	[InLua("wheels")]
    public RotatedSprite? Wheels { get; set; }

    
    
    
    

    

    
}
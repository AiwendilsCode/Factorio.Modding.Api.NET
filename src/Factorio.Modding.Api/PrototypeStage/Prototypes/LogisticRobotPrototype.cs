using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("LogisticRobotPrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class LogisticRobotPrototype : RobotWithLogisticInterfacePrototype
{
    [InLua("collision_box")]
    public BoundingBox? CollisionBox { get; set; }
	[InLua("idle_with_cargo")]
    public RotatedAnimation? IdleWithCargo { get; set; }
	[InLua("in_motion_with_cargo")]
    public RotatedAnimation? InMotionWithCargo { get; set; }
	[InLua("shadow_idle_with_cargo")]
    public RotatedAnimation? ShadowIdleWithCargo { get; set; }
	[InLua("shadow_in_motion_with_cargo")]
    public RotatedAnimation? ShadowInMotionWithCargo { get; set; }

    
    
    
    

    

    
}
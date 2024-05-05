using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("RobotWithLogisticInterfacePrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class RobotWithLogisticInterfacePrototype : FlyingRobotPrototype
{
    [InLua("cargo_centered")]
    public Vector CargoCentered { get; set; }
	[InLua("destroy_action")]
    public Trigger? DestroyAction { get; set; }
	[InLua("draw_cargo")]
    public bool? DrawCargo { get; set; }
	[InLua("idle")]
    public RotatedAnimation? Idle { get; set; }
	[InLua("in_motion")]
    public RotatedAnimation? InMotion { get; set; }
	[InLua("max_payload_size")]
    public ItemCountType MaxPayloadSize { get; set; }
	[InLua("shadow_idle")]
    public RotatedAnimation? ShadowIdle { get; set; }
	[InLua("shadow_in_motion")]
    public RotatedAnimation? ShadowInMotion { get; set; }

    
    
    
    

    

    
}
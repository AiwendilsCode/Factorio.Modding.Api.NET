using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("ConstructionRobotPrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class ConstructionRobotPrototype : RobotWithLogisticInterfacePrototype
{
    [InLua("collision_box")]
    public BoundingBox? CollisionBox { get; set; }
	[InLua("construction_vector")]
    public Vector ConstructionVector { get; set; }
	[InLua("repairing_sound")]
    public Sound? RepairingSound { get; set; }
	[InLua("shadow_working")]
    public RotatedAnimation? ShadowWorking { get; set; }
	[InLua("smoke")]
    public Animation? Smoke { get; set; }
	[InLua("sparks")]
    public AnimationVariations? Sparks { get; set; }
	[InLua("working")]
    public RotatedAnimation? Working { get; set; }
	[InLua("working_light")]
    public LightDefinition? WorkingLight { get; set; }

    
    
    
    

    

    
}
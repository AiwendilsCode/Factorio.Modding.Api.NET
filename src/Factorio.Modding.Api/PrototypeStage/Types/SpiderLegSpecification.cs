using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("SpiderLegSpecification")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class SpiderLegSpecification 
{
    [InLua("blocking_legs")]
    public uint[] BlockingLegs { get; set; }
	[InLua("ground_position")]
    public Vector GroundPosition { get; set; }
	[InLua("leg")]
    public EntityID Leg { get; set; }
	[InLua("leg_hit_the_ground_trigger")]
    public TriggerEffect? LegHitTheGroundTrigger { get; set; }
	[InLua("mount_position")]
    public Vector MountPosition { get; set; }

    
    
    
    

    

    
}
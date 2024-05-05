using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("SpiderLegGraphicsSet")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class SpiderLegGraphicsSet 
{
    [InLua("joint")]
    public Sprite? Joint { get; set; }
	[InLua("joint_shadow")]
    public Sprite? JointShadow { get; set; }
	[InLua("joint_turn_offset")]
    public float? JointTurnOffset { get; set; }
	[InLua("lower_part")]
    public SpiderLegPart? LowerPart { get; set; }
	[InLua("lower_part_shadow")]
    public SpiderLegPart? LowerPartShadow { get; set; }
	[InLua("lower_part_water_reflection")]
    public SpiderLegPart? LowerPartWaterReflection { get; set; }
	[InLua("upper_part")]
    public SpiderLegPart? UpperPart { get; set; }
	[InLua("upper_part_shadow")]
    public SpiderLegPart? UpperPartShadow { get; set; }
	[InLua("upper_part_water_reflection")]
    public SpiderLegPart? UpperPartWaterReflection { get; set; }

    
    
    
    

    

    
}
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("TreeVariation")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class TreeVariation 
{
    [InLua("branch_generation")]
    public CreateParticleTriggerEffectItem BranchGeneration { get; set; }
	[InLua("disable_shadow_distortion_beginning_at_frame")]
    public uint? DisableShadowDistortionBeginningAtFrame { get; set; }
	[InLua("leaf_generation")]
    public CreateParticleTriggerEffectItem LeafGeneration { get; set; }
	[InLua("leaves")]
    public Animation Leaves { get; set; }
	[InLua("normal")]
    public Animation? Normal { get; set; }
	[InLua("overlay")]
    public Animation? Overlay { get; set; }
	[InLua("shadow")]
    public Animation? Shadow { get; set; }
	[InLua("trunk")]
    public Animation Trunk { get; set; }
	[InLua("water_reflection")]
    public WaterReflectionDefinition? WaterReflection { get; set; }

    
    
    
    

    

    
}
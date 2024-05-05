using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("DestroyCliffsCapsuleAction")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class DestroyCliffsCapsuleAction 
{
    [InLua("attack_parameters")]
    public AttackParameters AttackParameters { get; set; }
	[InLua("play_sound_on_failure")]
    public bool? PlaySoundOnFailure { get; set; }
	[InLua("radius")]
    public float Radius { get; set; }
	[InLua("timeout")]
    public uint? Timeout { get; set; }
	[InLua("type")]
    public string Type { get; } = "destroy-cliffs";
	[InLua("uses_stack")]
    public bool? UsesStack { get; set; }

    
    
    
    

    

    
}
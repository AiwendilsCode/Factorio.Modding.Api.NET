using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("ThrowCapsuleAction")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class ThrowCapsuleAction 
{
    [InLua("attack_parameters")]
    public AttackParameters AttackParameters { get; set; }
	[InLua("type")]
    public string Type { get; } = "throw";
	[InLua("uses_stack")]
    public bool? UsesStack { get; set; }

    
    
    
    

    

    
}
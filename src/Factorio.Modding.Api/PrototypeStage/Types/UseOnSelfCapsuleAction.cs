using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("UseOnSelfCapsuleAction")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class UseOnSelfCapsuleAction 
{
    [InLua("attack_parameters")]
    public AttackParameters AttackParameters { get; set; }
	[InLua("type")]
    public string Type { get; } = "use-on-self";
	[InLua("uses_stack")]
    public bool? UsesStack { get; set; }

    
    
    
    

    

    
}
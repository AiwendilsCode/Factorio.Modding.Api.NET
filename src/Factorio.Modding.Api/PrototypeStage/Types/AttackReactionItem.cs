using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("AttackReactionItem")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class AttackReactionItem 
{
    [InLua("action")]
    public Trigger? Action { get; set; }
	[InLua("damage_type")]
    public DamageTypeID? DamageType { get; set; }
	[InLua("range")]
    public float Range { get; set; }
	[InLua("reaction_modifier")]
    public float? ReactionModifier { get; set; }

    
    
    
    

    

    
}
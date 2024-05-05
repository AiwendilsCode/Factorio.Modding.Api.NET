using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("SetRecipeTipTrigger")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class SetRecipeTipTrigger 
{
    [InLua("consecutive")]
    public bool? Consecutive { get; set; }
	[InLua("machine")]
    public EntityID? Machine { get; set; }
	[InLua("recipe")]
    public RecipeID? Recipe { get; set; }
	[InLua("type")]
    public string Type { get; } = "set-recipe";
	[InLua("uses_fluid")]
    public bool? UsesFluid { get; set; }

    
    
    
    

    

    
}
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("UnlockRecipeTipTrigger")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class UnlockRecipeTipTrigger 
{
    [InLua("recipe")]
    public RecipeID Recipe { get; set; }
	[InLua("type")]
    public string Type { get; } = "unlock-recipe";

    
    
    
    

    

    
}
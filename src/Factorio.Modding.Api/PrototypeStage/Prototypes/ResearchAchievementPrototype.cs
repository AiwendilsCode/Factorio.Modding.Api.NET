using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("ResearchAchievementPrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class ResearchAchievementPrototype : AchievementPrototype
{
    [InLua("research_all")]
    public bool? ResearchAll { get; set; }
	[InLua("technology")]
    public TechnologyID? Technology { get; set; }

    
    
    
    

    

    
}
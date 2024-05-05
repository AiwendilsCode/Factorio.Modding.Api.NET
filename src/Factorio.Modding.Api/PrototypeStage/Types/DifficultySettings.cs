using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("DifficultySettings")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class DifficultySettings 
{
    [InLua("recipe_difficulty")]
    public byte RecipeDifficulty { get; set; }
	[InLua("research_queue_setting")]
    public ResearchQueueSettingEnum? ResearchQueueSetting { get; set; }
	[InLua("technology_difficulty")]
    public byte TechnologyDifficulty { get; set; }
	[InLua("technology_price_multiplier")]
    public double? TechnologyPriceMultiplier { get; set; }

    
    
    
    

    

    
}
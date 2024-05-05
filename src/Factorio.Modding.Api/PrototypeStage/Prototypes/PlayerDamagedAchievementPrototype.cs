using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("PlayerDamagedAchievementPrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class PlayerDamagedAchievementPrototype : AchievementPrototype
{
    [InLua("minimum_damage")]
    public float MinimumDamage { get; set; }
	[InLua("should_survive")]
    public bool ShouldSurvive { get; set; }
	[InLua("type_of_dealer")]
    public string? TypeOfDealer { get; set; }

    
    
    
    

    

    
}
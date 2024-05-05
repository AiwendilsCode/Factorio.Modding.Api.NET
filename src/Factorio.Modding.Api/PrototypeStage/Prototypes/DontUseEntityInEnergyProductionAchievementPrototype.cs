using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("DontUseEntityInEnergyProductionAchievementPrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class DontUseEntityInEnergyProductionAchievementPrototype : AchievementPrototype
{
    [InLua("excluded")]
    public OneOf<EntityID, EntityID[]> Excluded { get; set; }
	[InLua("included")]
    public OneOf<EntityID, EntityID[]> Included { get; set; }
	[InLua("last_hour_only")]
    public bool? LastHourOnly { get; set; }
	[InLua("minimum_energy_produced")]
    public Energy? MinimumEnergyProduced { get; set; }

    
    
    
    

    

    
}
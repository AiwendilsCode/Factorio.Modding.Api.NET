using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("BuildEntityAchievementPrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class BuildEntityAchievementPrototype : AchievementPrototype
{
    [InLua("amount")]
    public uint? Amount { get; set; }
	[InLua("limited_to_one_game")]
    public bool? LimitedToOneGame { get; set; }
	[InLua("to_build")]
    public EntityID ToBuild { get; set; }
	[InLua("until_second")]
    public uint? UntilSecond { get; set; }

    
    
    
    

    

    
}
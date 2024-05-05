using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("ProducePerHourAchievementPrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class ProducePerHourAchievementPrototype : AchievementPrototype
{
    [InLua("amount")]
    public MaterialAmountType Amount { get; set; }
	[InLua("fluid_product")]
    public FluidID? FluidProduct { get; set; }
	[InLua("item_product")]
    public ItemID? ItemProduct { get; set; }

    
    
    
    

    

    
}
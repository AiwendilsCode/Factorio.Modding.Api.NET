using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("FluidProductPrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class FluidProductPrototype 
{
    [InLua("amount")]
    public double? Amount { get; set; }
	[InLua("amount_max")]
    public MaterialAmountType AmountMax { get; set; }
	[InLua("amount_min")]
    public MaterialAmountType AmountMin { get; set; }
	[InLua("catalyst_amount")]
    public double? CatalystAmount { get; set; }
	[InLua("fluidbox_index")]
    public uint? FluidboxIndex { get; set; }
	[InLua("name")]
    public FluidID Name { get; set; }
	[InLua("probability")]
    public double? Probability { get; set; }
	[InLua("show_details_in_recipe_tooltip")]
    public bool? ShowDetailsInRecipeTooltip { get; set; }
	[InLua("temperature")]
    public double? Temperature { get; set; }
	[InLua("type")]
    public string Type { get; } = "fluid";

    
    
    
    

    

    
}
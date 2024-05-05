using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("FluidIngredientPrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class FluidIngredientPrototype 
{
    [InLua("amount")]
    public double Amount { get; set; }
	[InLua("catalyst_amount")]
    public double? CatalystAmount { get; set; }
	[InLua("fluidbox_index")]
    public uint? FluidboxIndex { get; set; }
	[InLua("maximum_temperature")]
    public double? MaximumTemperature { get; set; }
	[InLua("minimum_temperature")]
    public double? MinimumTemperature { get; set; }
	[InLua("name")]
    public FluidID Name { get; set; }
	[InLua("temperature")]
    public double? Temperature { get; set; }
	[InLua("type")]
    public string Type { get; } = "fluid";

    
    
    
    

    

    
}
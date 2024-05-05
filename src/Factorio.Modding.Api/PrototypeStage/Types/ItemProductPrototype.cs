using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("ItemProductPrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class ItemProductPrototype 
{
    [InLua("amount")]
    public ushort? Amount { get; set; }
	[InLua("amount_max")]
    public ushort AmountMax { get; set; }
	[InLua("amount_min")]
    public ushort AmountMin { get; set; }
	[InLua("catalyst_amount")]
    public ushort? CatalystAmount { get; set; }
	[InLua("name")]
    public ItemID Name { get; set; }
	[InLua("probability")]
    public double? Probability { get; set; }
	[InLua("show_details_in_recipe_tooltip")]
    public bool? ShowDetailsInRecipeTooltip { get; set; }
	[InLua("type")]
    public string? Type { get; } = "item";

    
    
    public ItemProductPrototype() {}
    private ItemProductPrototype((ItemID, ushort) value)
    {
        Name = value.Item1;
AmountMax = value.Item2;

    }

    public static implicit operator ItemProductPrototype((ItemID, ushort) value) => new(value);

    
}
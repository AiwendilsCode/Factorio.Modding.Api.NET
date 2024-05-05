using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("ItemIngredientPrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class ItemIngredientPrototype 
{
    [InLua("amount")]
    public ushort Amount { get; set; }
	[InLua("catalyst_amount")]
    public ushort? CatalystAmount { get; set; }
	[InLua("name")]
    public ItemID Name { get; set; }
	[InLua("type")]
    public string? Type { get; } = "item";

    
    
    public ItemIngredientPrototype() {}
    private ItemIngredientPrototype((ItemID, ushort) value)
    {
        Name = value.Item1;
Amount = value.Item2;

    }

    public static implicit operator ItemIngredientPrototype((ItemID, ushort) value) => new(value);

    
}
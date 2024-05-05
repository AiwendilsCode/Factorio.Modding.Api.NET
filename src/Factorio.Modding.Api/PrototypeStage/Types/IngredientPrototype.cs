using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("IngredientPrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class IngredientPrototype 
{
    
    public OneOf<ItemIngredientPrototype, FluidIngredientPrototype> Value { get; set; }

    
    
    
    private IngredientPrototype(ItemIngredientPrototype value)
    {
        Value = value;
    }

	private IngredientPrototype(FluidIngredientPrototype value)
    {
        Value = value;
    }

    public static implicit operator IngredientPrototype(ItemIngredientPrototype value) => new(value);

	public static implicit operator IngredientPrototype(FluidIngredientPrototype value) => new(value);

    
}
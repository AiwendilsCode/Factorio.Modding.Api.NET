using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("ProductPrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class ProductPrototype 
{
    
    public OneOf<ItemProductPrototype, FluidProductPrototype> Value { get; set; }

    
    
    
    private ProductPrototype(ItemProductPrototype value)
    {
        Value = value;
    }

	private ProductPrototype(FluidProductPrototype value)
    {
        Value = value;
    }

    public static implicit operator ProductPrototype(ItemProductPrototype value) => new(value);

	public static implicit operator ProductPrototype(FluidProductPrototype value) => new(value);

    
}
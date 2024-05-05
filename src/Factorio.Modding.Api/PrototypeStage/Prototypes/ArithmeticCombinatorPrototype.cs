using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("ArithmeticCombinatorPrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class ArithmeticCombinatorPrototype : CombinatorPrototype
{
    [InLua("and_symbol_sprites")]
    public Sprite4Way? AndSymbolSprites { get; set; }
	[InLua("divide_symbol_sprites")]
    public Sprite4Way? DivideSymbolSprites { get; set; }
	[InLua("left_shift_symbol_sprites")]
    public Sprite4Way? LeftShiftSymbolSprites { get; set; }
	[InLua("minus_symbol_sprites")]
    public Sprite4Way? MinusSymbolSprites { get; set; }
	[InLua("modulo_symbol_sprites")]
    public Sprite4Way? ModuloSymbolSprites { get; set; }
	[InLua("multiply_symbol_sprites")]
    public Sprite4Way? MultiplySymbolSprites { get; set; }
	[InLua("or_symbol_sprites")]
    public Sprite4Way? OrSymbolSprites { get; set; }
	[InLua("plus_symbol_sprites")]
    public Sprite4Way? PlusSymbolSprites { get; set; }
	[InLua("power_symbol_sprites")]
    public Sprite4Way? PowerSymbolSprites { get; set; }
	[InLua("right_shift_symbol_sprites")]
    public Sprite4Way? RightShiftSymbolSprites { get; set; }
	[InLua("xor_symbol_sprites")]
    public Sprite4Way? XorSymbolSprites { get; set; }

    
    
    
    

    

    
}
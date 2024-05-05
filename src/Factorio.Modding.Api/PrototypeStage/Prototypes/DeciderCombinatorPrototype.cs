using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("DeciderCombinatorPrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class DeciderCombinatorPrototype : CombinatorPrototype
{
    [InLua("equal_symbol_sprites")]
    public Sprite4Way? EqualSymbolSprites { get; set; }
	[InLua("greater_or_equal_symbol_sprites")]
    public Sprite4Way? GreaterOrEqualSymbolSprites { get; set; }
	[InLua("greater_symbol_sprites")]
    public Sprite4Way? GreaterSymbolSprites { get; set; }
	[InLua("less_or_equal_symbol_sprites")]
    public Sprite4Way? LessOrEqualSymbolSprites { get; set; }
	[InLua("less_symbol_sprites")]
    public Sprite4Way? LessSymbolSprites { get; set; }
	[InLua("not_equal_symbol_sprites")]
    public Sprite4Way? NotEqualSymbolSprites { get; set; }

    
    
    
    

    

    
}
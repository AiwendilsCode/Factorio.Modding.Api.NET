using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("Sprite4Way")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class Sprite4Way 
{
    [InLua("east")]
    public Sprite? East { get; set; }
	[InLua("north")]
    public Sprite? North { get; set; }
	[InLua("sheet")]
    public SpriteNWaySheet? Sheet { get; set; }
	[InLua("sheets")]
    public SpriteNWaySheet[]? Sheets { get; set; }
	[InLua("south")]
    public Sprite? South { get; set; }
	[InLua("west")]
    public Sprite? West { get; set; }
	
    public Sprite? Sprite { get; set; }

    
    
    public Sprite4Way() {}
    private Sprite4Way(Sprite value)
    {
        Sprite = value;
    }

    public static implicit operator Sprite4Way(Sprite value) => new(value);

    
}
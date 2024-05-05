using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("Sprite8Way")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class Sprite8Way 
{
    [InLua("east")]
    public Sprite? East { get; set; }
	[InLua("north")]
    public Sprite? North { get; set; }
	[InLua("north_east")]
    public Sprite? NorthEast { get; set; }
	[InLua("north_west")]
    public Sprite? NorthWest { get; set; }
	[InLua("sheet")]
    public SpriteNWaySheet? Sheet { get; set; }
	[InLua("sheets")]
    public SpriteNWaySheet[]? Sheets { get; set; }
	[InLua("south")]
    public Sprite? South { get; set; }
	[InLua("south_east")]
    public Sprite? SouthEast { get; set; }
	[InLua("south_west")]
    public Sprite? SouthWest { get; set; }
	[InLua("west")]
    public Sprite? West { get; set; }

    
    
    
    

    

    
}
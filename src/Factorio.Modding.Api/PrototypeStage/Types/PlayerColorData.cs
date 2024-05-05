using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("PlayerColorData")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class PlayerColorData 
{
    [InLua("chat_color")]
    public Color ChatColor { get; set; }
	[InLua("name")]
    public string Name { get; set; }
	[InLua("player_color")]
    public Color PlayerColor { get; set; }

    
    
    
    

    

    
}
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("BoilerPatch")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class BoilerPatch 
{
    [InLua("east")]
    public Sprite? East { get; set; }
	[InLua("north")]
    public Sprite? North { get; set; }
	[InLua("south")]
    public Sprite? South { get; set; }
	[InLua("west")]
    public Sprite? West { get; set; }

    
    
    
    

    

    
}
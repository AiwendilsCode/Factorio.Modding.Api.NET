using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("BoilerFire")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class BoilerFire 
{
    [InLua("east")]
    public Animation? East { get; set; }
	[InLua("north")]
    public Animation? North { get; set; }
	[InLua("south")]
    public Animation? South { get; set; }
	[InLua("west")]
    public Animation? West { get; set; }

    
    
    
    

    

    
}
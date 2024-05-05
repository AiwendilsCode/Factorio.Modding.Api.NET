using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("DirectionShift")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class DirectionShift 
{
    [InLua("east")]
    public Vector? East { get; set; }
	[InLua("north")]
    public Vector? North { get; set; }
	[InLua("south")]
    public Vector? South { get; set; }
	[InLua("west")]
    public Vector? West { get; set; }

    
    
    
    

    

    
}
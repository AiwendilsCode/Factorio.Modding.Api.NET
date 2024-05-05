using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("CircuitConnectorSecondaryDrawOrder")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class CircuitConnectorSecondaryDrawOrder 
{
    [InLua("east")]
    public sbyte? East { get; set; }
	[InLua("north")]
    public sbyte? North { get; set; }
	[InLua("south")]
    public sbyte? South { get; set; }
	[InLua("west")]
    public sbyte? West { get; set; }

    
    
    
    

    

    
}
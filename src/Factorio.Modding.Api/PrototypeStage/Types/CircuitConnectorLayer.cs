using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("CircuitConnectorLayer")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class CircuitConnectorLayer 
{
    [InLua("east")]
    public RenderLayer? East { get; set; }
	[InLua("north")]
    public RenderLayer? North { get; set; }
	[InLua("south")]
    public RenderLayer? South { get; set; }
	[InLua("west")]
    public RenderLayer? West { get; set; }

    
    
    
    

    

    
}
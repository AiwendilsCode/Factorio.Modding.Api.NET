using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("PumpConnectorGraphics")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class PumpConnectorGraphics 
{
    [InLua("east")]
    public PumpConnectorGraphicsAnimation[] East { get; set; }
	[InLua("north")]
    public PumpConnectorGraphicsAnimation[] North { get; set; }
	[InLua("south")]
    public PumpConnectorGraphicsAnimation[] South { get; set; }
	[InLua("west")]
    public PumpConnectorGraphicsAnimation[] West { get; set; }

    
    
    
    

    

    
}
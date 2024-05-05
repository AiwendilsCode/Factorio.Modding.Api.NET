using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("FluidWagonConnectorGraphics")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class FluidWagonConnectorGraphics 
{
    [InLua("load_animations")]
    public PumpConnectorGraphics LoadAnimations { get; set; }
	[InLua("unload_animations")]
    public PumpConnectorGraphics UnloadAnimations { get; set; }

    
    
    
    

    

    
}
using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("RailChainSignalPrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class RailChainSignalPrototype : RailSignalBasePrototype
{
    [InLua("blue_light")]
    public LightDefinition? BlueLight { get; set; }
	[InLua("default_blue_output_signal")]
    public SignalIDConnector? DefaultBlueOutputSignal { get; set; }
	[InLua("selection_box_offsets")]
    public Vector[] SelectionBoxOffsets { get; set; }

    
    
    
    

    

    
}
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("ElectricEnergySource")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class ElectricEnergySource : BaseEnergySource
{
    [InLua("buffer_capacity")]
    public Energy? BufferCapacity { get; set; }
	[InLua("drain")]
    public Energy? Drain { get; set; }
	[InLua("input_flow_limit")]
    public Energy? InputFlowLimit { get; set; }
	[InLua("output_flow_limit")]
    public Energy? OutputFlowLimit { get; set; }
	[InLua("type")]
    public string? Type { get; } = "electric";
	[InLua("usage_priority")]
    public ElectricUsagePriority UsagePriority { get; set; }

    
    
    
    

    

    
}
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("RandomPenaltyArguments")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class RandomPenaltyArguments 
{
    [InLua("amplitude")]
    public ConstantNoiseNumber? Amplitude { get; set; }
	[InLua("seed")]
    public ConstantNoiseNumber? Seed { get; set; }
	[InLua("source")]
    public NoiseNumber Source { get; set; }
	[InLua("x")]
    public NoiseNumber X { get; set; }
	[InLua("y")]
    public NoiseNumber Y { get; set; }

    
    
    
    

    

    
}
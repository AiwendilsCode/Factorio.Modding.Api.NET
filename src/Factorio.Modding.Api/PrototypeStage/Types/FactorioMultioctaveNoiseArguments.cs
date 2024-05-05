using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("FactorioMultioctaveNoiseArguments")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class FactorioMultioctaveNoiseArguments 
{
    [InLua("input_scale")]
    public ConstantNoiseNumber? InputScale { get; set; }
	[InLua("octaves")]
    public ConstantNoiseNumber Octaves { get; set; }
	[InLua("output_scale")]
    public ConstantNoiseNumber? OutputScale { get; set; }
	[InLua("persistence")]
    public ConstantNoiseNumber Persistence { get; set; }
	[InLua("seed0")]
    public ConstantNoiseNumber Seed0 { get; set; }
	[InLua("seed1")]
    public ConstantNoiseNumber Seed1 { get; set; }
	[InLua("x")]
    public NoiseNumber X { get; set; }
	[InLua("y")]
    public NoiseNumber Y { get; set; }

    
    
    
    

    

    
}
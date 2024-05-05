using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("MinableProperties")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class MinableProperties 
{
    [InLua("count")]
    public ushort? Count { get; set; }
	[InLua("fluid_amount")]
    public double? FluidAmount { get; set; }
	[InLua("mining_particle")]
    public ParticleID? MiningParticle { get; set; }
	[InLua("mining_time")]
    public double MiningTime { get; set; }
	[InLua("mining_trigger")]
    public Trigger? MiningTrigger { get; set; }
	[InLua("required_fluid")]
    public FluidID? RequiredFluid { get; set; }
	[InLua("result")]
    public ItemID? Result { get; set; }
	[InLua("results")]
    public ProductPrototype[]? Results { get; set; }

    
    
    
    

    

    
}
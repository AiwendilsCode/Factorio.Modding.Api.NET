using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("SpawnPoint")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class SpawnPoint 
{
    [InLua("evolution_factor")]
    public double EvolutionFactor { get; set; }
	[InLua("spawn_weight")]
    public double SpawnWeight { get; set; }

    
    
    public SpawnPoint() {}
    private SpawnPoint((double, double) value)
    {
        EvolutionFactor = value.Item1;
SpawnWeight = value.Item2;

    }

    public static implicit operator SpawnPoint((double, double) value) => new(value);

    
}
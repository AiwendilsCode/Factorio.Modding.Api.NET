using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("EnemyEvolutionSettings")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class EnemyEvolutionSettings 
{
    [InLua("destroy_factor")]
    public double DestroyFactor { get; set; }
	[InLua("enabled")]
    public bool Enabled { get; set; }
	[InLua("pollution_factor")]
    public double PollutionFactor { get; set; }
	[InLua("time_factor")]
    public double TimeFactor { get; set; }

    
    
    
    

    

    
}
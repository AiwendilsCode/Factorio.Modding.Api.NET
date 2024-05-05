using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("UnitSpawnDefinition")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class UnitSpawnDefinition 
{
    [InLua("spawn_points")]
    public SpawnPoint[] SpawnPoints { get; set; }
	[InLua("unit")]
    public EntityID Unit { get; set; }

    
    
    public UnitSpawnDefinition() {}
    private UnitSpawnDefinition((EntityID, SpawnPoint[]) value)
    {
        Unit = value.Item1;
SpawnPoints = value.Item2;

    }

    public static implicit operator UnitSpawnDefinition((EntityID, SpawnPoint[]) value) => new(value);

    
}
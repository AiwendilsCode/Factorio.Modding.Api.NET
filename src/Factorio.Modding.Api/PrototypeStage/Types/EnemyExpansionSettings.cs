using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("EnemyExpansionSettings")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class EnemyExpansionSettings 
{
    [InLua("building_coefficient")]
    public double BuildingCoefficient { get; set; }
	[InLua("enabled")]
    public bool Enabled { get; set; }
	[InLua("enemy_building_influence_radius")]
    public uint EnemyBuildingInfluenceRadius { get; set; }
	[InLua("friendly_base_influence_radius")]
    public uint FriendlyBaseInfluenceRadius { get; set; }
	[InLua("max_colliding_tiles_coefficient")]
    public double MaxCollidingTilesCoefficient { get; set; }
	[InLua("max_expansion_cooldown")]
    public uint MaxExpansionCooldown { get; set; }
	[InLua("max_expansion_distance")]
    public uint MaxExpansionDistance { get; set; }
	[InLua("min_expansion_cooldown")]
    public uint MinExpansionCooldown { get; set; }
	[InLua("neighbouring_base_chunk_coefficient")]
    public double NeighbouringBaseChunkCoefficient { get; set; }
	[InLua("neighbouring_chunk_coefficient")]
    public double NeighbouringChunkCoefficient { get; set; }
	[InLua("other_base_coefficient")]
    public double OtherBaseCoefficient { get; set; }
	[InLua("settler_group_max_size")]
    public uint SettlerGroupMaxSize { get; set; }
	[InLua("settler_group_min_size")]
    public uint SettlerGroupMinSize { get; set; }

    
    
    
    

    

    
}
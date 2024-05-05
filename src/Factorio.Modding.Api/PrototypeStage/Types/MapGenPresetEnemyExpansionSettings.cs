using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("MapGenPresetEnemyExpansionSettings")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class MapGenPresetEnemyExpansionSettings 
{
    [InLua("enabled")]
    public bool? Enabled { get; set; }
	[InLua("max_expansion_cooldown")]
    public uint? MaxExpansionCooldown { get; set; }
	[InLua("max_expansion_distance")]
    public uint? MaxExpansionDistance { get; set; }
	[InLua("min_expansion_cooldown")]
    public uint? MinExpansionCooldown { get; set; }
	[InLua("settler_group_max_size")]
    public uint? SettlerGroupMaxSize { get; set; }
	[InLua("settler_group_min_size")]
    public uint? SettlerGroupMinSize { get; set; }

    
    
    
    

    

    
}
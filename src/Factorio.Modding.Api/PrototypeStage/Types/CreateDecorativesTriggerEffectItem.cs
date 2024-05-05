using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("CreateDecorativesTriggerEffectItem")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class CreateDecorativesTriggerEffectItem : TriggerEffectItem
{
    [InLua("apply_projection")]
    public bool? ApplyProjection { get; set; }
	[InLua("decorative")]
    public DecorativeID Decorative { get; set; }
	[InLua("radius_curve")]
    public float? RadiusCurve { get; set; }
	[InLua("spawn_max")]
    public ushort SpawnMax { get; set; }
	[InLua("spawn_max_radius")]
    public float SpawnMaxRadius { get; set; }
	[InLua("spawn_min")]
    public ushort? SpawnMin { get; set; }
	[InLua("spawn_min_radius")]
    public float SpawnMinRadius { get; set; }
	[InLua("spread_evenly")]
    public bool? SpreadEvenly { get; set; }
	[InLua("type")]
    public string Type { get; } = "create-decorative";

    
    
    
    

    

    
}
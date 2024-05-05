using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("TurretAttackModifier")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class TurretAttackModifier : BaseModifier
{
    [InLua("infer_icon")]
    public bool? InferIcon { get; set; }
	[InLua("modifier")]
    public double Modifier { get; set; }
	[InLua("turret_id")]
    public EntityID TurretId { get; set; }
	[InLua("type")]
    public string Type { get; } = "turret-attack";
	[InLua("use_icon_overlay_constant")]
    public bool? UseIconOverlayConstant { get; set; }

    
    
    
    

    

    
}
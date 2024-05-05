using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("AmmoDamageModifier")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class AmmoDamageModifier : BaseModifier
{
    [InLua("ammo_category")]
    public AmmoCategoryID AmmoCategory { get; set; }
	[InLua("infer_icon")]
    public bool? InferIcon { get; set; }
	[InLua("modifier")]
    public double Modifier { get; set; }
	[InLua("type")]
    public string Type { get; } = "ammo-damage";
	[InLua("use_icon_overlay_constant")]
    public bool? UseIconOverlayConstant { get; set; }

    
    
    
    

    

    
}
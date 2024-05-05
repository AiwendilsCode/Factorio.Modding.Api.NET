using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("FootstepTriggerEffectItem")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class FootstepTriggerEffectItem : CreateParticleTriggerEffectItem
{
    [InLua("actions")]
    public CreateParticleTriggerEffectItem[]? Actions { get; set; }
	[InLua("tiles")]
    public TileID[] Tiles { get; set; }
	[InLua("use_as_default")]
    public bool? UseAsDefault { get; set; }

    
    
    
    

    

    
}
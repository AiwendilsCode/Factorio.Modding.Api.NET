using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("AutoplaceSettings")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class AutoplaceSettings 
{
    [InLua("settings")]
    public Dictionary<OneOf<EntityID, TileID, DecorativeID>, FrequencySizeRichness>? Settings { get; set; }
	[InLua("treat_missing_as_default")]
    public bool? TreatMissingAsDefault { get; set; }

    
    
    
    

    

    
}
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("ArtilleryRemoteCapsuleAction")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class ArtilleryRemoteCapsuleAction 
{
    [InLua("flare")]
    public EntityID Flare { get; set; }
	[InLua("play_sound_on_failure")]
    public bool? PlaySoundOnFailure { get; set; }
	[InLua("type")]
    public string Type { get; } = "artillery-remote";

    
    
    
    

    

    
}
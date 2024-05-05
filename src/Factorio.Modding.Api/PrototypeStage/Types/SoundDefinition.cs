using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("SoundDefinition")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class SoundDefinition 
{
    [InLua("filename")]
    public FileName Filename { get; set; }
	[InLua("max_speed")]
    public float? MaxSpeed { get; set; }
	[InLua("min_speed")]
    public float? MinSpeed { get; set; }
	[InLua("preload")]
    public bool? Preload { get; set; }
	[InLua("speed")]
    public float? Speed { get; set; }
	[InLua("volume")]
    public float? Volume { get; set; }

    
    
    
    

    

    
}
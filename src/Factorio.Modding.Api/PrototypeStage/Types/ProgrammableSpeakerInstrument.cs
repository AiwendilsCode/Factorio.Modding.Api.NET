using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("ProgrammableSpeakerInstrument")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class ProgrammableSpeakerInstrument 
{
    [InLua("name")]
    public string Name { get; set; }
	[InLua("notes")]
    public ProgrammableSpeakerNote[] Notes { get; set; }

    
    
    
    

    

    
}
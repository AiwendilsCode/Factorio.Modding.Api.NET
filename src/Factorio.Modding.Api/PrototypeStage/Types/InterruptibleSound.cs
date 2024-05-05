using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("InterruptibleSound")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class InterruptibleSound 
{
    [InLua("fade_ticks")]
    public uint? FadeTicks { get; set; }
	[InLua("sound")]
    public Sound Sound { get; set; }

    
    
    
    

    

    
}
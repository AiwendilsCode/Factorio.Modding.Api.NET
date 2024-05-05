using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("CyclicSound")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class CyclicSound 
{
    [InLua("begin_sound")]
    public Sound? BeginSound { get; set; }
	[InLua("end_sound")]
    public Sound? EndSound { get; set; }
	[InLua("middle_sound")]
    public Sound? MiddleSound { get; set; }

    
    
    
    

    

    
}
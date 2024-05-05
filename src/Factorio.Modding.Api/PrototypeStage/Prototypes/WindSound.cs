using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("WindSound")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class WindSound 
{
    [InLua("name")]
    public string Name { get; set; }
	[InLua("sound")]
    public Sound Sound { get; set; }
	[InLua("type")]
    public string Type { get; } = "wind-sound";

    
    
    
    

    

    
}
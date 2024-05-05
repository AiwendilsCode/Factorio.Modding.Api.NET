using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("SpectatorControllerPrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class SpectatorControllerPrototype 
{
    [InLua("movement_speed")]
    public double MovementSpeed { get; set; }
	[InLua("name")]
    public string Name { get; set; }
	[InLua("type")]
    public string Type { get; } = "spectator-controller";

    
    
    
    

    

    
}
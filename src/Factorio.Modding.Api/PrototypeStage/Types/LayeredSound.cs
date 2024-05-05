using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("LayeredSound")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class LayeredSound 
{
    [InLua("layers")]
    public Sound[] Layers { get; set; }
	
    public Sound? Sound { get; set; }

    
    
    public LayeredSound() {}
    private LayeredSound(Sound value)
    {
        Sound = value;
    }

    public static implicit operator LayeredSound(Sound value) => new(value);

    
}
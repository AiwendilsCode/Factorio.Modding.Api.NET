using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("ExplosionDefinition")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class ExplosionDefinition 
{
    [InLua("name")]
    public EntityID Name { get; set; }
	[InLua("offset")]
    public Vector? Offset { get; set; }

    
    
    public ExplosionDefinition() {}
    private ExplosionDefinition(EntityID value)
    {
        Name = value;
    }

    public static implicit operator ExplosionDefinition(EntityID value) => new(value);

    
}
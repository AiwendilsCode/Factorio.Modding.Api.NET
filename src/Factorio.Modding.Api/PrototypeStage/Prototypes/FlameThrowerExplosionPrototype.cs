using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("FlameThrowerExplosionPrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class FlameThrowerExplosionPrototype : ExplosionPrototype
{
    [InLua("damage")]
    public DamagePrototype Damage { get; set; }
	[InLua("height")]
    public float? Height { get; set; }
	[InLua("slow_down_factor")]
    public double SlowDownFactor { get; set; }

    
    
    
    

    

    
}
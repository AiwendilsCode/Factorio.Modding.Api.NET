using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("EntityPrototypeFlags")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class EntityPrototypeFlags 
{
    
    public EntityPrototypeFlagsEnum[] Value { get; set; }

    
    
    
    private EntityPrototypeFlags(EntityPrototypeFlagsEnum[] value)
    {
        Value = value;
    }

    public static implicit operator EntityPrototypeFlags(EntityPrototypeFlagsEnum[] value) => new(value);

    
}
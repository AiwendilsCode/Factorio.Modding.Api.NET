using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("CircularProjectileCreationSpecification")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class CircularProjectileCreationSpecification 
{
    
    public (RealOrientation, Vector)[] Value { get; set; }

    
    
    
    private CircularProjectileCreationSpecification((RealOrientation, Vector)[] value)
    {
        Value = value;
    }

    public static implicit operator CircularProjectileCreationSpecification((RealOrientation, Vector)[] value) => new(value);

    
}
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("AttackParameters")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class AttackParameters 
{
    
    public OneOf<ProjectileAttackParameters, BeamAttackParameters, StreamAttackParameters> Value { get; set; }

    
    
    
    private AttackParameters(ProjectileAttackParameters value)
    {
        Value = value;
    }

	private AttackParameters(BeamAttackParameters value)
    {
        Value = value;
    }

	private AttackParameters(StreamAttackParameters value)
    {
        Value = value;
    }

    public static implicit operator AttackParameters(ProjectileAttackParameters value) => new(value);

	public static implicit operator AttackParameters(BeamAttackParameters value) => new(value);

	public static implicit operator AttackParameters(StreamAttackParameters value) => new(value);

    
}
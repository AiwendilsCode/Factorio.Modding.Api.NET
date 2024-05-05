using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("ProjectileAttackParameters")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class ProjectileAttackParameters : BaseAttackParameters
{
    [InLua("projectile_center")]
    public Vector? ProjectileCenter { get; set; }
	[InLua("projectile_creation_distance")]
    public float? ProjectileCreationDistance { get; set; }
	[InLua("projectile_creation_parameters")]
    public CircularProjectileCreationSpecification? ProjectileCreationParameters { get; set; }
	[InLua("projectile_orientation_offset")]
    public float? ProjectileOrientationOffset { get; set; }
	[InLua("shell_particle")]
    public CircularParticleCreationSpecification? ShellParticle { get; set; }
	[InLua("type")]
    public string Type { get; } = "projectile";

    
    
    
    

    

    
}
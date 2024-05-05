using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("StreamAttackParameters")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class StreamAttackParameters : BaseAttackParameters
{
    [InLua("fluid_consumption")]
    public float? FluidConsumption { get; set; }
	[InLua("fluids")]
    public StreamFluidProperties[]? Fluids { get; set; }
	[InLua("gun_barrel_length")]
    public float? GunBarrelLength { get; set; }
	[InLua("gun_center_shift")]
    public OneOf<Vector, GunShift4Way>? GunCenterShift { get; set; }
	[InLua("projectile_creation_parameters")]
    public CircularProjectileCreationSpecification? ProjectileCreationParameters { get; set; }
	[InLua("type")]
    public string Type { get; } = "stream";

    
    
    
    

    

    
}
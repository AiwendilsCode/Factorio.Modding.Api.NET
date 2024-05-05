using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("KillAchievementPrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class KillAchievementPrototype : AchievementPrototype
{
    [InLua("amount")]
    public uint? Amount { get; set; }
	[InLua("damage_type")]
    public DamageTypeID? DamageType { get; set; }
	[InLua("in_vehicle")]
    public bool? InVehicle { get; set; }
	[InLua("personally")]
    public bool? Personally { get; set; }
	[InLua("to_kill")]
    public EntityID? ToKill { get; set; }
	[InLua("type_to_kill")]
    public string? TypeToKill { get; set; }

    
    
    
    

    

    
}
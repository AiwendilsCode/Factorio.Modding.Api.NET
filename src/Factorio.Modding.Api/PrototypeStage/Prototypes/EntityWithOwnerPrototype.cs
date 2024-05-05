using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("EntityWithOwnerPrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class EntityWithOwnerPrototype : EntityWithHealthPrototype
{
    [InLua("allow_run_time_change_of_is_military_target")]
    public bool? AllowRunTimeChangeOfIsMilitaryTarget { get; set; }
	[InLua("is_military_target")]
    public bool? IsMilitaryTarget { get; set; }

    
    
    
    

    

    
}
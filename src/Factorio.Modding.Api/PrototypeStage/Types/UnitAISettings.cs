using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("UnitAISettings")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class UnitAISettings 
{
    [InLua("allow_try_return_to_spawner")]
    public bool? AllowTryReturnToSpawner { get; set; }
	[InLua("destroy_when_commands_fail")]
    public bool? DestroyWhenCommandsFail { get; set; }
	[InLua("do_separation")]
    public bool? DoSeparation { get; set; }
	[InLua("path_resolution_modifier")]
    public sbyte? PathResolutionModifier { get; set; }

    
    
    
    

    

    
}
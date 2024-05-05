using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("CharacterArmorAnimation")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class CharacterArmorAnimation 
{
    [InLua("armors")]
    public ItemID[]? Armors { get; set; }
	[InLua("flipped_shadow_running_with_gun")]
    public RotatedAnimation? FlippedShadowRunningWithGun { get; set; }
	[InLua("idle")]
    public RotatedAnimation Idle { get; set; }
	[InLua("idle_with_gun")]
    public RotatedAnimation IdleWithGun { get; set; }
	[InLua("mining_with_tool")]
    public RotatedAnimation MiningWithTool { get; set; }
	[InLua("running")]
    public RotatedAnimation Running { get; set; }
	[InLua("running_with_gun")]
    public RotatedAnimation RunningWithGun { get; set; }

    
    
    
    

    

    
}
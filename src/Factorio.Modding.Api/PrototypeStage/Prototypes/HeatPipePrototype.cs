using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("HeatPipePrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class HeatPipePrototype : EntityWithOwnerPrototype
{
    [InLua("collision_mask")]
    public CollisionMask? CollisionMask { get; set; }
	[InLua("connection_sprites")]
    public ConnectableEntityGraphics ConnectionSprites { get; set; }
	[InLua("heat_buffer")]
    public HeatBuffer HeatBuffer { get; set; }
	[InLua("heat_glow_sprites")]
    public ConnectableEntityGraphics HeatGlowSprites { get; set; }

    
    
    
    

    

    
}
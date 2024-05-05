using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("UndergroundBeltPrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class UndergroundBeltPrototype : TransportBeltConnectablePrototype
{
    [InLua("collision_mask")]
    public CollisionMask? CollisionMask { get; set; }
	[InLua("max_distance")]
    public byte MaxDistance { get; set; }
	[InLua("structure")]
    public UndergroundBeltStructure Structure { get; set; }
	[InLua("underground_remove_belts_sprite")]
    public Sprite? UndergroundRemoveBeltsSprite { get; set; }
	[InLua("underground_sprite")]
    public Sprite UndergroundSprite { get; set; }

    
    
    
    

    

    
}
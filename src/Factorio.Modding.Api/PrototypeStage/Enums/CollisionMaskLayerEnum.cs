using Factorio.Modding.Api.Attributes;
using System.CodeDom.Compiler;

namespace Factorio.Modding.Api.PrototypeStage.Enums;
                    

[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Builders.CSharpClassBuilder", "unknown")]
public enum CollisionMaskLayerEnum
{
    [InLua("ground-tile")]
    GroundTile,
	[InLua("water-tile")]
    WaterTile,
	[InLua("resource-layer")]
    ResourceLayer,
	[InLua("doodad-layer")]
    DoodadLayer,
	[InLua("floor-layer")]
    FloorLayer,
	[InLua("item-layer")]
    ItemLayer,
	[InLua("ghost-layer")]
    GhostLayer,
	[InLua("object-layer")]
    ObjectLayer,
	[InLua("player-layer")]
    PlayerLayer,
	[InLua("train-layer")]
    TrainLayer,
	[InLua("rail-layer")]
    RailLayer,
	[InLua("transport-belt-layer")]
    TransportBeltLayer
}
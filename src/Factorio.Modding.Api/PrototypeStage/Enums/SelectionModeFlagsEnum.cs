using Factorio.Modding.Api.Attributes;
using System.CodeDom.Compiler;

namespace Factorio.Modding.Api.PrototypeStage.Enums;
                    

[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Builders.CSharpClassBuilder", "unknown")]
public enum SelectionModeFlagsEnum
{
    [InLua("blueprint")]
    Blueprint,
	[InLua("deconstruct")]
    Deconstruct,
	[InLua("cancel-deconstruct")]
    CancelDeconstruct,
	[InLua("items")]
    Items,
	[InLua("trees")]
    Trees,
	[InLua("buildable-type")]
    BuildableType,
	[InLua("nothing")]
    Nothing,
	[InLua("items-to-place")]
    ItemsToPlace,
	[InLua("any-entity")]
    AnyEntity,
	[InLua("any-tile")]
    AnyTile,
	[InLua("same-force")]
    SameForce,
	[InLua("not-same-force")]
    NotSameForce,
	[InLua("friend")]
    Friend,
	[InLua("enemy")]
    Enemy,
	[InLua("upgrade")]
    Upgrade,
	[InLua("cancel-upgrade")]
    CancelUpgrade,
	[InLua("downgrade")]
    Downgrade,
	[InLua("entity-with-health")]
    EntityWithHealth,
	[InLua("entity-with-force")]
    EntityWithForce,
	[InLua("is-military-target")]
    IsMilitaryTarget,
	[InLua("entity-with-owner")]
    EntityWithOwner,
	[InLua("avoid-rolling-stock")]
    AvoidRollingStock,
	[InLua("entity-ghost")]
    EntityGhost,
	[InLua("tile-ghost")]
    TileGhost
}
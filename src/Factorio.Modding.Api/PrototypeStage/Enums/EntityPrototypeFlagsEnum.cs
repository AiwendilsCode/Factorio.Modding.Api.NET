using Factorio.Modding.Api.Attributes;
using System.CodeDom.Compiler;

namespace Factorio.Modding.Api.PrototypeStage.Enums;
                    

[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Builders.CSharpClassBuilder", "unknown")]
public enum EntityPrototypeFlagsEnum
{
    [InLua("not-rotatable")]
    NotRotatable,
	[InLua("placeable-neutral")]
    PlaceableNeutral,
	[InLua("placeable-player")]
    PlaceablePlayer,
	[InLua("placeable-enemy")]
    PlaceableEnemy,
	[InLua("placeable-off-grid")]
    PlaceableOffGrid,
	[InLua("player-creation")]
    PlayerCreation,
	[InLua("building-direction-8-way")]
    BuildingDirection8Way,
	[InLua("filter-directions")]
    FilterDirections,
	[InLua("fast-replaceable-no-build-while-moving")]
    FastReplaceableNoBuildWhileMoving,
	[InLua("breaths-air")]
    BreathsAir,
	[InLua("not-repairable")]
    NotRepairable,
	[InLua("not-on-map")]
    NotOnMap,
	[InLua("not-deconstructable")]
    NotDeconstructable,
	[InLua("not-blueprintable")]
    NotBlueprintable,
	[InLua("hidden")]
    Hidden,
	[InLua("hide-alt-info")]
    HideAltInfo,
	[InLua("fast-replaceable-no-cross-type-while-moving")]
    FastReplaceableNoCrossTypeWhileMoving,
	[InLua("no-gap-fill-while-building")]
    NoGapFillWhileBuilding,
	[InLua("not-flammable")]
    NotFlammable,
	[InLua("no-automated-item-removal")]
    NoAutomatedItemRemoval,
	[InLua("no-automated-item-insertion")]
    NoAutomatedItemInsertion,
	[InLua("no-copy-paste")]
    NoCopyPaste,
	[InLua("not-selectable-in-game")]
    NotSelectableInGame,
	[InLua("not-upgradable")]
    NotUpgradable,
	[InLua("not-in-kill-statistics")]
    NotInKillStatistics,
	[InLua("not-in-made-in")]
    NotInMadeIn
}
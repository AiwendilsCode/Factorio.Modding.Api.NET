using Factorio.Modding.Api.Attributes;
using System.CodeDom.Compiler;

namespace Factorio.Modding.Api.PrototypeStage.Enums;
                    

[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Builders.CSharpClassBuilder", "unknown")]
public enum ItemPrototypeFlagsEnum
{
    [InLua("draw-logistic-overlay")]
    DrawLogisticOverlay,
	[InLua("hidden")]
    Hidden,
	[InLua("always-show")]
    AlwaysShow,
	[InLua("hide-from-bonus-gui")]
    HideFromBonusGui,
	[InLua("hide-from-fuel-tooltip")]
    HideFromFuelTooltip,
	[InLua("not-stackable")]
    NotStackable,
	[InLua("can-extend-inventory")]
    CanExtendInventory,
	[InLua("primary-place-result")]
    PrimaryPlaceResult,
	[InLua("mod-openable")]
    ModOpenable,
	[InLua("only-in-cursor")]
    OnlyInCursor,
	[InLua("spawnable")]
    Spawnable
}
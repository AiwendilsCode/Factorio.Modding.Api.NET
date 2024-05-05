using Factorio.Modding.Api.Attributes;
using System.CodeDom.Compiler;

namespace Factorio.Modding.Api.PrototypeStage.Enums;
                    

[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Builders.CSharpClassBuilder", "unknown")]
public enum ActionEnum
{
    [InLua("toggle-alt-mode")]
    ToggleAltMode,
	[InLua("undo")]
    Undo,
	[InLua("copy")]
    Copy,
	[InLua("cut")]
    Cut,
	[InLua("paste")]
    Paste,
	[InLua("import-string")]
    ImportString,
	[InLua("toggle-personal-roboport")]
    TogglePersonalRoboport,
	[InLua("toggle-equipment-movement-bonus")]
    ToggleEquipmentMovementBonus,
	[InLua("spawn-item")]
    SpawnItem,
	[InLua("lua")]
    Lua
}
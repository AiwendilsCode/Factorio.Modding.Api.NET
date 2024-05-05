using Factorio.Modding.Api.Attributes;
using System.CodeDom.Compiler;

namespace Factorio.Modding.Api.PrototypeStage.Enums;
                    

[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Builders.CSharpClassBuilder", "unknown")]
public enum SpriteFlagsEnum
{
    [InLua("no-crop")]
    NoCrop,
	[InLua("not-compressed")]
    NotCompressed,
	[InLua("always-compressed")]
    AlwaysCompressed,
	[InLua("mipmap")]
    Mipmap,
	[InLua("linear-minification")]
    LinearMinification,
	[InLua("linear-magnification")]
    LinearMagnification,
	[InLua("linear-mip-level")]
    LinearMipLevel,
	[InLua("alpha-mask")]
    AlphaMask,
	[InLua("no-scale")]
    NoScale,
	[InLua("mask")]
    Mask,
	[InLua("icon")]
    Icon,
	[InLua("gui")]
    Gui,
	[InLua("gui-icon")]
    GuiIcon,
	[InLua("light")]
    Light,
	[InLua("terrain")]
    Terrain,
	[InLua("terrain-effect-map")]
    TerrainEffectMap,
	[InLua("shadow")]
    Shadow,
	[InLua("smoke")]
    Smoke,
	[InLua("decal")]
    Decal,
	[InLua("low-object")]
    LowObject,
	[InLua("trilinear-filtering")]
    TrilinearFiltering,
	[InLua("group=none")]
    GroupNone,
	[InLua("group=terrain")]
    GroupTerrain,
	[InLua("group=shadow")]
    GroupShadow,
	[InLua("group=smoke")]
    GroupSmoke,
	[InLua("group=decal")]
    GroupDecal,
	[InLua("group=low-object")]
    GroupLowObject,
	[InLua("group=gui")]
    GroupGui,
	[InLua("group=icon")]
    GroupIcon,
	[InLua("group=icon-background")]
    GroupIconBackground,
	[InLua("compressed")]
    Compressed
}
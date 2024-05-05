using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("AchievementPrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class AchievementPrototype : PrototypeBase
{
    [InLua("allowed_without_fight")]
    public bool? AllowedWithoutFight { get; set; }
	[InLua("hidden")]
    public bool? Hidden { get; set; }
	[InLua("icon")]
    public FileName? Icon { get; set; }
	[InLua("icon_mipmaps")]
    public IconMipMapType? IconMipmaps { get; set; }
	[InLua("icon_size")]
    public SpriteSizeType? IconSize { get; set; }
	[InLua("icons")]
    public IconData[]? Icons { get; set; }
	[InLua("steam_stats_name")]
    public string? SteamStatsName { get; set; }

    
    
    
    

    

    
}
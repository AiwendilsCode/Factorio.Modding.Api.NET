using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("TileTransitionSprite")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class TileTransitionSprite 
{
    [InLua("count")]
    public uint Count { get; set; }
	[InLua("hr_version")]
    public TileTransitionSprite? HrVersion { get; set; }
	[InLua("picture")]
    public FileName Picture { get; set; }
	[InLua("scale")]
    public float? Scale { get; set; }
	[InLua("tall")]
    public bool? Tall { get; set; }
	[InLua("x")]
    public SpriteSizeType? X { get; set; }
	[InLua("y")]
    public SpriteSizeType? Y { get; set; }

    
    
    
    

    

    
}
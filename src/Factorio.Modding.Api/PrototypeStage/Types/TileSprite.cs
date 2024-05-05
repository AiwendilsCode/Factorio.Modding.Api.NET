using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("TileSprite")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class TileSprite 
{
    [InLua("count")]
    public uint Count { get; set; }
	[InLua("hr_version")]
    public TileSprite? HrVersion { get; set; }
	[InLua("line_length")]
    public uint? LineLength { get; set; }
	[InLua("picture")]
    public FileName Picture { get; set; }
	[InLua("scale")]
    public float? Scale { get; set; }
	[InLua("x")]
    public SpriteSizeType? X { get; set; }
	[InLua("y")]
    public SpriteSizeType? Y { get; set; }

    
    
    
    

    

    
}
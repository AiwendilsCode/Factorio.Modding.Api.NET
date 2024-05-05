using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("Sprite")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class Sprite : SpriteParameters
{
    [InLua("filename")]
    public FileName? Filename { get; set; }
	[InLua("hr_version")]
    public Sprite? HrVersion { get; set; }
	[InLua("layers")]
    public Sprite[]? Layers { get; set; }
	[InLua("slice")]
    public SpriteSizeType? Slice { get; set; }
	[InLua("slice_x")]
    public SpriteSizeType? SliceX { get; set; }
	[InLua("slice_y")]
    public SpriteSizeType? SliceY { get; set; }

    
    
    
    

    

    
}
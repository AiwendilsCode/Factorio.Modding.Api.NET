using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("RotatedSprite")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class RotatedSprite : SpriteParameters
{
    [InLua("allow_low_quality_rotation")]
    public bool? AllowLowQualityRotation { get; set; }
	[InLua("apply_projection")]
    public bool? ApplyProjection { get; set; }
	[InLua("axially_symmetrical")]
    public bool? AxiallySymmetrical { get; set; }
	[InLua("back_equals_front")]
    public bool? BackEqualsFront { get; set; }
	[InLua("counterclockwise")]
    public bool? Counterclockwise { get; set; }
	[InLua("direction_count")]
    public ushort DirectionCount { get; set; }
	[InLua("filename")]
    public FileName? Filename { get; set; }
	[InLua("filenames")]
    public FileName[]? Filenames { get; set; }
	[InLua("generate_sdf")]
    public bool? GenerateSdf { get; set; }
	[InLua("hr_version")]
    public RotatedSprite? HrVersion { get; set; }
	[InLua("layers")]
    public RotatedSprite[]? Layers { get; set; }
	[InLua("line_length")]
    public uint? LineLength { get; set; }
	[InLua("lines_per_file")]
    public ulong? LinesPerFile { get; set; }
	[InLua("slice")]
    public SpriteSizeType? Slice { get; set; }
	[InLua("slice_x")]
    public SpriteSizeType? SliceX { get; set; }
	[InLua("slice_y")]
    public SpriteSizeType? SliceY { get; set; }

    
    
    
    

    

    
}
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("RotatedAnimation")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class RotatedAnimation : AnimationParameters
{
    [InLua("apply_projection")]
    public bool? ApplyProjection { get; set; }
	[InLua("axially_symmetrical")]
    public bool? AxiallySymmetrical { get; set; }
	[InLua("counterclockwise")]
    public bool? Counterclockwise { get; set; }
	[InLua("direction_count")]
    public uint DirectionCount { get; set; }
	[InLua("filename")]
    public FileName? Filename { get; set; }
	[InLua("filenames")]
    public FileName[]? Filenames { get; set; }
	[InLua("hr_version")]
    public RotatedAnimation? HrVersion { get; set; }
	[InLua("layers")]
    public RotatedAnimation[]? Layers { get; set; }
	[InLua("lines_per_file")]
    public uint? LinesPerFile { get; set; }
	[InLua("middle_orientation")]
    public RealOrientation? MiddleOrientation { get; set; }
	[InLua("orientation_range")]
    public float? OrientationRange { get; set; }
	[InLua("slice")]
    public uint? Slice { get; set; }
	[InLua("still_frame")]
    public uint? StillFrame { get; set; }
	[InLua("stripes")]
    public Stripe[]? Stripes { get; set; }

    
    
    
    

    

    
}
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("LightDefinition")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class LightDefinition 
{
    [InLua("add_perspective")]
    public bool? AddPerspective { get; set; }
	[InLua("color")]
    public Color? Color { get; set; }
	[InLua("intensity")]
    public float Intensity { get; set; }
	[InLua("minimum_darkness")]
    public float? MinimumDarkness { get; set; }
	[InLua("picture")]
    public Sprite? Picture { get; set; }
	[InLua("rotation_shift")]
    public RealOrientation? RotationShift { get; set; }
	[InLua("shift")]
    public Vector? Shift { get; set; }
	[InLua("size")]
    public float Size { get; set; }
	[InLua("source_orientation_offset")]
    public RealOrientation? SourceOrientationOffset { get; set; }
	[InLua("type")]
    public TypeEnum? Type { get; set; }
	
    public LightDefinition[]? LightDefinitionArray { get; set; }

    
    
    public LightDefinition() {}
    private LightDefinition(LightDefinition[] value)
    {
        LightDefinitionArray = value;
    }

    public static implicit operator LightDefinition(LightDefinition[] value) => new(value);

    
}
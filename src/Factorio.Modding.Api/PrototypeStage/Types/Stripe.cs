using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("Stripe")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class Stripe 
{
    [InLua("filename")]
    public FileName Filename { get; set; }
	[InLua("height_in_frames")]
    public uint HeightInFrames { get; set; }
	[InLua("width_in_frames")]
    public uint WidthInFrames { get; set; }
	[InLua("x")]
    public uint? X { get; set; }
	[InLua("y")]
    public uint? Y { get; set; }

    
    
    
    

    

    
}
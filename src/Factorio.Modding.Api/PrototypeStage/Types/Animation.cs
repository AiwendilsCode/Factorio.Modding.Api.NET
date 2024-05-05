using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("Animation")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class Animation : AnimationParameters
{
    [InLua("filename")]
    public FileName? Filename { get; set; }
	[InLua("hr_version")]
    public Animation? HrVersion { get; set; }
	[InLua("layers")]
    public Animation[]? Layers { get; set; }
	[InLua("stripes")]
    public Stripe[]? Stripes { get; set; }

    
    
    
    

    

    
}
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("BeamAnimationSet")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class BeamAnimationSet 
{
    [InLua("body")]
    public AnimationVariations? Body { get; set; }
	[InLua("ending")]
    public Animation? Ending { get; set; }
	[InLua("head")]
    public Animation? Head { get; set; }
	[InLua("start")]
    public Animation? Start { get; set; }
	[InLua("tail")]
    public Animation? Tail { get; set; }

    
    
    
    

    

    
}
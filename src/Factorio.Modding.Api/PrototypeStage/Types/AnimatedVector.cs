using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("AnimatedVector")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class AnimatedVector 
{
    [InLua("direction_shift")]
    public DirectionShift? DirectionShift { get; set; }
	[InLua("render_layer")]
    public RenderLayer? RenderLayer { get; set; }
	[InLua("rotations")]
    public VectorRotation[] Rotations { get; set; }

    
    
    
    

    

    
}
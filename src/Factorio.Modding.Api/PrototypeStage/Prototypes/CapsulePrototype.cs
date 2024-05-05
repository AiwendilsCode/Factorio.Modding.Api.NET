using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("CapsulePrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class CapsulePrototype : ItemPrototype
{
    [InLua("capsule_action")]
    public CapsuleAction CapsuleAction { get; set; }
	[InLua("radius_color")]
    public Color? RadiusColor { get; set; }

    
    
    
    

    

    
}
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("Effect")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class Effect 
{
    [InLua("consumption")]
    public EffectValue? Consumption { get; set; }
	[InLua("pollution")]
    public EffectValue? Pollution { get; set; }
	[InLua("productivity")]
    public EffectValue? Productivity { get; set; }
	[InLua("speed")]
    public EffectValue? Speed { get; set; }

    
    
    
    

    

    
}
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("StreamFluidProperties")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class StreamFluidProperties 
{
    [InLua("damage_modifier")]
    public double? DamageModifier { get; set; }
	[InLua("type")]
    public FluidID Type { get; set; }

    
    
    
    

    

    
}
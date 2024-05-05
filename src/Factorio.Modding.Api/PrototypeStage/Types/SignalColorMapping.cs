using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("SignalColorMapping")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class SignalColorMapping 
{
    [InLua("color")]
    public Color Color { get; set; }
	[InLua("name")]
    public OneOf<VirtualSignalID, ItemID, FluidID> Name { get; set; }
	[InLua("type")]
    public TypeEnum Type { get; set; }

    
    
    
    

    

    
}
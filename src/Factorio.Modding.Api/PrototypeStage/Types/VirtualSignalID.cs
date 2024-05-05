using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("VirtualSignalID")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class VirtualSignalID 
{
    
    public string Value { get; set; }

    
    
    
    private VirtualSignalID(string value)
    {
        Value = value;
    }

    public static implicit operator VirtualSignalID(string value) => new(value);

    
}
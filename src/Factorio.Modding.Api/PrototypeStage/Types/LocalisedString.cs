using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("LocalisedString")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class LocalisedString 
{
    
    public OneOf<string, double, bool, LocalisedString[]> Value { get; set; }

    
    
    
    public LocalisedString(OneOf<string, double, bool, LocalisedString[]> value)
    {
        Value = value;
    }

    public static implicit operator LocalisedString(string value) => new(value);

	public static implicit operator LocalisedString(double value) => new(value);

	public static implicit operator LocalisedString(bool value) => new(value);

	public static implicit operator LocalisedString(LocalisedString[] value) => new(value);

    
}
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("SelectionModeFlags")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class SelectionModeFlags 
{
    
    public OneOf<SelectionModeFlagsEnum, SelectionModeFlagsEnum[]> Value { get; set; }

    
    
    
    private SelectionModeFlags(SelectionModeFlagsEnum value)
    {
        Value = value;
    }

	private SelectionModeFlags(SelectionModeFlagsEnum[] value)
    {
        Value = value;
    }

    public static implicit operator SelectionModeFlags(SelectionModeFlagsEnum value) => new(value);

	public static implicit operator SelectionModeFlags(SelectionModeFlagsEnum[] value) => new(value);

    
}
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("CursorBoxType")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class CursorBoxType 
{
    
    public CursorBoxTypeEnum Value { get; set; }

    
    
    
    private CursorBoxType(CursorBoxTypeEnum value)
    {
        Value = value;
    }

    public static implicit operator CursorBoxType(CursorBoxTypeEnum value) => new(value);

    
}
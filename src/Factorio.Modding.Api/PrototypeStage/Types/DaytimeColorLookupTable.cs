using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("DaytimeColorLookupTable")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class DaytimeColorLookupTable 
{
    
    public (double, StringOr<FileName>)[] Value { get; set; }

    
    
    
    private DaytimeColorLookupTable((double, StringOr<FileName>)[] value)
    {
        Value = value;
    }

    public static implicit operator DaytimeColorLookupTable((double, StringOr<FileName>)[] value) => new(value);

    
}
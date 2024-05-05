using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("DamageTypeFilters")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class DamageTypeFilters 
{
    [InLua("types")]
    public OneOf<DamageTypeID, DamageTypeID[]> Types { get; set; }
	[InLua("whitelist")]
    public bool? Whitelist { get; set; }

    
    
    public DamageTypeFilters() {}
    private DamageTypeFilters(DamageTypeID value)
    {
        Types = value;
    }

	private DamageTypeFilters(DamageTypeID[] value)
    {
        Types = value;
    }

    public static implicit operator DamageTypeFilters(DamageTypeID value) => new(value);

	public static implicit operator DamageTypeFilters(DamageTypeID[] value) => new(value);

    
}
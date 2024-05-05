using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
using Factorio.Modding.Api.Common.Extensions;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("TechnologyData")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class TechnologyData 
{
    [InLua("effects")]
    public Modifier[]? Effects { get; set; }
	[InLua("enabled")]
    public bool? Enabled { get; set; }
	[InLua("hidden")]
    public bool? Hidden { get; set; }
	[InLua("ignore_tech_cost_multiplier")]
    public bool? IgnoreTechCostMultiplier { get; set; }
	[InLua("max_level")]
    public StringOr<uint>? MaxLevel {
                get
                {
                    return _maxLevel;
                }
                        
                set
                {
                    if (value is null)
                                    _maxLevel = new StringOr<uint>("infinite", default);
                                else
                                    _maxLevel = new StringOr<uint>("infinite", value.Value.GetAs<uint>());
                }
            }
	[InLua("prerequisites")]
    public TechnologyID[]? Prerequisites { get; set; }
	[InLua("unit")]
    public TechnologyUnit Unit { get; set; }
	[InLua("upgrade")]
    public bool? Upgrade { get; set; }
	[InLua("visible_when_disabled")]
    public bool? VisibleWhenDisabled { get; set; }

    private StringOr<uint>? _maxLevel ;
    
    
    

    

    
}
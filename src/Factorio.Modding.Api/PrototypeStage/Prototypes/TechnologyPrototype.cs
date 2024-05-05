using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
using Factorio.Modding.Api.Common.Extensions;
using Factorio.Modding.Api.Common.Extensions;
using Factorio.Modding.Api.Common.Extensions;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("TechnologyPrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class TechnologyPrototype : PrototypeBase
{
    [InLua("effects")]
    public Modifier[]? Effects { get; set; }
	[InLua("enabled")]
    public bool? Enabled { get; set; }
	[InLua("expensive")]
    public BoolOr<TechnologyData>? Expensive {
                get
                {
                    return _expensive;
                }
                        
                set
                {
                    if (value is null)
                                    _expensive = new BoolOr<TechnologyData>(false, default);
                                else
                                    _expensive = new BoolOr<TechnologyData>(false, value.Value.GetAs<TechnologyData>());
                }
            }
	[InLua("hidden")]
    public bool? Hidden { get; set; }
	[InLua("icon")]
    public FileName? Icon { get; set; }
	[InLua("icon_mipmaps")]
    public IconMipMapType? IconMipmaps { get; set; }
	[InLua("icon_size")]
    public SpriteSizeType? IconSize { get; set; }
	[InLua("icons")]
    public IconData[]? Icons { get; set; }
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
	[InLua("name")]
    public string Name { get; set; }
	[InLua("normal")]
    public BoolOr<TechnologyData>? Normal {
                get
                {
                    return _normal;
                }
                        
                set
                {
                    if (value is null)
                                    _normal = new BoolOr<TechnologyData>(false, default);
                                else
                                    _normal = new BoolOr<TechnologyData>(false, value.Value.GetAs<TechnologyData>());
                }
            }
	[InLua("prerequisites")]
    public TechnologyID[]? Prerequisites { get; set; }
	[InLua("unit")]
    public TechnologyUnit? Unit { get; set; }
	[InLua("upgrade")]
    public bool? Upgrade { get; set; }
	[InLua("visible_when_disabled")]
    public bool? VisibleWhenDisabled { get; set; }

    private BoolOr<TechnologyData>? _expensive ;
	private StringOr<uint>? _maxLevel ;
	private BoolOr<TechnologyData>? _normal ;
    
    
    

    

    
}
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("TriggerEffectItem")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class TriggerEffectItem 
{
    [InLua("affects_target")]
    public bool? AffectsTarget { get; set; }
	[InLua("damage_type_filters")]
    public DamageTypeFilters? DamageTypeFilters { get; set; }
	[InLua("probability")]
    public float? Probability { get; set; }
	[InLua("repeat_count")]
    public ushort? RepeatCount { get; set; }
	[InLua("repeat_count_deviation")]
    public ushort? RepeatCountDeviation { get; set; }
	[InLua("show_in_tooltip")]
    public bool? ShowInTooltip { get; set; }

    
    
    
    

    

    
}
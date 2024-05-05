using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("ModuleSpecification")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class ModuleSpecification 
{
    [InLua("module_info_icon_scale")]
    public float? ModuleInfoIconScale { get; set; }
	[InLua("module_info_icon_shift")]
    public Vector? ModuleInfoIconShift { get; set; }
	[InLua("module_info_max_icon_rows")]
    public byte? ModuleInfoMaxIconRows { get; set; }
	[InLua("module_info_max_icons_per_row")]
    public byte? ModuleInfoMaxIconsPerRow { get; set; }
	[InLua("module_info_multi_row_initial_height_modifier")]
    public float? ModuleInfoMultiRowInitialHeightModifier { get; set; }
	[InLua("module_info_separation_multiplier")]
    public float? ModuleInfoSeparationMultiplier { get; set; }
	[InLua("module_slots")]
    public ItemStackIndex? ModuleSlots { get; set; }

    
    
    
    

    

    
}
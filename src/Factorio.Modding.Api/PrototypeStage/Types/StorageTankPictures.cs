using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("StorageTankPictures")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class StorageTankPictures 
{
    [InLua("flow_sprite")]
    public Sprite FlowSprite { get; set; }
	[InLua("fluid_background")]
    public Sprite FluidBackground { get; set; }
	[InLua("gas_flow")]
    public Animation GasFlow { get; set; }
	[InLua("picture")]
    public Sprite4Way Picture { get; set; }
	[InLua("window_background")]
    public Sprite WindowBackground { get; set; }

    
    
    
    

    

    
}
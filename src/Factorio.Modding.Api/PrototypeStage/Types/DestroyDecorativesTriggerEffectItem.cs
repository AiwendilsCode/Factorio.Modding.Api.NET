using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("DestroyDecorativesTriggerEffectItem")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class DestroyDecorativesTriggerEffectItem : TriggerEffectItem
{
    [InLua("decoratives_with_trigger_only")]
    public bool? DecorativesWithTriggerOnly { get; set; }
	[InLua("from_render_layer")]
    public RenderLayer? FromRenderLayer { get; set; }
	[InLua("include_decals")]
    public bool? IncludeDecals { get; set; }
	[InLua("include_soft_decoratives")]
    public bool? IncludeSoftDecoratives { get; set; }
	[InLua("invoke_decorative_trigger")]
    public bool? InvokeDecorativeTrigger { get; set; }
	[InLua("radius")]
    public float Radius { get; set; }
	[InLua("to_render_layer")]
    public RenderLayer? ToRenderLayer { get; set; }
	[InLua("type")]
    public string Type { get; } = "destroy-decoratives";

    
    
    
    

    

    
}
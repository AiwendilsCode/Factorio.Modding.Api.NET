using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("ItemWithLabelPrototype")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class ItemWithLabelPrototype : ItemPrototype
{
    [InLua("default_label_color")]
    public Color? DefaultLabelColor { get; set; }
	[InLua("draw_label_for_cursor_render")]
    public bool? DrawLabelForCursorRender { get; set; }

    
    
    
    

    

    
}
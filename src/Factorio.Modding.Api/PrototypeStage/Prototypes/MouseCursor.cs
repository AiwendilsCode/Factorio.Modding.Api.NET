using Factorio.Modding.Api.PrototypeStage.Types;
using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Prototypes;
                    
[InLua("MouseCursor")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class MouseCursor 
{
    [InLua("filename")]
    public FileName? Filename { get; set; }
	[InLua("hot_pixel_x")]
    public short? HotPixelX { get; set; }
	[InLua("hot_pixel_y")]
    public short? HotPixelY { get; set; }
	[InLua("name")]
    public string Name { get; set; }
	[InLua("system_cursor")]
    public SystemCursorEnum? SystemCursor { get; set; }
	[InLua("type")]
    public string Type { get; } = "mouse-cursor";

    
    
    
    

    

    
}
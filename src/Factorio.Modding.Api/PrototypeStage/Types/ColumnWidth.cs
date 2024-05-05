using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("ColumnWidth")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class ColumnWidth 
{
    [InLua("column")]
    public uint Column { get; set; }
	[InLua("maximal_width")]
    public int? MaximalWidth { get; set; }
	[InLua("minimal_width")]
    public int? MinimalWidth { get; set; }
	[InLua("width")]
    public int? Width { get; set; }

    
    
    
    

    

    
}
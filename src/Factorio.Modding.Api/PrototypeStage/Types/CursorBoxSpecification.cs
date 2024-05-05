using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("CursorBoxSpecification")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class CursorBoxSpecification 
{
    [InLua("blueprint_snap_rectangle")]
    public BoxSpecification[] BlueprintSnapRectangle { get; set; }
	[InLua("copy")]
    public BoxSpecification[] Copy { get; set; }
	[InLua("electricity")]
    public BoxSpecification[] Electricity { get; set; }
	[InLua("logistics")]
    public BoxSpecification[] Logistics { get; set; }
	[InLua("not_allowed")]
    public BoxSpecification[] NotAllowed { get; set; }
	[InLua("pair")]
    public BoxSpecification[] Pair { get; set; }
	[InLua("regular")]
    public BoxSpecification[] Regular { get; set; }
	[InLua("train_visualization")]
    public BoxSpecification[] TrainVisualization { get; set; }

    
    
    
    

    

    
}
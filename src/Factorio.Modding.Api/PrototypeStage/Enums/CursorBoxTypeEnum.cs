using Factorio.Modding.Api.Attributes;
using System.CodeDom.Compiler;

namespace Factorio.Modding.Api.PrototypeStage.Enums;
                    

[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Builders.CSharpClassBuilder", "unknown")]
public enum CursorBoxTypeEnum
{
    [InLua("entity")]
    Entity,
	[InLua("electricity")]
    Electricity,
	[InLua("copy")]
    Copy,
	[InLua("not-allowed")]
    NotAllowed,
	[InLua("pair")]
    Pair,
	[InLua("logistics")]
    Logistics,
	[InLua("train-visualization")]
    TrainVisualization,
	[InLua("blueprint-snap-rectangle")]
    BlueprintSnapRectangle
}
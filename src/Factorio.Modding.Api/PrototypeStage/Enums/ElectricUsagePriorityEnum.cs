using Factorio.Modding.Api.Attributes;
using System.CodeDom.Compiler;

namespace Factorio.Modding.Api.PrototypeStage.Enums;
                    

[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Builders.CSharpClassBuilder", "unknown")]
public enum ElectricUsagePriorityEnum
{
    [InLua("primary-input")]
    PrimaryInput,
	[InLua("primary-output")]
    PrimaryOutput,
	[InLua("secondary-input")]
    SecondaryInput,
	[InLua("secondary-output")]
    SecondaryOutput,
	[InLua("tertiary")]
    Tertiary,
	[InLua("solar")]
    Solar,
	[InLua("lamp")]
    Lamp
}
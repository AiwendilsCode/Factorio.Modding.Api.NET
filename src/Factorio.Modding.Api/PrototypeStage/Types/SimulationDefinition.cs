using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("SimulationDefinition")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class SimulationDefinition 
{
    [InLua("checkboard")]
    public bool? Checkboard { get; set; }
	[InLua("generate_map")]
    public bool? GenerateMap { get; set; }
	[InLua("init")]
    public string? Init { get; set; }
	[InLua("init_file")]
    public FileName? InitFile { get; set; }
	[InLua("init_update_count")]
    public uint? InitUpdateCount { get; set; }
	[InLua("length")]
    public uint? Length { get; set; }
	[InLua("mods")]
    public string[]? Mods { get; set; }
	[InLua("override_volume")]
    public bool? OverrideVolume { get; set; }
	[InLua("save")]
    public FileName? Save { get; set; }
	[InLua("update")]
    public string? Update { get; set; }
	[InLua("update_file")]
    public FileName? UpdateFile { get; set; }
	[InLua("volume_modifier")]
    public float? VolumeModifier { get; set; }

    
    
    
    

    

    
}
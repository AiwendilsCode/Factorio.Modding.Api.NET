using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("PumpConnectorGraphicsAnimation")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class PumpConnectorGraphicsAnimation 
{
    [InLua("connector")]
    public Animation? Connector { get; set; }
	[InLua("connector_shadow")]
    public Animation? ConnectorShadow { get; set; }
	[InLua("standup_base")]
    public Animation? StandupBase { get; set; }
	[InLua("standup_shadow")]
    public Animation? StandupShadow { get; set; }
	[InLua("standup_top")]
    public Animation? StandupTop { get; set; }

    
    
    
    

    

    
}
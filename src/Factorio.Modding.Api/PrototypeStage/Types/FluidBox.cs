using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("FluidBox")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class FluidBox 
{
    [InLua("base_area")]
    public double? BaseArea { get; set; }
	[InLua("base_level")]
    public float? BaseLevel { get; set; }
	[InLua("filter")]
    public FluidID? Filter { get; set; }
	[InLua("height")]
    public double? Height { get; set; }
	[InLua("hide_connection_info")]
    public bool? HideConnectionInfo { get; set; }
	[InLua("maximum_temperature")]
    public double? MaximumTemperature { get; set; }
	[InLua("minimum_temperature")]
    public double? MinimumTemperature { get; set; }
	[InLua("pipe_connections")]
    public PipeConnectionDefinition[] PipeConnections { get; set; }
	[InLua("pipe_covers")]
    public Sprite4Way? PipeCovers { get; set; }
	[InLua("pipe_picture")]
    public Sprite4Way? PipePicture { get; set; }
	[InLua("production_type")]
    public ProductionType? ProductionType { get; set; }
	[InLua("render_layer")]
    public RenderLayer? RenderLayer { get; set; }
	[InLua("secondary_draw_order")]
    public sbyte? SecondaryDrawOrder { get; set; }
	[InLua("secondary_draw_orders")]
    public FluidBoxSecondaryDrawOrders? SecondaryDrawOrders { get; set; }

    
    
    
    

    

    
}
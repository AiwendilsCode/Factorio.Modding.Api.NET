using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("TransportBeltConnectorFrame")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class TransportBeltConnectorFrame 
{
    [InLua("frame_back_patch")]
    public SpriteVariations? FrameBackPatch { get; set; }
	[InLua("frame_front_patch")]
    public SpriteVariations? FrameFrontPatch { get; set; }
	[InLua("frame_main")]
    public AnimationVariations FrameMain { get; set; }
	[InLua("frame_main_scanner")]
    public Animation FrameMainScanner { get; set; }
	[InLua("frame_main_scanner_cross_horizontal_end_shift")]
    public Vector FrameMainScannerCrossHorizontalEndShift { get; set; }
	[InLua("frame_main_scanner_cross_horizontal_rotation")]
    public RealOrientation FrameMainScannerCrossHorizontalRotation { get; set; }
	[InLua("frame_main_scanner_cross_horizontal_start_shift")]
    public Vector FrameMainScannerCrossHorizontalStartShift { get; set; }
	[InLua("frame_main_scanner_cross_horizontal_y_scale")]
    public float FrameMainScannerCrossHorizontalYScale { get; set; }
	[InLua("frame_main_scanner_cross_vertical_end_shift")]
    public Vector FrameMainScannerCrossVerticalEndShift { get; set; }
	[InLua("frame_main_scanner_cross_vertical_rotation")]
    public RealOrientation FrameMainScannerCrossVerticalRotation { get; set; }
	[InLua("frame_main_scanner_cross_vertical_start_shift")]
    public Vector FrameMainScannerCrossVerticalStartShift { get; set; }
	[InLua("frame_main_scanner_cross_vertical_y_scale")]
    public float FrameMainScannerCrossVerticalYScale { get; set; }
	[InLua("frame_main_scanner_horizontal_end_shift")]
    public Vector FrameMainScannerHorizontalEndShift { get; set; }
	[InLua("frame_main_scanner_horizontal_rotation")]
    public RealOrientation FrameMainScannerHorizontalRotation { get; set; }
	[InLua("frame_main_scanner_horizontal_start_shift")]
    public Vector FrameMainScannerHorizontalStartShift { get; set; }
	[InLua("frame_main_scanner_horizontal_y_scale")]
    public float FrameMainScannerHorizontalYScale { get; set; }
	[InLua("frame_main_scanner_movement_speed")]
    public float FrameMainScannerMovementSpeed { get; set; }
	[InLua("frame_main_scanner_nw_ne")]
    public Animation FrameMainScannerNwNe { get; set; }
	[InLua("frame_main_scanner_sw_se")]
    public Animation FrameMainScannerSwSe { get; set; }
	[InLua("frame_main_scanner_vertical_end_shift")]
    public Vector FrameMainScannerVerticalEndShift { get; set; }
	[InLua("frame_main_scanner_vertical_rotation")]
    public RealOrientation FrameMainScannerVerticalRotation { get; set; }
	[InLua("frame_main_scanner_vertical_start_shift")]
    public Vector FrameMainScannerVerticalStartShift { get; set; }
	[InLua("frame_main_scanner_vertical_y_scale")]
    public float FrameMainScannerVerticalYScale { get; set; }
	[InLua("frame_shadow")]
    public AnimationVariations FrameShadow { get; set; }

    
    
    
    

    

    
}
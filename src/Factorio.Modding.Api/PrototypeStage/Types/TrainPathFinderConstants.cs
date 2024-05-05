using Factorio.Modding.Api.Attributes;
using Factorio.Modding.Api.OrTypes;
using System.CodeDom.Compiler;
using Factorio.Modding.Api.PrototypeStage.Enums;
using Factorio.Modding.Api.PrototypeStage.Prototypes;
using OneOf;
                    
namespace Factorio.Modding.Api.PrototypeStage.Types;
                    
[InLua("TrainPathFinderConstants")]
[GeneratedCode("Factorio.Modding.Api.CSharpSourceGenerator.Generators.ApiGenerator", "unknown")]
public  class TrainPathFinderConstants 
{
    [InLua("signal_reserved_by_circuit_network_penalty")]
    public uint SignalReservedByCircuitNetworkPenalty { get; set; }
	[InLua("stopped_manually_controlled_train_penalty")]
    public uint StoppedManuallyControlledTrainPenalty { get; set; }
	[InLua("stopped_manually_controlled_train_without_passenger_penalty")]
    public uint StoppedManuallyControlledTrainWithoutPassengerPenalty { get; set; }
	[InLua("train_arriving_to_signal_penalty")]
    public uint TrainArrivingToSignalPenalty { get; set; }
	[InLua("train_arriving_to_station_penalty")]
    public uint TrainArrivingToStationPenalty { get; set; }
	[InLua("train_auto_without_schedule_penalty")]
    public uint TrainAutoWithoutSchedulePenalty { get; set; }
	[InLua("train_in_station_penalty")]
    public uint TrainInStationPenalty { get; set; }
	[InLua("train_in_station_with_no_other_valid_stops_in_schedule")]
    public uint TrainInStationWithNoOtherValidStopsInSchedule { get; set; }
	[InLua("train_stop_penalty")]
    public uint TrainStopPenalty { get; set; }
	[InLua("train_waiting_at_signal_penalty")]
    public uint TrainWaitingAtSignalPenalty { get; set; }
	[InLua("train_waiting_at_signal_tick_multiplier_penalty")]
    public float TrainWaitingAtSignalTickMultiplierPenalty { get; set; }
	[InLua("train_with_no_path_penalty")]
    public uint TrainWithNoPathPenalty { get; set; }

    
    
    
    

    

    
}
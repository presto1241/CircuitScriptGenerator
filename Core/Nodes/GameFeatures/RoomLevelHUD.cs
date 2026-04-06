/*
 * Filename: RoomLevelHUD.cs
 * Category: Game Features
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: HUD elements including progress bars, wheels, and counters. Configure to customize a single element, then enable & modify with existing HUD chips. Can be configured to pull data from Room Progression if Progression is enabled in room settings.
 * Types: 
 * 
 * INPUTS: 
 * 
 *
 * OUTPUTS: 
 * (unnamed) (Room Level HUD)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.GameFeatures;

[Node("0681e9de-2f79-4f6a-9d8a-06140507760c")]
public class RoomLevelHUD : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Room Level HUD";
    public string GetVariableQualifiedName() => "roomLevelHUD";
}
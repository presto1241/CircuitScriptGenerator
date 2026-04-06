/*
 * Filename: GetRoomDetails.cs
 * Category: Destination
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: 
 * Types: 
 * 
 * INPUTS: 
 * Run (exec)
 * Destination Room (Destination Room)
 *
 * OUTPUTS: 
 * Run (exec)
 * Complete (exec)
 * Room Name (string)
 * Room Description (string)
 * Room Image (RecNet Image)
 * Tags (List<string>)
 * Cheers (int)
 * Favorites (int)
 * Unique Visitors (int)
 * Visits (int)
 * Creator Account (Player Account)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Destination;

[Node("8169637f-dd40-4330-95b7-347386370aab")]
public class GetRoomDetails : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Get Room Details";
    public string GetVariableQualifiedName() => "getRoomDetails";
}
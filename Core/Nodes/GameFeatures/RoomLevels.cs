/*
 * Filename: RoomLevels.cs
 * Category: Game Features
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: A specialized data table for use with Room Progression, with some cells and formatting choices reserved. Edit the data table through the configuration menu on this chip. Specify the data type of each column and use Data Table Read Cell to extract the contents for use in circuit graphs. Must save room via Data Table UI to commit changes.
 * Types: 
 * 
 * INPUTS: 
 * Levels (any)
 *
 * OUTPUTS: 
 * 
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.GameFeatures;

[Node("a63f19b0-206f-4079-a5b0-4622619200a1")]
public class RoomLevels : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Room Levels";
    public string GetVariableQualifiedName() => "roomLevels";
}
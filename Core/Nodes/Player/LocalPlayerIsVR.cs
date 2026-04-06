/*
 * Filename: LocalPlayerIsVR.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Check whether the local player is in VR or not.
 * Types: 
 * 
 * INPUTS: 
 * 
 *
 * OUTPUTS: 
 * Is VR (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("f9101f3c-5b1d-4edc-b850-83bd72a4b1d4")]
public class LocalPlayerIsVR : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Local Player Is VR";
    public string GetVariableQualifiedName() => "localPlayerIsVR";
}
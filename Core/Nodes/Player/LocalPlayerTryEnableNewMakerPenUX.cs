/*
 * Filename: LocalPlayerTryEnableNewMakerPenUX.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Enables the new Maker Pen UX for the local player and returns true if possible. Returns false if the UX is not availble on the their platform.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 * Success (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("db7525e5-7d54-4ed1-bec5-0ef58edfef50")]
public class LocalPlayerTryEnableNewMakerPenUX : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Local Player Try Enable New Maker Pen UX";
    public string GetVariableQualifiedName() => "localPlayerTryEnableNewMakerPenUX";
}
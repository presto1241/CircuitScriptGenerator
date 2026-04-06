/*
 * Filename: CostumeGetWearer.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Get Player wearing a costume.
 * Types: 
 * 
 * INPUTS: 
 * Target (Costume)
 *
 * OUTPUTS: 
 * Player (Player)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("f28d1a5e-a08c-471b-89e6-5ee6372d9897")]
public class CostumeGetWearer : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Costume Get Wearer";
    public string GetVariableQualifiedName() => "costumeGetWearer";
}
/*
 * Filename: CostumeUnequip.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Unequip a costume.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (Costume)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 * Player (Player)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("d5070b89-da23-4e4b-848c-07bb22c0420e")]
public class CostumeUnequip : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Costume Unequip";
    public string GetVariableQualifiedName() => "costumeUnequip";
}
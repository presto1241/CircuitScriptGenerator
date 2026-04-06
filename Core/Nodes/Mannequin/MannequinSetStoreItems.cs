/*
 * Filename: MannequinSetStoreItems.cs
 * Category: Mannequin
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: 
 * Types: 
 * 
 * INPUTS: 
 * Run (exec)
 * Mannequin (Mannequin)
 * List<Store Item> (List<Store Item>)
 *
 * OUTPUTS: 
 * Run (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Mannequin;

[Node("06b3ed30-e586-4060-b791-526921903e9e")]
public class MannequinSetStoreItems : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Mannequin Set Store Items";
    public string GetVariableQualifiedName() => "mannequinSetStoreItems";
}
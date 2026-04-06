/*
 * Filename: PlayerAccountVariable.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Stores a single Player Account. Can be synced
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * (unnamed) (Player Account)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 * (unnamed) (Player Account)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("88124d98-7aab-4c63-aedd-5ace090cfd3b")]
public class PlayerAccountVariable : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Player Account Variable";
    public string GetVariableQualifiedName() => "playerAccountVariable";
}
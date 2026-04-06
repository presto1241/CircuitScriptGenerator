/*
 * Filename: GoToState.cs
 * Category: Utilities
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Transitions to the given state in the current state machine.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * State (State)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Utilities;

[Node("ecf53690-1d60-4971-b057-f601d49975ab")]
public class GoToState : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Go To State";
    public string GetVariableQualifiedName() => "goToState";
}
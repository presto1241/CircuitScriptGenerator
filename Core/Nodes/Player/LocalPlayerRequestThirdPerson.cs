/*
 * Filename: LocalPlayerRequestThirdPerson.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Tries to set the local player to third or first person. If Active is true, the local player will be changed to third person. If Active is false, they will be changed to first person. No effect on platforms where third person is unsupported, like VR.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Active (bool)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("039fdbe0-31f2-4743-81ef-aa326b5e410f")]
public class LocalPlayerRequestThirdPerson : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Local Player Request Third Person";
    public string GetVariableQualifiedName() => "localPlayerRequestThirdPerson";
}
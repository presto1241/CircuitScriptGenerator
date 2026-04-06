/*
 * Filename: LocalPlayerSetAnimationParamBalance.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Sets the zero to one value that drives the lean of the player if they are running the balance animation.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Balance (float)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("2943b9c1-1bc0-4bce-9ecf-133439dce6af")]
public class LocalPlayerSetAnimationParamBalance : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Local Player Set Animation Param Balance";
    public string GetVariableQualifiedName() => "localPlayerSetAnimationParamBalance";
}
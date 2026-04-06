/*
 * Filename: LocalPlayerSetLocomotionVFXEnabled.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Sets whether specific locomotion visual feedback effects should play when in the corresponding state.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Sprint Wind (bool)
 * Wall Run Wind (bool)
 * Slide Start Wind (bool)
 * Slide Wind (bool)
 * Slide Sparks (bool)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("f2604270-0397-40ca-a5a4-b799727eccfd")]
public class LocalPlayerSetLocomotionVFXEnabled : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Local Player Set Locomotion VFX Enabled";
    public string GetVariableQualifiedName() => "localPlayerSetLocomotionVFXEnabled";
}
/*
 * Filename: LocomotionSetSteeringInputEnabled.cs
 * Category: Misc
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Sets whether steering input is enabled for the local player. Setting this to false will stop steering events from firing and will hide walk related buttons prompts and UI Elements on supported patforms
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Enabled (bool)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Misc;

[Node("c6312c78-80fc-452c-9700-8b2dd67d13e9")]
public class LocomotionSetSteeringInputEnabled : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Locomotion Set Steering Input Enabled";
    public string GetVariableQualifiedName() => "locomotionSetSteeringInputEnabled";
}
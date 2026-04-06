/*
 * Filename: LocomotionRequestSlideDeprecated.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Used for custom locomotion in order to request starting a slide with a multiplier for the speed.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Slide Speed Multiplier (float) - Multiplied by sprint speed to determine the speed(m/s) to start sliding at. Note that request steering will not affect your speed while sliding.
 * Accelerate Down Slopes (bool) - Whether the player will accelerate down slopes while sliding.
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("f8942c27-5cf5-455f-94e9-f1e0ef4887c9")]
public class LocomotionRequestSlideDeprecated : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Locomotion Request Slide (Deprecated)";
    public string GetVariableQualifiedName() => "locomotionRequestSlideDeprecated";
}
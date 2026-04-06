/*
 * Filename: LocomotionRequestSlide.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Used for custom locomotion in order to request starting a slide.

Start Speed:
Speed(m/s) to start sliding at. Note that request steering will not affect your speed while sliding.

Stop Speed:
Speed(m/s) at which the player will exit the slide

Accelerate Down Slopes:
Whether the player will accelerate downhill.  This can extend the slide beyond Expected Duration.

Expected Duration:
Friction decelerates the player so they will reach Stop Speed(m/s) and exit the slide after Min Duration(s). Negative values will give an infinite slide. Accelerate Down Slopes can extend the slide. Braking steering can reduce the slide duration.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Start Speed (float) - Speed(m/s) to start sliding at. Note that request steering will not affect your speed while sliding.
 * Stop Speed (float) - Speed(m/s) at which the player will exit the slide
 * Accelerate Down Slopes (bool) - Whether the player will accelerate downhill.  This can extend the slide beyond Expected Duration.
 * Expected Duration (float) - Friction decelerates the player so they will reach Stop Speed(m/s) and exit the slide after Min Duration(s). Negative values will give an infinite slide. Accelerate Down Slopes can extend the slide. Braking steering can reduce the slide duration.
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("ae507f57-8840-493d-9014-38c6beb19e58")]
public class LocomotionRequestSlide : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Locomotion Request Slide";
    public string GetVariableQualifiedName() => "locomotionRequestSlide";
}
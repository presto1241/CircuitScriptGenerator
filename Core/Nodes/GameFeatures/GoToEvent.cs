/*
 * Filename: GoToEvent.cs
 * Category: Game Features
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Sends a player to a community event.

If the event is not currently happening, shows the page for it on the watch.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Player (Player)
 * Community Event (Community Event)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.GameFeatures;

[Node("9c9f756e-f972-49a4-bd1d-82225d43b350")]
public class GoToEvent : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Go To Event";
    public string GetVariableQualifiedName() => "goToEvent";
}
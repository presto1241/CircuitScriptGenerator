/*
 * Filename: ShowRewardNotification.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Shows a player a notification about a single reward or a list of up to 4 rewards. Appearance can be customized in the config menu! Triggering this chip multiple times will queue the notifications up in order of execution, and each will play subsequently after the previous duration is reached.
 * Types: (Reward | List<Reward>)
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Player (Player)
 * Reward (T)
 * Duration (float)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("3d713e71-2729-4819-819c-bcbe6fb8d400")]
public class ShowRewardNotification : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Show Reward Notification";
    public string GetVariableQualifiedName() => "showRewardNotification";
}
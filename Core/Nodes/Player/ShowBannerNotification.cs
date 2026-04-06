/*
 * Filename: ShowBannerNotification.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Shows a player a banner notification. Appearance can be customized in the config menu!
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Player (Player)
 * Title (string)
 * Main Text (string)
 * Duration (float)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("829b5788-efe0-4df4-91de-75c267ed3d57")]
public class ShowBannerNotification : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Show Banner Notification";
    public string GetVariableQualifiedName() => "showBannerNotification";
}
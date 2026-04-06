/*
 * Filename: PlayerShowSubtitle.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Displays a subtitle for a specified duration. If there is already a subtitle showing, it will be replaced only if this subtitle has an equal or higher priority. If the string is more than 200 characters, it will be displayed in multiple subtitles, each lasting a fraction of the total duration. Escape characters are ignored.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Player (Player)
 * Subtitle (string)
 * Duration (float)
 * Priority (int)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("abaae687-e943-4534-bb78-2c8d7e17c425")]
public class PlayerShowSubtitle : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Player Show Subtitle";
    public string GetVariableQualifiedName() => "playerShowSubtitle";
}
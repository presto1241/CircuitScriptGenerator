/*
 * Filename: RecRoomObjectOutline.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Outlines a Rec Room Object. Pass true to begin outlining something and false to stop outlining it.

Outlines will still be rendered on objects you are holding until the chip is ran on them to stop outlining them.
 * Types: 
 * 
 * INPUTS: 
 * Run (exec)
 * Rec Room Object (Rec Room Object)
 * Outlined (bool)
 *
 * OUTPUTS: 
 * Run (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("fa48cfc2-57a6-4ec7-b40f-66d805c73a0a")]
public class RecRoomObjectOutline : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Rec Room Object Outline";
    public string GetVariableQualifiedName() => "recRoomObjectOutline";
}
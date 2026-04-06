/*
 * Filename: FullBodyPuppetPropSetWornAvatarItems.cs
 * Category: FullBodyPuppetProp
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: 
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (Full Body Puppet Prop)
 * Custom Avatar Item Ids List (List<string>)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.FullBodyPuppetProp;

[Node("0fe6b463-c272-4329-a253-27b43871d118")]
public class FullBodyPuppetPropSetWornAvatarItems : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Full Body Puppet Prop Set Worn Avatar Items";
    public string GetVariableQualifiedName() => "fullBodyPuppetPropSetWornAvatarItems";
}
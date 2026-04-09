/*
 * Filename: NodeAttribute.cs
 * Created Date: Sunday, April 5th 2026, 12:54:29 am
 * Author: Preston
 * 
 * Description: This is the main attribute used to register nodes.
 * Any script that turns a node to working code uses this attribute.
 */
namespace CircuitScriptGenerator.Core.Api.Parsing;

/// <summary>
/// This is an attribute used to define a node.
/// When using this attribute, you have to implement "INodeBehaviour" as well.
/// </summary>
[AttributeUsage(AttributeTargets.Class)]
public class DataParserAttribute : Attribute
{
}
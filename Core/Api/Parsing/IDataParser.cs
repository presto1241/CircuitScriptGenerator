/*
 * Filename: IDataParser.cs
 * Created Date: Tuesday, April 7th 2026, 11:20:44 pm
 * Author: Preston
 * 
 * Description: An interface to create parsers for
 */

using System.IO.Compression;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Api.Parsing;

public interface IDataParser
{
    /// <summary>
    /// Attempt to parse the graphs from a given archive.
    /// </summary>
    /// <param name="archive"></param>
    /// <param name="graphs"></param>
    /// <returns></returns>
    public bool TryParseData(ZipArchive archive, out List<Graph>? graphs);
}
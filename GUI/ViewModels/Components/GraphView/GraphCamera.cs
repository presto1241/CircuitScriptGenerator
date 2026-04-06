/*
 * Filename: GraphCamera.cs
 * Created Date: Sunday, April 5th 2026, 10:19:58 pm
 * Author: Preston
 * 
 * Description: A camera that kinda follows unitys orthographic camera.
 * Used by GraphView.
 */

using System;
using Avalonia;
using CircuitScriptGenerator.GUI.Views.Components;

namespace CircuitScriptGenerator.GUI.ViewModels.Components;

public class GraphCamera
{
    /// <summary>
    /// How many meters the camera sees on the width.
    /// </summary>
    public double Size
    {
        get => _size;

        set =>_size = Math.Max(value, 0.01f);
    }

    private double _size = 7;

    public Point Position;

    public double PixelsPerWorldUnit => _graphView.Bounds.Width / Size;
    public double WorldPerPixel => Size / _graphView.Bounds.Width;

    private GraphView _graphView;

    public GraphCamera(GraphView graphView)
    {
        _graphView = graphView;
    }

    /// <summary>
    /// If you need to convert a world size to pixel size, you can by doing this.
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public double WorldToScreenSize(double value) =>
        value * PixelsPerWorldUnit;
    
    public double ScreenToWorldSize(double value) =>
        value * WorldPerPixel;

    /// <summary>
    /// Takes a point in 2d worldspace and converts it to screenspace.
    /// </summary>
    /// <param name="point">The worldspace point</param>
    /// <returns>A view space point relative to the camera [-1, 1]</returns>
    public Point WorldToViewPoint(Point point)
    {
        Point offsetPosition = point - Position;
        return offsetPosition;
    }

    /// <summary>
    /// Takes a point in 2d viewspace and converts it to screenspace.
    /// </summary>
    /// <param name="point">The view space point</param>
    /// <returns>A screen space point [0, Width or Height]</returns>
    public Point ViewToScreenPoint(Point point)
    {
        point += new Point(1, 1);
        point /= 2;

        double aspectRatio = _graphView.Bounds.Height / _graphView.Bounds.Width;
        point = new Point(
            point.X * _graphView.Bounds.Width, 
            point.Y * _graphView.Bounds.Height * aspectRatio
        );
        
        return point;
    }

    /// <summary>
    /// Takes a point in 2d screenspace and converts it to viewspace.
    /// </summary>
    /// <param name="point">The screen space point</param>
    /// <returns>A view space point [-1, 1]</returns>
    public Point ScreenToViewPoint(Point point)
    {
        double halfWidth = _graphView.Bounds.Width * 0.5;
        double halfHeight = _graphView.Bounds.Height * 0.5;
        
        // Normalize the point coordinates
        Point viewSpace = new Point(
            (point.X - (halfWidth)) / halfWidth, 
            (point.Y - (halfHeight)) / halfHeight);

        // Now shift these coordinates to [0, 1] becomes [-1, 1]
        viewSpace = new Point(viewSpace.X * 2, -viewSpace.Y * 2);
        return viewSpace;
    }

    /// <summary>
    /// Takes a point in 2d viewspace and converts it to worldspace.
    /// </summary>
    /// <param name="point"></param>
    /// <returns></returns>
    public Point ViewToWorldPoint(Point point)
    {
        return (point * Size) + Position;
    }

    /// <summary>
    /// Takes a point in 2d screenspace and converts it to worldspace.
    /// </summary>
    /// <param name="point"></param>
    /// <returns></returns>
    public Point ScreenToWorldPoint(Point point)
    {
        double scale = WorldPerPixel;

        return new Point(
            Position.X + (point.X - _graphView.Bounds.Width * 0.5) * scale,
            Position.Y + (point.Y - _graphView.Bounds.Height * 0.5) * scale
        );
    }


    /// <summary>
    /// Convert a point from worldspace to screenspace
    /// </summary>
    /// <param name="point"></param>
    /// <returns></returns>
    public Point WorldToScreenPoint(Point point)
    {
        Point viewPoint = WorldToViewPoint(point);
        viewPoint /= Size;
        viewPoint = new Point((viewPoint.X + 1) / 2, (viewPoint.Y + 1) / 2);

        double aspectRatio = _graphView.Bounds.Height / _graphView.Bounds.Width;
        Point screenPoint = new Point(
            viewPoint.X * _graphView.Bounds.Width, 
            viewPoint.Y * _graphView.Bounds.Height * aspectRatio);

        return screenPoint;
    }
}

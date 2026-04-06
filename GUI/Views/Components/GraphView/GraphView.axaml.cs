using System;
using System.Diagnostics;
using System.Numerics;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Media;
using CircuitScriptGenerator.GUI.ViewModels.Components;

namespace CircuitScriptGenerator.GUI.Views.Components;

public partial class GraphView : UserControl
{
    public const double ScrollSpeed = 0.5f;
    private bool _canvasDragActive;
    private Point _mouseDragPos;

    public GraphCamera Camera => _camera;
    private GraphCamera _camera;

    public GraphView()
    {
        InitializeComponent();
        _camera = new GraphCamera(this);
    }

    public override void Render(DrawingContext context)
    {
        base.Render(context);
        
        // First draw the canvas grid
        DrawGrid(context);
    }
 
    protected override void OnPointerPressed(PointerPressedEventArgs e)
    {
        base.OnPointerPressed(e);
        switch (e.Properties.PointerUpdateKind)
        {
            case PointerUpdateKind.RightButtonPressed:
            _mouseDragPos = e.GetPosition(this);
            _canvasDragActive = true;
            e.Handled = true;
            break;

            case PointerUpdateKind.LeftButtonPressed:
            break;
        }
    }

    protected override void OnPointerReleased(PointerReleasedEventArgs e)
    {
        base.OnPointerReleased(e);
        switch (e.Properties.PointerUpdateKind)
        {
            case PointerUpdateKind.RightButtonReleased:
            _canvasDragActive = false;
            e.Handled = true;
            break;

            case PointerUpdateKind.LeftButtonReleased:
            break;
        }
    }

    protected override void OnPointerWheelChanged(PointerWheelEventArgs e)
    {
        base.OnPointerWheelChanged(e);

        Point screenMouse = e.GetPosition(this);
        Point worldMouse = _camera.ScreenToWorldPoint(e.GetPosition(this));

        _camera.Size += ScrollSpeed * -e.Delta.Y;
        
        Point afterWorldMouse = _camera.ScreenToWorldPoint(e.GetPosition(this));
        _camera.Position += afterWorldMouse - worldMouse;
        e.Handled = true;
        InvalidateVisual();
    }

    protected override void OnPointerMoved(PointerEventArgs e)
    {
        base.OnPointerMoved(e);
        if (!_canvasDragActive) return;
        if (!e.Properties.IsRightButtonPressed) return;

        var nextMousePosition = e.GetPosition(this);

        Point screenSpaceOffset = nextMousePosition - _mouseDragPos;
        _camera.Position += new Point(
            _camera.ScreenToWorldSize(screenSpaceOffset.X),
            _camera.ScreenToWorldSize(screenSpaceOffset.Y));

        _mouseDragPos = nextMousePosition;

        e.Handled = true;
        InvalidateVisual();
    }

    private void DrawGrid(DrawingContext context)
    {
        double gridWorld = 1.0;

        double scale = _camera.PixelsPerWorldUnit;
    
        var pen = new Pen(Brushes.Gray, 1);
        var bounds = Bounds;
    
        // world size of viewport
        double worldWidth = bounds.Width / scale;
        double worldHeight = bounds.Height / scale;
    
        // world-space top-left of view (centered camera)
        double left   = -_camera.Position.X - worldWidth  * 0.5;
        double top    = -_camera.Position.Y - worldHeight * 0.5;
    
        // snap first grid line to world grid
        double startX = Math.Floor(left / gridWorld) * gridWorld;
        double startY = Math.Floor(top  / gridWorld) * gridWorld;
    
        // draw verticals
        for (double x = startX; x < left + worldWidth; x += gridWorld)
        {
            double screenX = (x - left) * scale;
            context.DrawLine(pen, new Point(screenX, 0), new Point(screenX, bounds.Height));
        }
    
        // draw horizontals
        for (double y = startY; y < top + worldHeight; y += gridWorld)
        {
            double screenY = (y - top) * scale;
            context.DrawLine(pen, new Point(0, screenY), new Point(bounds.Width, screenY));
        }
    }
}
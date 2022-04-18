using System;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;
using GameLifeGui.Lib.Area;

namespace GameLifeGui;

public class DrawCanvas{
    private Line GetLineBorder(int x1, int x2, int y1, int y2){
        return new Line{
            StrokeStartLineCap = PenLineCap.Round,
            StrokeEndLineCap = PenLineCap.Round,
            StrokeThickness = 0.1,
            Stroke = Brushes.Black,
            X1 = x1,
            X2 = x2,
            Y1 = y1,
            Y2 = y2
        };
    }

    private Rectangle getRectangle(int x1, int x2, int y1, int y2){
        return new Rectangle{
            StrokeStartLineCap = PenLineCap.Round,
            StrokeEndLineCap = PenLineCap.Round,
            StrokeThickness = 1,
            Stroke = Brushes.Black,
            Fill = Brushes.Green,
            Width = x2 - x1 + 1,
            Height = y2 - y1 + 1
        };
    }

    public void Draw(Canvas canvas){
        canvas.Children.Clear();
        var nx = 50;
        var ny = 40;
        int border = 10;
        
        Area area = new Area(border, border,
            Convert.ToInt32((canvas.ActualWidth - border*2-10) / nx) * nx-border,
            Convert.ToInt32((canvas.ActualHeight - border*2-10) / ny) * ny-border
            );

        var areas = area.SplitXyAxis(ny, nx);

        foreach (var a1 in areas){
            foreach (var a2 in a1){
                var rect = getRectangle(a2.X1, a2.X2 - 2, a2.Y1, a2.Y2 - 2);
                Canvas.SetLeft(rect, a2.X1);
                Canvas.SetTop(rect, a2.Y1);
                canvas.Children.Add(
                    rect
                );
            }
        }
    }
}
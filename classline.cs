using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Shapes;

public class mojalinia
{
    public int Id { get; set; }
    public double X1 { get; set; }
    public double Y1 { get; set; }
    public double X2 { get; set; }
    public double Y2 { get; set; }
    public SolidColorBrush Stroke { get; set; }
    public double StrokeThickness { get; set; }

    public Line Line
    {
        get
        {
            return new Line
            {
                X1 = X1,
                Y1 = Y1,
                X2 = X2,
                Y2 = Y2,
                Stroke = Stroke,
                StrokeThickness = StrokeThickness
            };
        }
    }
}
using System.Windows.Controls;
using System.Windows;
using System.Windows.Input;
using DevExpress.Xpf.Charts;
using DevExpress.Utils;


namespace SilverlightApplication1 {
    public partial class MainPage : UserControl {
        Point clickPosition { set; get; }
        Point startDragging;
        public bool isDragging { set; get; }

        public MainPage() {
            InitializeComponent();
        }
        void chart_MouseLeftButtonDown(object sender, MouseButtonEventArgs e) {
            startDragging = e.GetPosition(chartControl1);
            ChartHitInfo hitInfo = chartControl1.CalcHitInfo(startDragging);
            isDragging = hitInfo != null && hitInfo.InLegend;
            ((UIElement)sender).CaptureMouse();
        }

        void chart_MouseLeftButtonUp(object sender, MouseButtonEventArgs e) {
            ((UIElement)sender).ReleaseMouseCapture();
            isDragging = false;
        }

        void chart_MouseMove(object sender, MouseEventArgs e) {
            if (MouseButtonState.Pressed == MouseButtonState.Pressed && isDragging) {
                Point endDragging = e.GetPosition(chartControl1);
                Point inLegendPosition = e.GetPosition(legend);

                if (inLegendPosition.X < 0)
                    inLegendPosition.X = 0;
                else if (inLegendPosition.X > legend.ActualWidth)
                    inLegendPosition.X = legend.ActualWidth;

                if (inLegendPosition.Y < 0)
                    inLegendPosition.Y = 0;
                else if (inLegendPosition.Y > legend.ActualHeight)
                    inLegendPosition.Y = legend.ActualHeight;

                if (endDragging.X - inLegendPosition.X > 0 &&
                    endDragging.X + legend.ActualWidth - inLegendPosition.X < chartControl1.ActualWidth)
                    legendTransform.X += endDragging.X - startDragging.X;

                if (endDragging.Y - inLegendPosition.Y > 0 &&
                    endDragging.Y + legend.ActualHeight - inLegendPosition.Y < chartControl1.ActualHeight)
                    legendTransform.Y += endDragging.Y - startDragging.Y;
                startDragging = endDragging;
            }
        }

    }
}

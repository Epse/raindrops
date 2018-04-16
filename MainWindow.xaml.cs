using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace RainDrops
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Random random = new Random();
        private DispatcherTimer timer = new DispatcherTimer();
        private byte minAlpha = 100;

        public MainWindow()
        {
            InitializeComponent();
            intervalSlider.Value = 500;
            timer.Interval = TimeSpan.FromMilliseconds(intervalSlider.Value);
            intervalSize.Content = String.Format("{0:0} ms gap", intervalSlider.Value);
            timer.Tick += Timer_Tick;
            minAlphaSlider.Value = Convert.ToDouble(minAlpha);
            minAlphaLabel.Content = String.Format("Minimum Alpha: {0:}", minAlpha);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            int x = random.Next(0, Convert.ToInt32(paperCanvas.ActualWidth));
            int y = random.Next(0, Convert.ToInt32(paperCanvas.ActualHeight));
            int size = random.Next(1, 100);
            paperCanvas.Children.Add(DrawCircle(x, y, size));
        }

        private Ellipse DrawCircle(int x, int y, int diameter)
        {
            Brush brush = ChooseBrush();
            Ellipse circle = new Ellipse();
            circle.Width = diameter;
            circle.Height = diameter;
            circle.Stroke = brush;
            circle.Fill = brush;
            circle.Margin = new Thickness(x, y, 0, 0);
            return circle;
        }

        private Brush ChooseBrush()
        {
            byte red = (byte) random.Next(byte.MaxValue);
            byte green = (byte) random.Next(byte.MaxValue);
            byte blue = (byte) random.Next(byte.MaxValue);
            byte alpha = (byte)random.Next(minAlpha, byte.MaxValue);

            Color color = new Color();
            color.R = red;
            color.G = green;
            color.B = blue;
            color.A = alpha;

            return new SolidColorBrush(color);
        }

        private void intervalSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (!this.IsInitialized)
                return;

            double interval = intervalSlider.Value;
            string text = String.Format("{0:0} ms gap", interval);
            intervalSize.Content = text;
            timer.Interval = TimeSpan.FromMilliseconds(interval);
        }

        private void startButton_Click(object sender, RoutedEventArgs e)
        {
            timer.Start();
        }

        private void stopButton_Click(object sender, RoutedEventArgs e)
        {
            timer.Stop();
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            paperCanvas.Children.Clear();
        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            Rect rect = new Rect(paperCanvas.RenderSize);
            RenderTargetBitmap rtb = new RenderTargetBitmap((int)rect.Right,
              (int)rect.Bottom, 96d, 96d, System.Windows.Media.PixelFormats.Default);
            rtb.Render(paperCanvas);
            //endcode as PNG
            BitmapEncoder pngEncoder = new PngBitmapEncoder();
            pngEncoder.Frames.Add(BitmapFrame.Create(rtb));

            //save to memory stream
            System.IO.MemoryStream ms = new System.IO.MemoryStream();

            pngEncoder.Save(ms);
            ms.Close();
            System.IO.File.WriteAllBytes("logo.png", ms.ToArray());
        }

        private void minAlphaSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (!this.IsInitialized)
                return;

            minAlpha = Convert.ToByte(minAlphaSlider.Value);
            minAlphaLabel.Content = String.Format("Minimum Alpha: {0:}", minAlpha);
        }
    }
}

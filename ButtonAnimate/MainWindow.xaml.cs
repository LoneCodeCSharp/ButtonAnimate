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
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ButtonAnimate
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public DoubleAnimation animation = new DoubleAnimation()
        {
            From = 180,
            To = 60,
            Duration = TimeSpan.FromSeconds(0.5)
        };
        public DoubleAnimation animation1 = new DoubleAnimation()
        {
            From = 60,
            To = 180,
            Duration = TimeSpan.FromSeconds(0.5)
        };
        public MainWindow()
        {
            InitializeComponent();
        }

        private void circlebtn_MouseEnter(object sender, MouseEventArgs e)
        {
            circlebtn.BorderThickness = new Thickness(0);
            img1.Source = new BitmapImage(new Uri(@"Img\ok2.png", UriKind.Relative));
            border1.Effect = new DropShadowEffect()
            {
                BlurRadius = 20,
                Color = Color.FromRgb(4, 202, 255),
                Direction = 0,
                Opacity = 1,
                RenderingBias = RenderingBias.Quality,
                ShadowDepth = 1


            };
            circlebtn.BeginAnimation(Border.WidthProperty,animation);

        }

        private void Window_MouseEnter(object sender, MouseEventArgs e)
        {
            
        }

        private void circlebtn_MouseLeave(object sender, MouseEventArgs e)
        {
            circlebtn.BorderThickness = new Thickness(1);
            border1.Effect = null;
            img1.Source = new BitmapImage(new Uri(@"Img\ok1.png", UriKind.Relative));
            circlebtn.BeginAnimation(Border.WidthProperty, animation1);
        }

        private void circlebtn2_MouseLeave(object sender, MouseEventArgs e)
        {
            circlebtn2.BorderThickness = new Thickness(1);
            border2.Effect = null;
            img2.Source = new BitmapImage(new Uri(@"Img\ok4.png", UriKind.Relative));
            circlebtn2.BeginAnimation(Border.WidthProperty, animation1);
        }

        private void circlebtn2_MouseEnter(object sender, MouseEventArgs e)
        {
            circlebtn2.BorderThickness = new Thickness(0);
            img2.Source = new BitmapImage(new Uri(@"Img\ok3.png", UriKind.Relative));
            border2.Effect = new DropShadowEffect()
            {
                BlurRadius = 20,
                Color = Color.FromRgb(235, 4, 189),
                Direction = 0,
                Opacity = 1,
                RenderingBias = RenderingBias.Quality,
                ShadowDepth = 1


            };
            circlebtn2.BeginAnimation(Border.WidthProperty, animation);
        }

        private void circlebtn3_MouseLeave(object sender, MouseEventArgs e)
        {
            circlebtn3.BorderThickness = new Thickness(1);
            border3.Effect = null;
            img3.Source = new BitmapImage(new Uri(@"Img\pl.png", UriKind.Relative));
            circlebtn3.BeginAnimation(Border.WidthProperty, animation1);
        }

        private void circlebtn3_MouseEnter(object sender, MouseEventArgs e)
        {
            circlebtn3.BorderThickness = new Thickness(0);
            img3.Source = new BitmapImage(new Uri(@"Img\pause.png", UriKind.Relative));
            border3.Effect = new DropShadowEffect()
            {
                BlurRadius = 20,
                Color = Color.FromRgb(255, 0, 0),
                Direction = 0,
                Opacity = 1,
                RenderingBias = RenderingBias.Quality,
                ShadowDepth = 1


            };
            circlebtn3.BeginAnimation(Border.WidthProperty, animation);
        }
    }
}

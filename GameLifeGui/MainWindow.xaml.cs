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

namespace GameLifeGui{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window{
        public MainWindow(){
            InitializeComponent();
        }

        private void Button_Run_OnClick(object sender, RoutedEventArgs e){
            var drawCanvas = new DrawCanvas();
            drawCanvas.Draw(Canvas1);
        }

        private void Canvas1_OnMouseMove(object sender, MouseEventArgs e){
            if (e.MouseDevice.LeftButton == MouseButtonState.Pressed){
                //var X = e.GetPosition(Canvas1).X;
            }
        }

        private void Canvas1_OnSizeChanged(object sender, SizeChangedEventArgs e){
            var drawCanvas = new DrawCanvas();
            drawCanvas.Draw(Canvas1);
        }
        
    }
}
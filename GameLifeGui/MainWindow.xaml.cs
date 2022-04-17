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
             var nx = 50;
             var ny = 40;
            // var width = Convert.ToInt32(Canvas1.ActualHeight);
            // var height = Convert.ToInt32(Canvas1.Height);
            // var dx = width / nx;
            // var dy = height / ny;

            //for (int i = 1; i < nx-3; i++){
                // Canvas1.Children.Add(new Line{
                //     StrokeStartLineCap = PenLineCap.Round,
                //     StrokeEndLineCap = PenLineCap.Round,
                //     StrokeThickness = 1,
                //     Stroke = Brushes.Black,
                //     X1 = dx*i,
                //     X2 = dx*i,
                //     Y1 = 0,
                //     Y2 = dy*(ny-3)
                // });    
            //}
            
            
            
        }

        private void Canvas1_OnMouseMove(object sender, MouseEventArgs e){
            if (e.MouseDevice.LeftButton == MouseButtonState.Pressed){
                //var X = e.GetPosition(Canvas1).X;
                
            }
        }
    }
}
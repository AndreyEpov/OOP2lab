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

namespace OOP2_lab
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CreateGF Random = new CreateGF();
        Triangle angle3 = null; 
        Rectangle angle4 = null;
        Rectangle angleStraight = null;
        bool T=false;
        bool R = false;
        bool S = false;
        public MainWindow()
        {
            InitializeComponent();
         
        }
        private void drawLine(Point2D first, Point2D second)
        {
            Line line = new Line();
            line.Stroke = Brushes.Green;
            line.StrokeThickness = 6;
            line.X1 = first.getX();
            line.Y1 = first.getY();
            line.X2 = second.getX();
            line.Y2 = second.getY();
            //distance.Content =(first.getDistance(second));
            canvas.Children.Add(line);
        }
        
        private void drawTriangle(Triangle angle3)
        {
            drawLine(angle3.getPoint1(), angle3.getPoint2());
            drawLine(angle3.getPoint2(), angle3.getPoint3());
            drawLine(angle3.getPoint3(), angle3.getPoint1());

        }
        private void drawRectangle(Rectangle angle4)
        {
            drawLine(angle4.getPoint1(), angle4.getPoint2());
            drawLine(angle4.getPoint2(), angle4.getPoint3());
            drawLine(angle4.getPoint3(), angle4.getPoint4());
            drawLine(angle4.getPoint4(), angle4.getPoint1());
        }
        private void drawSquare(Rectangle angleStraight)
        {
            drawLine(angleStraight.getPoint1(), angleStraight.getPoint2());
            drawLine(angleStraight.getPoint2(), angleStraight.getPoint3());
            drawLine(angleStraight.getPoint3(), angleStraight.getPoint4());
            drawLine(angleStraight.getPoint4(), angleStraight.getPoint1());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            canvas.Children.Clear();
            angle3 = Random.GetTriangle();
            S = false;
            R = false;
            T = true;
            drawTriangle(angle3);
            lPerimetr.Content = angle3.getPerimetr()- angle3.getPerimetr()%1;
            lArea.Content = angle3.getArea() - angle3.getArea()%1;
            lCoord.Content = angle3.getPoint1() + "\n" + angle3.getPoint2() + "\n" + angle3.getPoint3();
        }

        private void sliderX_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            double delta = Math.Round(e.NewValue-e.OldValue);
            if (T == true)
            {
                angle3.ShiftX(delta);
                canvas.Children.Clear();
                drawTriangle(angle3);
                shX.Content = Math.Round(sliderX.Value);
                lCoord.Content = angle3.getPoint1() + "\n" + angle3.getPoint2() + "\n" + angle3.getPoint3();
            }
            if (R == true)
            {
                angle4.ShiftX(delta);
                canvas.Children.Clear();
                drawRectangle(angle4);
                shX.Content = Math.Round(sliderX.Value);
                lCoord.Content = angle4.getPoint1() + "\n" + angle4.getPoint2() + "\n" + angle4.getPoint3() + "\n" + angle4.getPoint4();

            }
            if (S == true)
            {
                angleStraight.ShiftX(delta);
                canvas.Children.Clear();
                drawSquare(angleStraight);
                shX.Content = Math.Round(sliderX.Value);
                lCoord.Content = angleStraight.getPoint1() + "\n" + angleStraight.getPoint2() + "\n" + angleStraight.getPoint3() + "\n" + angleStraight.getPoint4();

            }
        }

        private void sliderY_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            double delta = Math.Round(e.OldValue - e.NewValue);
            if (T == true)
            {
                angle3.ShiftY(delta);
                canvas.Children.Clear();
                drawTriangle(angle3);
                shY.Content = Math.Round(sliderY.Value);
                lCoord.Content = angle3.getPoint1() + "\n" + angle3.getPoint2() + "\n" + angle3.getPoint3();
            }
            if (R == true)
            {
                angle4.ShiftY(delta);
                canvas.Children.Clear();
                drawRectangle(angle4);
                shY.Content = Math.Round(sliderY.Value);
                lCoord.Content = angle4.getPoint1() + "\n" + angle4.getPoint2() + "\n" + angle4.getPoint3() + "\n" + angle4.getPoint4();


            }
            if (S == true)
            {
                angleStraight.ShiftY(delta);
                canvas.Children.Clear();
                drawSquare(angleStraight);
                shY.Content = Math.Round(sliderY.Value);
                lCoord.Content = angleStraight.getPoint1() + "\n" + angleStraight.getPoint2() + "\n" + angleStraight.getPoint3() + "\n" + angleStraight.getPoint4();

            }
        }

        private void but_rect_Click(object sender, RoutedEventArgs e)
        {
            canvas.Children.Clear();
            angle4 = Random.GetRectangle();
            S = false;
            R = true;
            T = false;
            drawRectangle(angle4);
            lPerimetr.Content = angle4.getPerimetr() - angle4.getPerimetr() % 1;
            lArea.Content = angle4.getArea() - angle4.getArea() % 1;
            lCoord.Content = angle4.getPoint1() + "\n" + angle4.getPoint2() + "\n" + angle4.getPoint3() + "\n" + angle4.getPoint4();

        }

        private void but_square_Click(object sender, RoutedEventArgs e)
        {
            canvas.Children.Clear();
            angleStraight = Random.GetSquare();
            S = true;
            R = false;
            T = false;
            drawSquare(angleStraight);
            lPerimetr.Content = angleStraight.getPerimetr() - angleStraight.getPerimetr() % 1;
            lArea.Content = angleStraight.getArea() - angleStraight.getArea() % 1;
            lCoord.Content = angleStraight.getPoint1() + "\n" + angleStraight.getPoint2() + "\n" + angleStraight.getPoint3()+"\n" + angleStraight.getPoint4();

        }
    }
}

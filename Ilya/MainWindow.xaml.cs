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
using System.IO;

namespace Ilya
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
           
        }


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
          
            File.AppendAllText("input.txt", "Пары на понедельник:\n");
            File.AppendAllText("input.txt","Первая пара:" + P1.Text + "\n");
            File.AppendAllText("input.txt","Вторая пара:" + P2.Text + "\n");
            File.AppendAllText("input.txt","Третья пара:" + P3.Text + "\n");
            File.AppendAllText("input.txt","Четвертая пара:" + P4.Text + "\n");
            File.AppendAllText("input.txt", "------------------------------------------------------------------------\n");
            File.AppendAllText("input.txt","Пары на Вторник:\n");
            File.AppendAllText("input.txt", "Первая пара:" + V1.Text + "\n");
            File.AppendAllText("input.txt", "Вторая пара:" + V2.Text + "\n");
            File.AppendAllText("input.txt", "Третья пара:" + V3.Text + "\n");
            File.AppendAllText("input.txt", "Четвертая пара:" + V4.Text + "\n");
            File.AppendAllText("input.txt", "------------------------------------------------------------------------\n");
            File.AppendAllText("input.txt", "Пары на Среду:\n");
            File.AppendAllText("input.txt", "Первая пара:" + C1.Text + "\n");
            File.AppendAllText("input.txt", "Вторая пара:" + C2.Text + "\n");
            File.AppendAllText("input.txt", "Третья пара:" + C3.Text + "\n");
            File.AppendAllText("input.txt", "Четвертая пара:" + C4.Text + "\n");
            File.AppendAllText("input.txt", "------------------------------------------------------------------------\n");
            File.AppendAllText("input.txt", "Пары на Четверг:\n");
            File.AppendAllText("input.txt", "Первая пара:" + Z1.Text + "\n");
            File.AppendAllText("input.txt", "Вторая пара:" + Z2.Text + "\n");
            File.AppendAllText("input.txt", "Третья пара:" + Z3.Text + "\n");
            File.AppendAllText("input.txt", "Четвертая пара:" + Z4.Text + "\n");
            File.AppendAllText("input.txt", "------------------------------------------------------------------------\n");
            File.AppendAllText("input.txt", "Пары на Пятницу:\n");
            File.AppendAllText("input.txt", "Первая пара:" + L1.Text + "\n");
            File.AppendAllText("input.txt", "Вторая пара:" + L2.Text + "\n");
            File.AppendAllText("input.txt", "Третья пара:" + L3.Text + "\n");
            File.AppendAllText("input.txt", "Четвертая пара:" + L4.Text + "\n");
            File.AppendAllText("input.txt", "------------------------------------------------------------------------\n");
            File.AppendAllText("input.txt", "Сейчас идет:" +H.Text + "\n");
            File.AppendAllText("input.txt",  Data.Text + "\n");

        }
    }
}

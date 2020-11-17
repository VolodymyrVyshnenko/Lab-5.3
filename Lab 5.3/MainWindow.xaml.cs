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

namespace Lab_5._3
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

        private void Generate_Clkick(object sender, RoutedEventArgs e)
        {
            Determinant determinant = new Determinant();
            UpperMatrix uppermatrix = determinant;
            uppermatrix.FillMatrix(ref ThirdBox00, ref ThirdBox10, ref ThirdBox20, ref ThirdBox01, ref ThirdBox11, ref ThirdBox21, ref ThirdBox02, ref ThirdBox12, ref ThirdBox22);
            BaseMatrix basematrix = uppermatrix;
            basematrix.FillMatrix(ref FirstBox00, ref FirstBox10, ref FirstBox20, ref FirstBox01, ref FirstBox11, ref FirstBox21, ref FirstBox02, ref FirstBox12, ref FirstBox22);
            IdentityMatrix identitymatrix = new IdentityMatrix();
            identitymatrix.FillMatrix(ref SecondBox00, ref SecondBox10, ref SecondBox20, ref SecondBox01, ref SecondBox11, ref SecondBox21, ref SecondBox02, ref SecondBox12, ref SecondBox22);
            determinant.BaseDeterminant(FirstDeterminant);
            determinant.UpperDeterminant(ThirdDeterminant);
            SecondDeterminant.Text = "Determinant is: 1"; //Поступил некрасиво
        }
    }
}

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
    internal class Determinant : UpperMatrix
    {
        public Determinant()
        {
            Random random = new Random();
            for (int i = 0; i < 3; i++) // За тройку извините
            {
                for (int a = 0; a < 3; a++) // И тут тоже
                {
                    matrix[i, a] = random.Next(-100, 100);
                }
            }

            for (int i = 0; i < 3; i++) // За тройку извините
            {
                for (int a = 0; a < 3; a++) // И тут тоже
                {
                    if (i < a)
                    {
                        uppermatrix[i, a] = 1;
                    }
                    else
                    {
                        uppermatrix[i, a] = matrix[i, a];
                    }
                }
            }
        }
        public void BaseDeterminant(TextBox textBox)
        {
            textBox.Text = "Determinant is: " + Convert.ToString((matrix[0, 0] * matrix[1, 1] * matrix[2, 2]) + (matrix[1, 0] * matrix[2, 1] * matrix[0, 2]) + (matrix[2, 0] * matrix[0, 1] * matrix[1, 2]) - (matrix[2, 0] * matrix[1, 1] * matrix[0, 2]) - (matrix[0, 1] * matrix[1, 0] * matrix[2, 2]) - (matrix[0, 0] * matrix[2, 1] * matrix[1, 2]));
        }

        public void UpperDeterminant(TextBox textBox)
        {
            textBox.Text = "Determinant is: " + Convert.ToString((uppermatrix[0, 0] * uppermatrix[1, 1] * uppermatrix[2, 2]) + (uppermatrix[1, 0] * uppermatrix[2, 1] * uppermatrix[0, 2]) + (uppermatrix[2, 0] * uppermatrix[0, 1] * uppermatrix[1, 2]) - (uppermatrix[2, 0] * uppermatrix[1, 1] * uppermatrix[0, 2]) - (uppermatrix[0, 1] * uppermatrix[1, 0] * uppermatrix[2, 2]) - (uppermatrix[0, 0] * uppermatrix[2, 1] * uppermatrix[1, 2]));
        }
    }
}

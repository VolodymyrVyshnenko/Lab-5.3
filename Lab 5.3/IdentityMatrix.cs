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
    internal class IdentityMatrix : BaseMatrix
    {
        private int[,] identitymatrix = new int[3, 3];

        public IdentityMatrix()
        {
            for (int i = 0; i < 3; i++) // За тройку извините
            {
                for (int a = 0; a < 3; a++) // И тут тоже
                {
                    if (i == a)
                    {
                        identitymatrix[i, a] = 1;
                    }
                    else
                    {
                        identitymatrix[i, a] = 0;
                    }
                }
            }
        }


        public void FillMatrix(ref TextBox Box00, ref TextBox Box10, ref TextBox Box20, ref TextBox Box01, ref TextBox Box11, ref TextBox Box21, ref TextBox Box02, ref TextBox Box12, ref TextBox Box22)
        {
            Box00.Text = Convert.ToString(identitymatrix[0, 0]);
            Box10.Text = Convert.ToString(identitymatrix[1, 0]);
            Box20.Text = Convert.ToString(identitymatrix[2, 0]);
            Box01.Text = Convert.ToString(identitymatrix[0, 1]);
            Box11.Text = Convert.ToString(identitymatrix[1, 1]);
            Box21.Text = Convert.ToString(identitymatrix[2, 1]);
            Box02.Text = Convert.ToString(identitymatrix[0, 2]);
            Box12.Text = Convert.ToString(identitymatrix[1, 2]);
            Box22.Text = Convert.ToString(identitymatrix[2, 2]);
        }
    }
}

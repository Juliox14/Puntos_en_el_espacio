using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Algebra.Forms
{
    public partial class FormTema6 : Form
    {
        public FormTema6()
        {
            InitializeComponent();
        }
        int[,] MatrizMadre = new int[4, 4], MatrizCof1 = new int[3, 3], MatrizCof2 = new int[3, 3], MatrizCof3 = new int[3, 3], MatrizCof4 = new int[3, 3];
        string x, y, z;
        int Cof1, Cof2, Cof3, Cof4, DetS, DetCof1, DetCof2, DetCof3, DetCof4;
        private void Calcularbtn_Click(object sender, EventArgs e)
        {
            MatrizMadre[0, 0] = Convert.ToInt32(x);
            MatrizMadre[0, 1] = Convert.ToInt32(y);
            MatrizMadre[0, 2] = Convert.ToInt32(z);
            MatrizMadre[0, 3] = 1;

            MatrizMadre[1, 0] = Convert.ToInt32(x2txt.Text);
            MatrizMadre[1, 1] = Convert.ToInt32(y2txt.Text);
            MatrizMadre[1, 2] = Convert.ToInt32(z2txt.Text);
            MatrizMadre[1, 3] = 1;

            MatrizMadre[2, 0] = Convert.ToInt32(x3txt.Text);
            MatrizMadre[2, 1] = Convert.ToInt32(y3txt.Text);
            MatrizMadre[2, 2] = Convert.ToInt32(z3txt.Text);
            MatrizMadre[2, 3] = 1;

            MatrizMadre[3, 0] = Convert.ToInt32(x4txt.Text);
            MatrizMadre[3, 1] = Convert.ToInt32(y4txt.Text);
            MatrizMadre[3, 2] = Convert.ToInt32(z4txt.Text);
            MatrizMadre[3, 3] = 1;
   

            //Matriz Cofactor 1

            MatrizCof1[0, 0] = MatrizMadre[1, 1];
            MatrizCof1[0, 1] = MatrizMadre[1, 2];
            MatrizCof1[0, 2] = MatrizMadre[1, 3];

            MatrizCof1[1, 0] = MatrizMadre[2, 1];
            MatrizCof1[1, 1] = MatrizMadre[2, 2];
            MatrizCof1[1, 2] = MatrizMadre[2, 3];

            MatrizCof1[2, 0] = MatrizMadre[3, 1];
            MatrizCof1[2, 1] = MatrizMadre[3, 2];
            MatrizCof1[2, 2] = MatrizMadre[3, 3];

            //Matriz Cofactor 2

            MatrizCof2[0, 0] = MatrizMadre[1, 0];
            MatrizCof2[0, 1] = MatrizMadre[1, 2];
            MatrizCof2[0, 2] = MatrizMadre[1, 3];

            MatrizCof2[1, 0] = MatrizMadre[2, 0];
            MatrizCof2[1, 1] = MatrizMadre[2, 2];
            MatrizCof2[1, 2] = MatrizMadre[2, 3];

            MatrizCof2[2, 0] = MatrizMadre[3, 0];
            MatrizCof2[2, 1] = MatrizMadre[3, 2];
            MatrizCof2[2, 2] = MatrizMadre[3, 3];

            //Matriz Cofactor 3

            MatrizCof3[0, 0] = MatrizMadre[1, 0];
            MatrizCof3[0, 1] = MatrizMadre[1, 1];
            MatrizCof3[0, 2] = MatrizMadre[1, 3];

            MatrizCof3[1, 0] = MatrizMadre[2, 0];
            MatrizCof3[1, 1] = MatrizMadre[2, 1];
            MatrizCof3[1, 2] = MatrizMadre[2, 3];

            MatrizCof3[2, 0] = MatrizMadre[3, 0];
            MatrizCof3[2, 1] = MatrizMadre[3, 1];
            MatrizCof3[2, 2] = MatrizMadre[3, 3];

            //Matriz Cofactor 4

            MatrizCof4[0, 0] = MatrizMadre[1, 0];
            MatrizCof4[0, 1] = MatrizMadre[1, 1];
            MatrizCof4[0, 2] = MatrizMadre[1, 2];

            MatrizCof4[1, 0] = MatrizMadre[2, 0];
            MatrizCof4[1, 1] = MatrizMadre[2, 1];
            MatrizCof4[1, 2] = MatrizMadre[2, 2];

            MatrizCof4[2, 0] = MatrizMadre[3, 0];
            MatrizCof4[2, 1] = MatrizMadre[3, 1];
            MatrizCof4[2, 2] = MatrizMadre[3, 2];

            //Determinante de cada cofactor

            DetCof1 = ((MatrizCof1[0, 0] * MatrizCof1[1, 1] * MatrizCof1[2, 2]) + (MatrizCof1[1, 0] * MatrizCof1[2, 1] * MatrizCof1[0, 2]) + (MatrizCof1[0, 1] * MatrizCof1[1, 2] * MatrizCof1[2, 0])) - ((MatrizCof1[0, 2] * MatrizCof1[1, 1] * MatrizCof1[2, 0]) + (MatrizCof1[0, 1] * MatrizCof1[1, 0] * MatrizCof1[2, 2]) + (MatrizCof1[1, 2] * MatrizCof1[2, 1] * MatrizCof1[0, 0]));
            
            DetCof2 = ((MatrizCof2[0, 0] * MatrizCof2[1, 1] * MatrizCof2[2, 2]) + (MatrizCof2[1, 0] * MatrizCof2[2, 1] * MatrizCof2[0, 2]) + (MatrizCof2[0, 1] * MatrizCof2[1, 2] * MatrizCof2[2, 0])) - ((MatrizCof2[0, 2] * MatrizCof2[1, 1] * MatrizCof2[2, 0]) + (MatrizCof2[0, 1] * MatrizCof2[1, 0] * MatrizCof2[2, 2]) + (MatrizCof2[1, 2] * MatrizCof2[2, 1] * MatrizCof2[0, 0]));

            DetCof3 = ((MatrizCof3[0, 0] * MatrizCof3[1, 1] * MatrizCof3[2, 2]) + (MatrizCof3[1, 0] * MatrizCof3[2, 1] * MatrizCof3[0, 2]) + (MatrizCof3[0, 1] * MatrizCof3[1, 2] * MatrizCof3[2, 0])) - ((MatrizCof3[0, 2] * MatrizCof3[1, 1] * MatrizCof3[2, 0]) + (MatrizCof3[0, 1] * MatrizCof3[1, 0] * MatrizCof3[2, 2]) + (MatrizCof3[1, 2] * MatrizCof3[2, 1] * MatrizCof3[0, 0]));

            DetCof4 = ((MatrizCof4[0, 0] * MatrizCof4[1, 1] * MatrizCof4[2, 2]) + (MatrizCof4[1, 0] * MatrizCof4[2, 1] * MatrizCof4[0, 2]) + (MatrizCof4[0, 1] * MatrizCof4[1, 2] * MatrizCof4[2, 0])) - ((MatrizCof4[0, 2] * MatrizCof4[1, 1] * MatrizCof4[2, 0]) + (MatrizCof4[0, 1] * MatrizCof4[1, 0] * MatrizCof4[2, 2]) + (MatrizCof4[1, 2] * MatrizCof4[2, 1] * MatrizCof4[0, 0]));


            

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DH3_G2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            ////Variables 
            double a = Convert.ToDouble(txta.Text);
            double b = Convert.ToDouble(txtb.Text);
            double c = Convert.ToDouble(txtc.Text);
            double x1, x2;
            ///Proceso de calculo de X1 y X2
            try
            {
                x1 = (-b + Math.Sqrt((Math.Pow(b, 2) - (4 * a * c)))) / (2 * a);
                x2 = (-b - Math.Sqrt((Math.Pow(b, 2) - (4 * a * c)))) / (2 * a);
                ///MOstrar resultados
                txtX1.Text = x1.ToString();
                txtX2.Text = x2.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Revise que los datos ingresados esten correctos.. ."+ex);
            }

        }
    }
}

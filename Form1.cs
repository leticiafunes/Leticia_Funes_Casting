using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Leticia_Funes_Casting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      
        private void btnConvertirDouble_Click(object sender, EventArgs e)
        {
            int varEntera = Convert.ToInt32 (txtInteger.Text);
            double varDouble = varEntera;   // Conversión automática de entero a double

            MessageBox.Show ("La variable entera es " + varEntera.ToString() + " y la variable Double es " + varDouble.ToString() );  
            
        }

        private void btnConvertiEntero_Click(object sender, EventArgs e)
        {
            double varDouble = Convert.ToDouble (txtDouble.Text); 
            int varEntera = (int) varDouble;   // Conversión manual de  double a entero

            MessageBox.Show("La variable double es " + varDouble.ToString() + " y la variable entera es " + varEntera.ToString());

        }
    }
}

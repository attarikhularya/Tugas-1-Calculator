using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorWindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            int nilai1;
            int nilai2;
            Double hasil;

            nilai1 = Convert.ToInt16(txtNilaiA.Text);
            nilai2 = Convert.ToInt16(txtNilaiB.Text);

            switch (cmbOperasi.SelectedIndex)
            {
                case 0:
                    hasil = nilai1 + nilai2;
                    txtHasil.Text = Convert.ToString(hasil);
                    break;
                case 1:
                    hasil = nilai1 - nilai2;
                    txtHasil.Text = Convert.ToString(hasil);
                    break;
                case 2:
                    hasil = nilai1 * nilai2;
                    txtHasil.Text = Convert.ToString(hasil);
                    break;
                case 3:
                    hasil = nilai1 / nilai2;
                    txtHasil.Text = Convert.ToString(hasil);
                    break;
            }
        }
    }
}

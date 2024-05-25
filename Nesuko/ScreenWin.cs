using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nesuko
{
    public partial class ScreenWin : Form
    {
        public ScreenWin(int tiempo, int puntuacion)
        {
            InitializeComponent();
            lbl_Time.Text = "en "+tiempo.ToString() + "Segundos";
            lbl_pts.Text = puntuacion.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

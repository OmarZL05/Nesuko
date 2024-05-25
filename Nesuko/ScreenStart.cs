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
    public partial class ScreenStart : Form
    {
        public ScreenStart()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            using (ScreenGame gameScreen = new ScreenGame())
            {
                this.Hide();
                gameScreen.ShowDialog();
            }
            try
            {
                this.Show();
            }
            catch (ObjectDisposedException) { 

            }
            
        }

        private void MyForm_Load(object sender, EventArgs e)
        {
        }

    }
}

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
    public partial class GameScreen : Form
    {
        private int[,] cells;

        struct cell
        {
            TextBox box;
        }

        public GameScreen()
        {
            InitializeComponent();
            cells = new int[4, 4];
        }

        private void box_KeyPress(object sender, KeyPressEventArgs e)
        {
            int value;
            int.TryParse(e.KeyChar.ToString(), out value);

            if (!char.IsControl(e.KeyChar) && (!char.IsDigit(e.KeyChar) || (char.IsDigit(e.KeyChar) && (value < 1 || value > 4))))
            {
                e.Handled = true;
            }

        }

        public void isUnique(TextBox box)
        {

        }

        private void GameScreen_Load(object sender, EventArgs e) {}

        private void fila_1(TextBox box)
        {
            
            box.BackColor = System.Drawing.Color.White;
            if (box.Text == box1_1.Text && box.Name != box1_1.Name)
            {
                box.BackColor = System.Drawing.Color.Red;
                box1_1.BackColor = System.Drawing.Color.Red;
            }
            
            if (box.Text == box1_2.Text && box.Name != box1_2.Name)
            {
                box.BackColor = System.Drawing.Color.Red;
                box1_2.BackColor = System.Drawing.Color.Red;
            }
            
            if (box.Text == box1_3.Text && box.Name != box1_3.Name)
            {
                box.BackColor = System.Drawing.Color.Red;
                box1_3.BackColor = System.Drawing.Color.Red;
            }
            
            if (box.Text == box1_4.Text && box.Name != box1_4.Name)
            {
                box.BackColor = System.Drawing.Color.Red;
                box1_4.BackColor = System.Drawing.Color.Red;
            }
        }

        private void box1_1_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(box1_1.Text, out cells[0, 0]);
            fila_1(box1_1);
        }

        private void box1_2_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(box1_2.Text, out cells[0, 1]);
            fila_1(box1_2);
        }

        private void box1_3_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(box1_3.Text, out cells[0, 2]);
            fila_1(box1_3);
        }

        private void box1_4_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(box1_4.Text, out cells[0, 3]);
            fila_1(box1_4);
        }

        private void box2_1_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(box2_1.Text, out cells[1, 0]);
        }

        private void box2_2_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(box2_2.Text, out cells[1, 1]);
        }

        private void box2_3_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(box2_3.Text, out cells[1, 2]);
        }

        private void box2_4_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(box2_4.Text, out cells[1, 3]);
        }

        private void box3_1_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(box3_1.Text, out cells[2, 0]);
        }

        private void box3_2_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(box3_2.Text, out cells[2, 1]);
        }

        private void box3_3_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(box3_3.Text, out cells[2, 2]);
        }

        private void box3_4_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(box3_4.Text, out cells[2, 3]);
        }

        private void box4_1_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(box4_1.Text, out cells[3, 0]);
        }

        private void box4_2_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(box4_2.Text, out cells[3, 1]);
        }

        private void box4_3_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(box4_3.Text, out cells[3, 2]);
        }

        private void box4_4_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(box4_4.Text, out cells[3, 3]);
        }

        
    }
}

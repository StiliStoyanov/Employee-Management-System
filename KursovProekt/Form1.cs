using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursovProekt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void button_WOC1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Сигурни ли сте, че искате да затворите приложението? ", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result.Equals(DialogResult.Yes))
            {
                
            Environment.Exit(1);
            }


        }

        private void btn2_Click(object sender, EventArgs e)
        {

            Form2 frm = new Form2();
            frm.Show();
            this.Hide();
            frm.Location = new Point(this.Left, this.Top);


        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (MessageBox.Show("Сигурни ли сте, че искате да затворите приложението?",
                               "Курсов проект",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Information) == DialogResult.Yes)
                    Environment.Exit(1);
                else
                    e.Cancel = true; 
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Size = new Size(1000, 600);
            frm3.Show();
            this.Hide();
            frm3.Location = new Point(this.Left, this.Top);
        }
    }
}

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
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent(); 
          
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
            frm1.Location = new Point(this.Left, this.Top);
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btnMain_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Size = new Size(1000, 600);
            frm3.Show();
            this.Hide();
            frm3.Location = new Point(this.Left, this.Top);
        }
    }
}

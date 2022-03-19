using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace KursovProekt
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
     

        private void btnBackMain_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
            frm1.Location = new Point(this.Left, this.Top);
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
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

        private void Form3_Load(object sender, EventArgs e)
        {
           
        }
        List<string> egn = new List<string>();
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || comboBox1.Text == "" || comboBox2.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Моля попълнете всички полета ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (maskedTextBox1.Text.Length != 19)
                {
                    MessageBox.Show("Въведете валидно ЕГН ", "EGN not valid", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (maskedTextBox1.Text != "")
                    {
                        if (egn.Contains(maskedTextBox1.Text.Replace(" ", "")))
                        {
                            MessageBox.Show("Вече съществува служител с това ЕГН ", "EGN not valid", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {
                          
                            if (textBox4.Text.Length != 4)
                            {
                                MessageBox.Show("Въведете заплата в интервала 1000-9999 лв. (вкл.)", "Salary not valid", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                egn.Add(maskedTextBox1.Text.Replace(" ", ""));
                                listBox1.Items.Add(textBox1.Text + " " + textBox2.Text + " " + textBox3.Text + "    ЕГН: " + maskedTextBox1.Text.Replace(" ", "") +
                               "    Професия: " + comboBox1.Text + "    Отдел: " + comboBox2.Text + "    Дата на постъпване: " + dateTimePicker1.Value.ToString("dd-MM-yyyy") + "    Заплата: " + textBox4.Text + "лв.");
                                MessageBox.Show("Служителят беше добавен успешно! ", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                        }
                    }


                }
            }



        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            bool isFound = false;
            if (maskedTextBox1.Text.Replace(" ","")=="")
            {
                MessageBox.Show("Моля, въведете ЕГН на служителя, когото желаете да премахнете!", "Not found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                isFound = true;
            }
            else
            {
               
                for (int n = listBox1.Items.Count - 1; n >= 0; --n)
                {
                    string tekst = maskedTextBox1.Text.Replace(" ", "");
                    if (listBox1.Items[n].ToString().Contains(tekst))
                    {

                        isFound = true;
                        DialogResult result = MessageBox.Show("Сигурни ли сте, че искате да премахнете служител с ЕГН: " + tekst, "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result.Equals(DialogResult.Yes))
                        {
                            listBox1.Items.RemoveAt(n);
                            for (int i = 0; i < egn.Count; i++)
                            {
                                if (egn[i] == maskedTextBox1.Text.Replace(" ", ""))
                                {
                                    egn.Remove(egn[i]);
                                }
                            }
                        }

                    }
                }
            }
            
            if (!isFound)
            {
                MessageBox.Show("Не съществува служител с въведеното от Вас ЕГН!", "Not found", MessageBoxButtons.OK,    MessageBoxIcon.Information);
            }

        }
       
        
        Form4 frm4 = new Form4();
        private void btnChange_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0 &&
               listBox1.SelectedIndex < listBox1.Items.Count)
            {
                textBox5.Text = listBox1.GetItemText(listBox1.SelectedItem);
                textBox5.Text = textBox5.Text.Substring(textBox5.Text.Length - 7);
                frm4.textBox1.Text = textBox5.Text.TrimEnd('л', 'в', '.');
                string trimmed1 = listBox1.GetItemText(listBox1.SelectedItem);
                string forListBox = trimmed1.Substring(0, trimmed1.Length - 7);
                string trimmed = trimmed1.Substring(0, trimmed1.Length - 17);
                frm4.label1.Text = trimmed; //.Substring(0, listBox1.GetItemText(listBox1.SelectedItem).Length - frm4.textBox1.Text.Length)
                if (frm4.ShowDialog() == DialogResult.OK)
                {
                    listBox1.Items.Remove(listBox1.SelectedItem);
                    listBox1.Items.Add(forListBox + frm4.textBox1.Text + "лв.");
                }
            }
            else
            {
                
                MessageBox.Show("Моля, маркирайте служител! ",
                    "No Selection", MessageBoxButtons.OK);

            }
          


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        string oldText = string.Empty;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.All(chr => char.IsLetter(chr)))
            {
                oldText = textBox1.Text;
                textBox1.Text = oldText;

                textBox1.BackColor = System.Drawing.Color.White;
                textBox1.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                textBox1.Text = oldText;
                textBox1.BackColor = System.Drawing.Color.Red;
                textBox1.ForeColor = System.Drawing.Color.White;
            }
            textBox1.SelectionStart = textBox1.Text.Length;
        }
        string oldText1 = string.Empty;
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text.All(chr => char.IsLetter(chr)))
            {
                oldText1 = textBox2.Text;
                textBox2.Text = oldText1;

                textBox2.BackColor = System.Drawing.Color.White;
                textBox2.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                textBox2.Text = oldText1;
                textBox2.BackColor = System.Drawing.Color.Red;
                textBox2.ForeColor = System.Drawing.Color.White;
            }
            textBox2.SelectionStart = textBox2.Text.Length;
        }
        string oldText2 = string.Empty;
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text.All(chr => char.IsLetter(chr)))
            {
                oldText2 = textBox3.Text;
                textBox3.Text = oldText2;

                textBox3.BackColor = System.Drawing.Color.White;
                textBox3.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                textBox3.Text = oldText2;
                textBox3.BackColor = System.Drawing.Color.Red;
                textBox3.ForeColor = System.Drawing.Color.White;
            }
            textBox3.SelectionStart = textBox3.Text.Length;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            textBox4.Text = "";

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox4.Text, "[^0-9]"))
            {
                MessageBox.Show("Моля, въвеждайте само цифри! ");
                textBox4.Text = textBox4.Text.Remove(textBox4.Text.Length - 1);
            }
        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {
            Form5 frm5 = new Form5();
            frm5.Size = new Size(1000, 600);
            frm5.Show();
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                frm5.listBox1.Items.Add(listBox1.Items[i]);
            }
        }

        private void запазиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filename = "";
            saveFileDialog1.Title = "Save Text file...";
            saveFileDialog1.FileName = " ";
            saveFileDialog1.Filter = "Text files|*.txt|RTF|*.rtf|All files|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filename = saveFileDialog1.FileName;
                StreamWriter sw = File.CreateText(filename);
                try
                {
                    foreach (var item in listBox1.Items)
                    {
                        sw.WriteLine(item);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    sw.Close();
                }
            }
            
        }
    }
}

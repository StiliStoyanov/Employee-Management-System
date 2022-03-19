
namespace KursovProekt
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnBackMain = new ePOSOne.btnProduct.Button_WOC();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(424, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(684, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Информация за всички служители ";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 22;
            this.listBox1.Location = new System.Drawing.Point(24, 101);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(1388, 708);
            this.listBox1.TabIndex = 1;
            // 
            // btnBackMain
            // 
            this.btnBackMain.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnBackMain.ButtonColor = System.Drawing.Color.LightSkyBlue;
            this.btnBackMain.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBackMain.FlatAppearance.BorderSize = 0;
            this.btnBackMain.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnBackMain.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnBackMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBackMain.Location = new System.Drawing.Point(12, 25);
            this.btnBackMain.Name = "btnBackMain";
            this.btnBackMain.OnHoverBorderColor = System.Drawing.Color.MidnightBlue;
            this.btnBackMain.OnHoverButtonColor = System.Drawing.Color.MidnightBlue;
            this.btnBackMain.OnHoverTextColor = System.Drawing.Color.White;
            this.btnBackMain.Size = new System.Drawing.Size(199, 43);
            this.btnBackMain.TabIndex = 6;
            this.btnBackMain.Text = "Назад";
            this.btnBackMain.TextColor = System.Drawing.Color.Black;
            this.btnBackMain.UseVisualStyleBackColor = true;
            this.btnBackMain.Click += new System.EventHandler(this.btnBackMain_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1462, 817);
            this.Controls.Add(this.btnBackMain);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form5";
            this.Text = "Информация за всички служители";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ListBox listBox1;
        private ePOSOne.btnProduct.Button_WOC btnBackMain;
    }
}
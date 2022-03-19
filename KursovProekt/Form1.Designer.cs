
namespace KursovProekt
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn1 = new ePOSOne.btnProduct.Button_WOC();
            this.btn2 = new ePOSOne.btnProduct.Button_WOC();
            this.btn3 = new ePOSOne.btnProduct.Button_WOC();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btn1.ButtonColor = System.Drawing.Color.LightSkyBlue;
            this.btn1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn1.FlatAppearance.BorderSize = 0;
            this.btn1.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn1.Location = new System.Drawing.Point(308, 77);
            this.btn1.Name = "btn1";
            this.btn1.OnHoverBorderColor = System.Drawing.Color.MidnightBlue;
            this.btn1.OnHoverButtonColor = System.Drawing.Color.MidnightBlue;
            this.btn1.OnHoverTextColor = System.Drawing.Color.White;
            this.btn1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn1.Size = new System.Drawing.Size(290, 94);
            this.btn1.TabIndex = 5;
            this.btn1.Text = "Към приложението\r\n";
            this.btn1.TextColor = System.Drawing.Color.Black;
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btn2.ButtonColor = System.Drawing.Color.LightSkyBlue;
            this.btn2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn2.FlatAppearance.BorderSize = 0;
            this.btn2.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn2.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn2.Location = new System.Drawing.Point(308, 221);
            this.btn2.Name = "btn2";
            this.btn2.OnHoverBorderColor = System.Drawing.Color.MidnightBlue;
            this.btn2.OnHoverButtonColor = System.Drawing.Color.MidnightBlue;
            this.btn2.OnHoverTextColor = System.Drawing.Color.White;
            this.btn2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn2.Size = new System.Drawing.Size(290, 94);
            this.btn2.TabIndex = 4;
            this.btn2.Text = "Данни за автора \r\n  на системата";
            this.btn2.TextColor = System.Drawing.Color.Black;
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btn3.ButtonColor = System.Drawing.Color.LightSkyBlue;
            this.btn3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn3.FlatAppearance.BorderSize = 0;
            this.btn3.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn3.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn3.Location = new System.Drawing.Point(308, 371);
            this.btn3.Name = "btn3";
            this.btn3.OnHoverBorderColor = System.Drawing.Color.MidnightBlue;
            this.btn3.OnHoverButtonColor = System.Drawing.Color.MidnightBlue;
            this.btn3.OnHoverTextColor = System.Drawing.Color.White;
            this.btn3.Size = new System.Drawing.Size(290, 94);
            this.btn3.TabIndex = 3;
            this.btn3.Text = "Изход ";
            this.btn3.TextColor = System.Drawing.Color.Black;
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.button_WOC1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(898, 563);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Стартова форма ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion
        private ePOSOne.btnProduct.Button_WOC btn3;
        private ePOSOne.btnProduct.Button_WOC btn2;
        private ePOSOne.btnProduct.Button_WOC btn1;
    }
}


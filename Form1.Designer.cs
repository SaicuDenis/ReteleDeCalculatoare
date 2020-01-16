namespace Cifrul_Lui_Cezar
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
            this.Criptbutton = new System.Windows.Forms.Button();
            this.Resetbutton = new System.Windows.Forms.Button();
            this.Decriptbutton = new System.Windows.Forms.Button();
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.TextBoxMO = new System.Windows.Forms.TextBox();
            this.textBoxMCD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Criptbutton
            // 
            this.Criptbutton.Location = new System.Drawing.Point(470, 101);
            this.Criptbutton.Name = "Criptbutton";
            this.Criptbutton.Size = new System.Drawing.Size(191, 55);
            this.Criptbutton.TabIndex = 0;
            this.Criptbutton.Text = "Cripteaza";
            this.Criptbutton.UseVisualStyleBackColor = true;
            this.Criptbutton.Click += new System.EventHandler(this.Criptbutton_Click);
            // 
            // Resetbutton
            // 
            this.Resetbutton.Location = new System.Drawing.Point(470, 321);
            this.Resetbutton.Name = "Resetbutton";
            this.Resetbutton.Size = new System.Drawing.Size(191, 55);
            this.Resetbutton.TabIndex = 1;
            this.Resetbutton.Text = "Reset";
            this.Resetbutton.UseVisualStyleBackColor = true;
            this.Resetbutton.Click += new System.EventHandler(this.Resetbutton_Click);
            // 
            // Decriptbutton
            // 
            this.Decriptbutton.Location = new System.Drawing.Point(470, 190);
            this.Decriptbutton.Name = "Decriptbutton";
            this.Decriptbutton.Size = new System.Drawing.Size(191, 54);
            this.Decriptbutton.TabIndex = 2;
            this.Decriptbutton.Text = "Decripteaza";
            this.Decriptbutton.UseVisualStyleBackColor = true;
            this.Decriptbutton.Click += new System.EventHandler(this.Decriptbutton_Click);
            // 
            // textBoxKey
            // 
            this.textBoxKey.Location = new System.Drawing.Point(453, 435);
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.Size = new System.Drawing.Size(224, 22);
            this.textBoxKey.TabIndex = 3;
            // 
            // TextBoxMO
            // 
            this.TextBoxMO.Location = new System.Drawing.Point(25, 65);
            this.TextBoxMO.Multiline = true;
            this.TextBoxMO.Name = "TextBoxMO";
            this.TextBoxMO.Size = new System.Drawing.Size(265, 91);
            this.TextBoxMO.TabIndex = 4;
            // 
            // textBoxMCD
            // 
            this.textBoxMCD.Location = new System.Drawing.Point(25, 277);
            this.textBoxMCD.Multiline = true;
            this.textBoxMCD.Name = "textBoxMCD";
            this.textBoxMCD.Size = new System.Drawing.Size(265, 99);
            this.textBoxMCD.TabIndex = 5;
            this.textBoxMCD.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mesajul original";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mesajul Criptat/Decriptat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(450, 405);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Key";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 515);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxMCD);
            this.Controls.Add(this.TextBoxMO);
            this.Controls.Add(this.textBoxKey);
            this.Controls.Add(this.Decriptbutton);
            this.Controls.Add(this.Resetbutton);
            this.Controls.Add(this.Criptbutton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Criptbutton;
        private System.Windows.Forms.Button Resetbutton;
        private System.Windows.Forms.Button Decriptbutton;
        private System.Windows.Forms.TextBox textBoxKey;
        private System.Windows.Forms.TextBox TextBoxMO;
        private System.Windows.Forms.TextBox textBoxMCD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}


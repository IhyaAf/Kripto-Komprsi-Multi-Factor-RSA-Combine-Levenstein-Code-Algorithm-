namespace skripsi__Kripto___Kompresi_
{
    partial class generate
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
            this.nop = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.prime = new System.Windows.Forms.RichTextBox();
            this.en = new System.Windows.Forms.TextBox();
            this.totient = new System.Windows.Forms.TextBox();
            this.dd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ed = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nop
            // 
            this.nop.Location = new System.Drawing.Point(88, 13);
            this.nop.Name = "nop";
            this.nop.Size = new System.Drawing.Size(105, 20);
            this.nop.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(199, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Number Of p     : ";
            // 
            // prime
            // 
            this.prime.Enabled = false;
            this.prime.Location = new System.Drawing.Point(88, 40);
            this.prime.Name = "prime";
            this.prime.Size = new System.Drawing.Size(186, 96);
            this.prime.TabIndex = 3;
            this.prime.Text = "";
            // 
            // en
            // 
            this.en.Location = new System.Drawing.Point(88, 143);
            this.en.Name = "en";
            this.en.Size = new System.Drawing.Size(186, 20);
            this.en.TabIndex = 4;
            // 
            // totient
            // 
            this.totient.Location = new System.Drawing.Point(88, 170);
            this.totient.Name = "totient";
            this.totient.Size = new System.Drawing.Size(186, 20);
            this.totient.TabIndex = 5;
            // 
            // dd
            // 
            this.dd.Location = new System.Drawing.Point(88, 197);
            this.dd.Name = "dd";
            this.dd.Size = new System.Drawing.Size(186, 20);
            this.dd.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "n :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Φ(n) : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "d : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Prime :";
            // 
            // ed
            // 
            this.ed.Location = new System.Drawing.Point(88, 224);
            this.ed.Name = "ed";
            this.ed.Size = new System.Drawing.Size(186, 20);
            this.ed.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "e : ";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(199, 251);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // generate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 300);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ed);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dd);
            this.Controls.Add(this.totient);
            this.Controls.Add(this.en);
            this.Controls.Add(this.prime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nop);
            this.Name = "generate";
            this.Text = "generate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nop;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox prime;
        private System.Windows.Forms.TextBox en;
        private System.Windows.Forms.TextBox totient;
        private System.Windows.Forms.TextBox dd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ed;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
    }
}
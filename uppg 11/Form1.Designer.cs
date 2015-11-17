namespace uppg_11
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxHemmaseger = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxOavgjort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxBortaseger = new System.Windows.Forms.TextBox();
            this.btnGenerera = new System.Windows.Forms.Button();
            this.btnRensa = new System.Windows.Forms.Button();
            this.listBoxTipsradNumrering = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAvsluta = new System.Windows.Forms.Button();
            this.listBoxTipsradSvar = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRensa);
            this.groupBox1.Controls.Add(this.btnGenerera);
            this.groupBox1.Controls.Add(this.txtBoxBortaseger);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtBoxOavgjort);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtBoxHemmaseger);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(45, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(120, 304);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sannolikheter (%)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hemmaseger";
            // 
            // txtBoxHemmaseger
            // 
            this.txtBoxHemmaseger.Location = new System.Drawing.Point(9, 51);
            this.txtBoxHemmaseger.Name = "txtBoxHemmaseger";
            this.txtBoxHemmaseger.Size = new System.Drawing.Size(100, 20);
            this.txtBoxHemmaseger.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Oavgjort";
            // 
            // txtBoxOavgjort
            // 
            this.txtBoxOavgjort.Location = new System.Drawing.Point(9, 102);
            this.txtBoxOavgjort.Name = "txtBoxOavgjort";
            this.txtBoxOavgjort.Size = new System.Drawing.Size(100, 20);
            this.txtBoxOavgjort.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Bortaseger";
            // 
            // txtBoxBortaseger
            // 
            this.txtBoxBortaseger.Location = new System.Drawing.Point(9, 154);
            this.txtBoxBortaseger.Name = "txtBoxBortaseger";
            this.txtBoxBortaseger.Size = new System.Drawing.Size(100, 20);
            this.txtBoxBortaseger.TabIndex = 5;
            // 
            // btnGenerera
            // 
            this.btnGenerera.Location = new System.Drawing.Point(9, 197);
            this.btnGenerera.Name = "btnGenerera";
            this.btnGenerera.Size = new System.Drawing.Size(100, 23);
            this.btnGenerera.TabIndex = 6;
            this.btnGenerera.Text = "Generera";
            this.btnGenerera.UseVisualStyleBackColor = true;
            this.btnGenerera.Click += new System.EventHandler(this.btnGenerera_Click);
            // 
            // btnRensa
            // 
            this.btnRensa.Location = new System.Drawing.Point(9, 261);
            this.btnRensa.Name = "btnRensa";
            this.btnRensa.Size = new System.Drawing.Size(100, 23);
            this.btnRensa.TabIndex = 6;
            this.btnRensa.Text = "Rensa";
            this.btnRensa.UseVisualStyleBackColor = true;
            this.btnRensa.Click += new System.EventHandler(this.btnRensa_Click);
            // 
            // listBoxTipsradNumrering
            // 
            this.listBoxTipsradNumrering.FormattingEnabled = true;
            this.listBoxTipsradNumrering.Location = new System.Drawing.Point(203, 49);
            this.listBoxTipsradNumrering.Name = "listBoxTipsradNumrering";
            this.listBoxTipsradNumrering.Size = new System.Drawing.Size(127, 290);
            this.listBoxTipsradNumrering.TabIndex = 1;
            this.listBoxTipsradNumrering.SelectedIndexChanged += new System.EventHandler(this.listBoxTipsrad_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(200, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tipsrad";
            // 
            // btnAvsluta
            // 
            this.btnAvsluta.Location = new System.Drawing.Point(344, 385);
            this.btnAvsluta.Name = "btnAvsluta";
            this.btnAvsluta.Size = new System.Drawing.Size(100, 23);
            this.btnAvsluta.TabIndex = 6;
            this.btnAvsluta.Text = "Avsluta";
            this.btnAvsluta.UseVisualStyleBackColor = true;
            this.btnAvsluta.Click += new System.EventHandler(this.btnAvsluta_Click);
            // 
            // listBoxTipsradSvar
            // 
            this.listBoxTipsradSvar.FormattingEnabled = true;
            this.listBoxTipsradSvar.Location = new System.Drawing.Point(226, 49);
            this.listBoxTipsradSvar.Name = "listBoxTipsradSvar";
            this.listBoxTipsradSvar.Size = new System.Drawing.Size(104, 290);
            this.listBoxTipsradSvar.TabIndex = 1;
            this.listBoxTipsradSvar.SelectedIndexChanged += new System.EventHandler(this.listBoxTipsrad_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 437);
            this.Controls.Add(this.btnAvsluta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBoxTipsradSvar);
            this.Controls.Add(this.listBoxTipsradNumrering);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRensa;
        private System.Windows.Forms.Button btnGenerera;
        private System.Windows.Forms.TextBox txtBoxBortaseger;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxOavgjort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxHemmaseger;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxTipsradNumrering;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAvsluta;
        private System.Windows.Forms.ListBox listBoxTipsradSvar;
    }
}


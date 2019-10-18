namespace RegisztracioAlkalmazas
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_nev = new System.Windows.Forms.TextBox();
            this.txt_ujhobbi = new System.Windows.Forms.TextBox();
            this.hobbiLista = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_hozzaad = new System.Windows.Forms.Button();
            this.btn_mentes = new System.Windows.Forms.Button();
            this.btn_betoltes = new System.Windows.Forms.Button();
            this.F = new System.Windows.Forms.RadioButton();
            this.N = new System.Windows.Forms.RadioButton();
            this.szul_datum = new System.Windows.Forms.DateTimePicker();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Név:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Szül. dátum:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nem:";
            // 
            // txt_nev
            // 
            this.txt_nev.Location = new System.Drawing.Point(125, 30);
            this.txt_nev.Name = "txt_nev";
            this.txt_nev.Size = new System.Drawing.Size(100, 20);
            this.txt_nev.TabIndex = 3;
            // 
            // txt_ujhobbi
            // 
            this.txt_ujhobbi.Location = new System.Drawing.Point(252, 157);
            this.txt_ujhobbi.Name = "txt_ujhobbi";
            this.txt_ujhobbi.Size = new System.Drawing.Size(120, 20);
            this.txt_ujhobbi.TabIndex = 5;
            this.txt_ujhobbi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_ujhobbi_KeyDown);
            // 
            // hobbiLista
            // 
            this.hobbiLista.FormattingEnabled = true;
            this.hobbiLista.Location = new System.Drawing.Point(252, 46);
            this.hobbiLista.Name = "hobbiLista";
            this.hobbiLista.Size = new System.Drawing.Size(120, 95);
            this.hobbiLista.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(249, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "kedvenc hobbi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(190, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Új hobbi:";
            // 
            // btn_hozzaad
            // 
            this.btn_hozzaad.Location = new System.Drawing.Point(281, 183);
            this.btn_hozzaad.Name = "btn_hozzaad";
            this.btn_hozzaad.Size = new System.Drawing.Size(91, 22);
            this.btn_hozzaad.TabIndex = 9;
            this.btn_hozzaad.Text = "Hozzáad";
            this.btn_hozzaad.UseVisualStyleBackColor = true;
            this.btn_hozzaad.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_mentes
            // 
            this.btn_mentes.Location = new System.Drawing.Point(193, 251);
            this.btn_mentes.Name = "btn_mentes";
            this.btn_mentes.Size = new System.Drawing.Size(75, 25);
            this.btn_mentes.TabIndex = 10;
            this.btn_mentes.Text = "Mentés";
            this.btn_mentes.UseVisualStyleBackColor = true;
            this.btn_mentes.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_betoltes
            // 
            this.btn_betoltes.Location = new System.Drawing.Point(290, 252);
            this.btn_betoltes.Name = "btn_betoltes";
            this.btn_betoltes.Size = new System.Drawing.Size(82, 24);
            this.btn_betoltes.TabIndex = 11;
            this.btn_betoltes.Text = "Betöltés";
            this.btn_betoltes.UseVisualStyleBackColor = true;
            this.btn_betoltes.Click += new System.EventHandler(this.button3_Click);
            // 
            // F
            // 
            this.F.AutoSize = true;
            this.F.Location = new System.Drawing.Point(125, 86);
            this.F.Name = "F";
            this.F.Size = new System.Drawing.Size(31, 17);
            this.F.TabIndex = 12;
            this.F.TabStop = true;
            this.F.Text = "F";
            this.F.UseVisualStyleBackColor = true;
            // 
            // N
            // 
            this.N.AutoSize = true;
            this.N.Location = new System.Drawing.Point(171, 86);
            this.N.Name = "N";
            this.N.Size = new System.Drawing.Size(33, 17);
            this.N.TabIndex = 13;
            this.N.TabStop = true;
            this.N.Text = "N";
            this.N.UseVisualStyleBackColor = true;
            // 
            // szul_datum
            // 
            this.szul_datum.Location = new System.Drawing.Point(125, 56);
            this.szul_datum.Name = "szul_datum";
            this.szul_datum.Size = new System.Drawing.Size(100, 20);
            this.szul_datum.TabIndex = 14;
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog_FileOk);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 284);
            this.Controls.Add(this.szul_datum);
            this.Controls.Add(this.N);
            this.Controls.Add(this.F);
            this.Controls.Add(this.btn_betoltes);
            this.Controls.Add(this.btn_mentes);
            this.Controls.Add(this.btn_hozzaad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.hobbiLista);
            this.Controls.Add(this.txt_ujhobbi);
            this.Controls.Add(this.txt_nev);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_nev;
        private System.Windows.Forms.TextBox txt_ujhobbi;
        private System.Windows.Forms.ListBox hobbiLista;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_hozzaad;
        private System.Windows.Forms.Button btn_mentes;
        private System.Windows.Forms.Button btn_betoltes;
        private System.Windows.Forms.RadioButton F;
        private System.Windows.Forms.RadioButton N;
        private System.Windows.Forms.DateTimePicker szul_datum;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}


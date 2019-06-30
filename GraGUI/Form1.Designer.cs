namespace GraGUI
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
            this.btnNowaGra = new System.Windows.Forms.Button();
            this.grpBoxLosowanie = new System.Windows.Forms.GroupBox();
            this.btnLosuj = new System.Windows.Forms.Button();
            this.textBoxDo = new System.Windows.Forms.TextBox();
            this.textBoxOd = new System.Windows.Forms.TextBox();
            this.lblZakresDo = new System.Windows.Forms.Label();
            this.lblZakresOd = new System.Windows.Forms.Label();
            this.Zgaduj = new System.Windows.Forms.GroupBox();
            this.button_poddaj = new System.Windows.Forms.Button();
            this.label_wynik = new System.Windows.Forms.Label();
            this.zgadujlabel = new System.Windows.Forms.Label();
            this.SprawdzButton = new System.Windows.Forms.Button();
            this.textBox_Zgaduj = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_ruchy = new System.Windows.Forms.Label();
            this.button_historia = new System.Windows.Forms.Button();
            this.grpBoxLosowanie.SuspendLayout();
            this.Zgaduj.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNowaGra
            // 
            this.btnNowaGra.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNowaGra.Location = new System.Drawing.Point(26, 25);
            this.btnNowaGra.Margin = new System.Windows.Forms.Padding(6);
            this.btnNowaGra.Name = "btnNowaGra";
            this.btnNowaGra.Size = new System.Drawing.Size(150, 44);
            this.btnNowaGra.TabIndex = 0;
            this.btnNowaGra.Text = "Nowa gra";
            this.btnNowaGra.UseVisualStyleBackColor = true;
            this.btnNowaGra.Click += new System.EventHandler(this.btnNowaGra_Click);
            // 
            // grpBoxLosowanie
            // 
            this.grpBoxLosowanie.BackColor = System.Drawing.Color.Transparent;
            this.grpBoxLosowanie.Controls.Add(this.btnLosuj);
            this.grpBoxLosowanie.Controls.Add(this.textBoxDo);
            this.grpBoxLosowanie.Controls.Add(this.textBoxOd);
            this.grpBoxLosowanie.Controls.Add(this.lblZakresDo);
            this.grpBoxLosowanie.Controls.Add(this.lblZakresOd);
            this.grpBoxLosowanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.grpBoxLosowanie.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.grpBoxLosowanie.Location = new System.Drawing.Point(26, 100);
            this.grpBoxLosowanie.Margin = new System.Windows.Forms.Padding(6);
            this.grpBoxLosowanie.Name = "grpBoxLosowanie";
            this.grpBoxLosowanie.Padding = new System.Windows.Forms.Padding(6);
            this.grpBoxLosowanie.Size = new System.Drawing.Size(574, 233);
            this.grpBoxLosowanie.TabIndex = 1;
            this.grpBoxLosowanie.TabStop = false;
            this.grpBoxLosowanie.Text = "Losowanie";
            this.grpBoxLosowanie.Visible = false;
            // 
            // btnLosuj
            // 
            this.btnLosuj.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnLosuj.Location = new System.Drawing.Point(412, 88);
            this.btnLosuj.Margin = new System.Windows.Forms.Padding(6);
            this.btnLosuj.Name = "btnLosuj";
            this.btnLosuj.Size = new System.Drawing.Size(150, 44);
            this.btnLosuj.TabIndex = 2;
            this.btnLosuj.Text = "Wylosuj";
            this.btnLosuj.UseVisualStyleBackColor = true;
            this.btnLosuj.Click += new System.EventHandler(this.btnLosuj_Click);
            // 
            // textBoxDo
            // 
            this.textBoxDo.Location = new System.Drawing.Point(182, 142);
            this.textBoxDo.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxDo.Name = "textBoxDo";
            this.textBoxDo.Size = new System.Drawing.Size(196, 31);
            this.textBoxDo.TabIndex = 3;
            this.textBoxDo.Text = "100";
            this.textBoxDo.Enter += new System.EventHandler(this.btnLosuj_Click);
            // 
            // textBoxOd
            // 
            this.textBoxOd.Location = new System.Drawing.Point(182, 48);
            this.textBoxOd.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxOd.Name = "textBoxOd";
            this.textBoxOd.Size = new System.Drawing.Size(196, 31);
            this.textBoxOd.TabIndex = 2;
            this.textBoxOd.Text = "1";
            // 
            // lblZakresDo
            // 
            this.lblZakresDo.AutoSize = true;
            this.lblZakresDo.BackColor = System.Drawing.Color.Black;
            this.lblZakresDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblZakresDo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblZakresDo.Location = new System.Drawing.Point(46, 148);
            this.lblZakresDo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblZakresDo.Name = "lblZakresDo";
            this.lblZakresDo.Size = new System.Drawing.Size(124, 25);
            this.lblZakresDo.TabIndex = 1;
            this.lblZakresDo.Text = "Zakres do:";
            // 
            // lblZakresOd
            // 
            this.lblZakresOd.AutoSize = true;
            this.lblZakresOd.BackColor = System.Drawing.Color.Black;
            this.lblZakresOd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblZakresOd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblZakresOd.Location = new System.Drawing.Point(46, 51);
            this.lblZakresOd.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblZakresOd.Name = "lblZakresOd";
            this.lblZakresOd.Size = new System.Drawing.Size(124, 25);
            this.lblZakresOd.TabIndex = 0;
            this.lblZakresOd.Text = "Zakres od:";
            // 
            // Zgaduj
            // 
            this.Zgaduj.BackColor = System.Drawing.Color.Transparent;
            this.Zgaduj.Controls.Add(this.button_poddaj);
            this.Zgaduj.Controls.Add(this.label_wynik);
            this.Zgaduj.Controls.Add(this.zgadujlabel);
            this.Zgaduj.Controls.Add(this.SprawdzButton);
            this.Zgaduj.Controls.Add(this.textBox_Zgaduj);
            this.Zgaduj.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Zgaduj.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Zgaduj.Location = new System.Drawing.Point(26, 372);
            this.Zgaduj.Name = "Zgaduj";
            this.Zgaduj.Size = new System.Drawing.Size(568, 275);
            this.Zgaduj.TabIndex = 4;
            this.Zgaduj.TabStop = false;
            this.Zgaduj.Text = "Zgaduj";
            this.Zgaduj.Visible = false;
            // 
            // button_poddaj
            // 
            this.button_poddaj.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button_poddaj.Location = new System.Drawing.Point(443, 50);
            this.button_poddaj.Name = "button_poddaj";
            this.button_poddaj.Size = new System.Drawing.Size(119, 47);
            this.button_poddaj.TabIndex = 4;
            this.button_poddaj.Text = "Poddaj";
            this.button_poddaj.UseVisualStyleBackColor = true;
            this.button_poddaj.Click += new System.EventHandler(this.button_poddaj_Click);
            // 
            // label_wynik
            // 
            this.label_wynik.AutoSize = true;
            this.label_wynik.BackColor = System.Drawing.Color.Transparent;
            this.label_wynik.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_wynik.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_wynik.Location = new System.Drawing.Point(25, 132);
            this.label_wynik.Name = "label_wynik";
            this.label_wynik.Size = new System.Drawing.Size(0, 135);
            this.label_wynik.TabIndex = 3;
            // 
            // zgadujlabel
            // 
            this.zgadujlabel.AutoSize = true;
            this.zgadujlabel.BackColor = System.Drawing.Color.Black;
            this.zgadujlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zgadujlabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.zgadujlabel.Location = new System.Drawing.Point(19, 61);
            this.zgadujlabel.Name = "zgadujlabel";
            this.zgadujlabel.Size = new System.Drawing.Size(84, 25);
            this.zgadujlabel.TabIndex = 2;
            this.zgadujlabel.Text = "Zgaduj";
            // 
            // SprawdzButton
            // 
            this.SprawdzButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.SprawdzButton.Location = new System.Drawing.Point(301, 54);
            this.SprawdzButton.Name = "SprawdzButton";
            this.SprawdzButton.Size = new System.Drawing.Size(130, 39);
            this.SprawdzButton.TabIndex = 1;
            this.SprawdzButton.Text = "Sprawdź";
            this.SprawdzButton.UseVisualStyleBackColor = true;
            this.SprawdzButton.Click += new System.EventHandler(this.SprawdzButton_Click);
            // 
            // textBox_Zgaduj
            // 
            this.textBox_Zgaduj.Location = new System.Drawing.Point(123, 58);
            this.textBox_Zgaduj.Name = "textBox_Zgaduj";
            this.textBox_Zgaduj.Size = new System.Drawing.Size(157, 31);
            this.textBox_Zgaduj.TabIndex = 0;
            this.textBox_Zgaduj.Text = "0";
            this.textBox_Zgaduj.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_Zgaduj_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(414, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ilosc ruchów:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_ruchy
            // 
            this.label_ruchy.AutoSize = true;
            this.label_ruchy.BackColor = System.Drawing.Color.Black;
            this.label_ruchy.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_ruchy.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_ruchy.Location = new System.Drawing.Point(570, 35);
            this.label_ruchy.Name = "label_ruchy";
            this.label_ruchy.Size = new System.Drawing.Size(25, 25);
            this.label_ruchy.TabIndex = 6;
            this.label_ruchy.Text = "0";
            this.label_ruchy.Click += new System.EventHandler(this.label2_Click);
            // 
            // button_historia
            // 
            this.button_historia.Enabled = false;
            this.button_historia.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_historia.Location = new System.Drawing.Point(228, 25);
            this.button_historia.Name = "button_historia";
            this.button_historia.Size = new System.Drawing.Size(153, 44);
            this.button_historia.TabIndex = 7;
            this.button_historia.Text = "Historia";
            this.button_historia.UseVisualStyleBackColor = true;
            this.button_historia.Click += new System.EventHandler(this.button_historia_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(644, 696);
            this.Controls.Add(this.button_historia);
            this.Controls.Add(this.label_ruchy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Zgaduj);
            this.Controls.Add(this.grpBoxLosowanie);
            this.Controls.Add(this.btnNowaGra);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Gra Za Dużo Za Mało";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpBoxLosowanie.ResumeLayout(false);
            this.grpBoxLosowanie.PerformLayout();
            this.Zgaduj.ResumeLayout(false);
            this.Zgaduj.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNowaGra;
        private System.Windows.Forms.GroupBox grpBoxLosowanie;
        private System.Windows.Forms.Button btnLosuj;
        private System.Windows.Forms.TextBox textBoxDo;
        private System.Windows.Forms.TextBox textBoxOd;
        private System.Windows.Forms.Label lblZakresDo;
        private System.Windows.Forms.Label lblZakresOd;
        private System.Windows.Forms.GroupBox Zgaduj;
        private System.Windows.Forms.Label label_wynik;
        private System.Windows.Forms.Label zgadujlabel;
        private System.Windows.Forms.Button SprawdzButton;
        public System.Windows.Forms.TextBox textBox_Zgaduj;
        private System.Windows.Forms.Button button_poddaj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_ruchy;
        private System.Windows.Forms.Button button_historia;
    }
}


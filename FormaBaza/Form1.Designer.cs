
namespace FormaBaza
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
            this.Unesi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.brisi = new System.Windows.Forms.Button();
            this.promeni = new System.Windows.Forms.Button();
            this.pocetak = new System.Windows.Forms.Button();
            this.levo = new System.Windows.Forms.Button();
            this.desno = new System.Windows.Forms.Button();
            this.kraj = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.TextBox();
            this.naziv = new System.Windows.Forms.TextBox();
            this.opstina = new System.Windows.Forms.TextBox();
            this.brojeviod = new System.Windows.Forms.TextBox();
            this.sprat = new System.Windows.Forms.TextBox();
            this.brojevido = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Unesi
            // 
            this.Unesi.Location = new System.Drawing.Point(296, 237);
            this.Unesi.Name = "Unesi";
            this.Unesi.Size = new System.Drawing.Size(75, 23);
            this.Unesi.TabIndex = 0;
            this.Unesi.Text = "Unesi";
            this.Unesi.UseVisualStyleBackColor = true;
            this.Unesi.Click += new System.EventHandler(this.Unesi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(515, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(515, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(515, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(515, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(515, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(515, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "label6";
            // 
            // brisi
            // 
            this.brisi.Location = new System.Drawing.Point(377, 237);
            this.brisi.Name = "brisi";
            this.brisi.Size = new System.Drawing.Size(75, 23);
            this.brisi.TabIndex = 13;
            this.brisi.Text = "Brisi";
            this.brisi.UseVisualStyleBackColor = true;
            this.brisi.Click += new System.EventHandler(this.brisi_Click);
            // 
            // promeni
            // 
            this.promeni.Location = new System.Drawing.Point(458, 237);
            this.promeni.Name = "promeni";
            this.promeni.Size = new System.Drawing.Size(75, 23);
            this.promeni.TabIndex = 14;
            this.promeni.Text = "Promeni";
            this.promeni.UseVisualStyleBackColor = true;
            this.promeni.Click += new System.EventHandler(this.promeni_Click);
            // 
            // pocetak
            // 
            this.pocetak.Location = new System.Drawing.Point(259, 283);
            this.pocetak.Name = "pocetak";
            this.pocetak.Size = new System.Drawing.Size(75, 23);
            this.pocetak.TabIndex = 15;
            this.pocetak.Text = "Pocetak";
            this.pocetak.UseVisualStyleBackColor = true;
            this.pocetak.Click += new System.EventHandler(this.pocetak_Click);
            // 
            // levo
            // 
            this.levo.Location = new System.Drawing.Point(340, 283);
            this.levo.Name = "levo";
            this.levo.Size = new System.Drawing.Size(75, 23);
            this.levo.TabIndex = 16;
            this.levo.Text = "<";
            this.levo.UseVisualStyleBackColor = true;
            this.levo.Click += new System.EventHandler(this.levo_Click);
            // 
            // desno
            // 
            this.desno.Location = new System.Drawing.Point(421, 283);
            this.desno.Name = "desno";
            this.desno.Size = new System.Drawing.Size(75, 23);
            this.desno.TabIndex = 17;
            this.desno.Text = ">";
            this.desno.UseVisualStyleBackColor = true;
            this.desno.Click += new System.EventHandler(this.desno_Click);
            // 
            // kraj
            // 
            this.kraj.Location = new System.Drawing.Point(502, 283);
            this.kraj.Name = "kraj";
            this.kraj.Size = new System.Drawing.Size(69, 23);
            this.kraj.TabIndex = 18;
            this.kraj.Text = "Kraj";
            this.kraj.UseVisualStyleBackColor = true;
            this.kraj.Click += new System.EventHandler(this.kraj_Click);
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(319, 60);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(175, 20);
            this.id.TabIndex = 6;
            // 
            // naziv
            // 
            this.naziv.Location = new System.Drawing.Point(319, 86);
            this.naziv.Name = "naziv";
            this.naziv.Size = new System.Drawing.Size(175, 20);
            this.naziv.TabIndex = 1;
            // 
            // opstina
            // 
            this.opstina.Location = new System.Drawing.Point(319, 112);
            this.opstina.Name = "opstina";
            this.opstina.Size = new System.Drawing.Size(175, 20);
            this.opstina.TabIndex = 2;
            // 
            // brojeviod
            // 
            this.brojeviod.Location = new System.Drawing.Point(319, 164);
            this.brojeviod.Name = "brojeviod";
            this.brojeviod.Size = new System.Drawing.Size(175, 20);
            this.brojeviod.TabIndex = 4;
            // 
            // sprat
            // 
            this.sprat.Location = new System.Drawing.Point(319, 138);
            this.sprat.Name = "sprat";
            this.sprat.Size = new System.Drawing.Size(175, 20);
            this.sprat.TabIndex = 3;
            // 
            // brojevido
            // 
            this.brojevido.Location = new System.Drawing.Point(319, 190);
            this.brojevido.Name = "brojevido";
            this.brojevido.Size = new System.Drawing.Size(175, 20);
            this.brojevido.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.kraj);
            this.Controls.Add(this.desno);
            this.Controls.Add(this.levo);
            this.Controls.Add(this.pocetak);
            this.Controls.Add(this.promeni);
            this.Controls.Add(this.brisi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.id);
            this.Controls.Add(this.brojevido);
            this.Controls.Add(this.brojeviod);
            this.Controls.Add(this.sprat);
            this.Controls.Add(this.opstina);
            this.Controls.Add(this.naziv);
            this.Controls.Add(this.Unesi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Unesi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button brisi;
        private System.Windows.Forms.Button promeni;
        private System.Windows.Forms.Button pocetak;
        private System.Windows.Forms.Button levo;
        private System.Windows.Forms.Button desno;
        private System.Windows.Forms.Button kraj;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox naziv;
        private System.Windows.Forms.TextBox opstina;
        private System.Windows.Forms.TextBox brojeviod;
        private System.Windows.Forms.TextBox sprat;
        private System.Windows.Forms.TextBox brojevido;
    }
}


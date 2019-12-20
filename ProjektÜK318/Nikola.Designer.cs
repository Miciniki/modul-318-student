namespace ProjektÜK318
{
    partial class Nikola
    {
       
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button_Mail = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.listBox_Ausgabe = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Suchen = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_Ankunftsort = new System.Windows.Forms.ComboBox();
            this.comboBox_Abfahrtsort = new System.Windows.Forms.ComboBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button_Sponoring = new System.Windows.Forms.Button();
            this.button_Help = new System.Windows.Forms.Button();
            this.Datumsauswahl = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Verbindungausgehend = new System.Windows.Forms.Button();
            this.listBoxAusgehendeverbindungen = new System.Windows.Forms.ListBox();
            this.Abfahrtsort1 = new System.Windows.Forms.Label();
            this.ButtonLocationSuchen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Mail
            // 
            this.button_Mail.BackColor = System.Drawing.Color.Red;
            this.button_Mail.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_Mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Mail.Location = new System.Drawing.Point(77, 944);
            this.button_Mail.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.button_Mail.Name = "button_Mail";
            this.button_Mail.Size = new System.Drawing.Size(2350, 76);
            this.button_Mail.TabIndex = 28;
            this.button_Mail.Text = "Mail";
            this.button_Mail.UseVisualStyleBackColor = false;
            this.button_Mail.Click += new System.EventHandler(this.Button_Mail_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dddd dd MMMM yyyy - hh:mm:s";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(885, 144);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(709, 38);
            this.dateTimePicker1.TabIndex = 27;
            // 
            // listBox_Ausgabe
            // 
            this.listBox_Ausgabe.BackColor = System.Drawing.Color.DodgerBlue;
            this.listBox_Ausgabe.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_Ausgabe.FormattingEnabled = true;
            this.listBox_Ausgabe.ItemHeight = 53;
            this.listBox_Ausgabe.Location = new System.Drawing.Point(378, 514);
            this.listBox_Ausgabe.Margin = new System.Windows.Forms.Padding(5);
            this.listBox_Ausgabe.Name = "listBox_Ausgabe";
            this.listBox_Ausgabe.Size = new System.Drawing.Size(1795, 216);
            this.listBox_Ausgabe.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1582, 415);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(326, 63);
            this.label6.TabIndex = 25;
            this.label6.Text = "Ankuftszeit:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1142, 415);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(199, 63);
            this.label5.TabIndex = 24;
            this.label5.Text = "Dauer:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(558, 415);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(348, 63);
            this.label4.TabIndex = 23;
            this.label4.Text = "Abfahrtszeit:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(77, 483);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2350, 2);
            this.panel1.TabIndex = 22;
            // 
            // btn_Suchen
            // 
            this.btn_Suchen.BackColor = System.Drawing.Color.Green;
            this.btn_Suchen.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Suchen.Location = new System.Drawing.Point(772, 789);
            this.btn_Suchen.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Suchen.Name = "btn_Suchen";
            this.btn_Suchen.Size = new System.Drawing.Size(822, 143);
            this.btn_Suchen.TabIndex = 21;
            this.btn_Suchen.Text = "Suchen";
            this.btn_Suchen.UseVisualStyleBackColor = false;
            this.btn_Suchen.Click += new System.EventHandler(this.Btn_Suchen_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1582, 214);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(334, 63);
            this.label3.TabIndex = 20;
            this.label3.Text = "Ankunftsort:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(558, 214);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(324, 63);
            this.label2.TabIndex = 19;
            this.label2.Text = "Abfahrtsort:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1182, 307);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 63);
            this.label1.TabIndex = 18;
            this.label1.Text = "-->";
            // 
            // comboBox_Ankunftsort
            // 
            this.comboBox_Ankunftsort.BackColor = System.Drawing.Color.LightCyan;
            this.comboBox_Ankunftsort.FormattingEnabled = true;
            this.comboBox_Ankunftsort.Location = new System.Drawing.Point(1443, 307);
            this.comboBox_Ankunftsort.Margin = new System.Windows.Forms.Padding(5);
            this.comboBox_Ankunftsort.Name = "comboBox_Ankunftsort";
            this.comboBox_Ankunftsort.Size = new System.Drawing.Size(625, 39);
            this.comboBox_Ankunftsort.TabIndex = 17;
            this.comboBox_Ankunftsort.DropDown += new System.EventHandler(this.ComboBox_Ankunftsort_TextUpdate);
            // 
            // comboBox_Abfahrtsort
            // 
            this.comboBox_Abfahrtsort.BackColor = System.Drawing.Color.LightCyan;
            this.comboBox_Abfahrtsort.FormattingEnabled = true;
            this.comboBox_Abfahrtsort.Location = new System.Drawing.Point(432, 307);
            this.comboBox_Abfahrtsort.Margin = new System.Windows.Forms.Padding(5);
            this.comboBox_Abfahrtsort.Name = "comboBox_Abfahrtsort";
            this.comboBox_Abfahrtsort.Size = new System.Drawing.Size(612, 39);
            this.comboBox_Abfahrtsort.TabIndex = 16;
            this.comboBox_Abfahrtsort.DropDown += new System.EventHandler(this.ComboBox_Abfahrtsort_TextUpdate);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // button_Sponoring
            // 
            this.button_Sponoring.BackColor = System.Drawing.Color.Tan;
            this.button_Sponoring.Location = new System.Drawing.Point(1607, 791);
            this.button_Sponoring.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.button_Sponoring.Name = "button_Sponoring";
            this.button_Sponoring.Size = new System.Drawing.Size(822, 141);
            this.button_Sponoring.TabIndex = 30;
            this.button_Sponoring.Text = "Sponsoring";
            this.button_Sponoring.UseVisualStyleBackColor = false;
            this.button_Sponoring.Click += new System.EventHandler(this.Button_Sponoring_Click_1);
            // 
            // button_Help
            // 
            this.button_Help.BackColor = System.Drawing.Color.Azure;
            this.button_Help.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Help.Location = new System.Drawing.Point(77, 789);
            this.button_Help.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.button_Help.Name = "button_Help";
            this.button_Help.Size = new System.Drawing.Size(682, 141);
            this.button_Help.TabIndex = 29;
            this.button_Help.Text = "Bei fragen klicken Sie bitte hier drauf, Sie werden sofort eine Lösung finden";
            this.button_Help.UseVisualStyleBackColor = false;
            this.button_Help.Click += new System.EventHandler(this.Button_Help_Click_1);
            // 
            // Datumsauswahl
            // 
            this.Datumsauswahl.AutoSize = true;
            this.Datumsauswahl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Datumsauswahl.Location = new System.Drawing.Point(1012, 54);
            this.Datumsauswahl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Datumsauswahl.Name = "Datumsauswahl";
            this.Datumsauswahl.Size = new System.Drawing.Size(452, 63);
            this.Datumsauswahl.TabIndex = 31;
            this.Datumsauswahl.Text = "Datumsauswahl:";
            // 
            // Verbindungausgehend
            // 
            this.Verbindungausgehend.BackColor = System.Drawing.Color.Lime;
            this.Verbindungausgehend.Location = new System.Drawing.Point(77, 1052);
            this.Verbindungausgehend.Name = "Verbindungausgehend";
            this.Verbindungausgehend.Size = new System.Drawing.Size(2350, 76);
            this.Verbindungausgehend.TabIndex = 32;
            this.Verbindungausgehend.Text = "Ausgehende Verbindungen";
            this.Verbindungausgehend.UseVisualStyleBackColor = false;
            this.Verbindungausgehend.Click += new System.EventHandler(this.Button1_Click);
            // 
            // listBoxAusgehendeverbindungen
            // 
            this.listBoxAusgehendeverbindungen.BackColor = System.Drawing.Color.DodgerBlue;
            this.listBoxAusgehendeverbindungen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxAusgehendeverbindungen.FormattingEnabled = true;
            this.listBoxAusgehendeverbindungen.ItemHeight = 53;
            this.listBoxAusgehendeverbindungen.Location = new System.Drawing.Point(378, 1270);
            this.listBoxAusgehendeverbindungen.Margin = new System.Windows.Forms.Padding(5);
            this.listBoxAusgehendeverbindungen.Name = "listBoxAusgehendeverbindungen";
            this.listBoxAusgehendeverbindungen.Size = new System.Drawing.Size(1795, 216);
            this.listBoxAusgehendeverbindungen.TabIndex = 33;
            // 
            // Abfahrtsort1
            // 
            this.Abfahrtsort1.AutoSize = true;
            this.Abfahrtsort1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Abfahrtsort1.Location = new System.Drawing.Point(367, 1175);
            this.Abfahrtsort1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Abfahrtsort1.Name = "Abfahrtsort1";
            this.Abfahrtsort1.Size = new System.Drawing.Size(324, 63);
            this.Abfahrtsort1.TabIndex = 34;
            this.Abfahrtsort1.Text = "Abfahrtsort:";
            this.Abfahrtsort1.Click += new System.EventHandler(this.label7_Click);
            // 
            // ButtonLocationSuchen
            // 
            this.ButtonLocationSuchen.Location = new System.Drawing.Point(77, 514);
            this.ButtonLocationSuchen.Name = "ButtonLocationSuchen";
            this.ButtonLocationSuchen.Size = new System.Drawing.Size(296, 216);
            this.ButtonLocationSuchen.TabIndex = 35;
            this.ButtonLocationSuchen.Text = "Location Suchen";
            this.ButtonLocationSuchen.UseVisualStyleBackColor = true;
            this.ButtonLocationSuchen.Click += new System.EventHandler(this.ButtonLocationSuchen_Click);
            // 
            // Nikola
            // 
            this.AcceptButton = this.btn_Suchen;
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(2443, 1510);
            this.Controls.Add(this.ButtonLocationSuchen);
            this.Controls.Add(this.Abfahrtsort1);
            this.Controls.Add(this.listBoxAusgehendeverbindungen);
            this.Controls.Add(this.Verbindungausgehend);
            this.Controls.Add(this.Datumsauswahl);
            this.Controls.Add(this.button_Mail);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.listBox_Ausgabe);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Suchen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_Ankunftsort);
            this.Controls.Add(this.comboBox_Abfahrtsort);
            this.Controls.Add(this.button_Sponoring);
            this.Controls.Add(this.button_Help);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "Nikola";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "BlyatBB APP";
            this.Load += new System.EventHandler(this.Nikola_Load);
            this.Enter += new System.EventHandler(this.Btn_Suchen_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Mail;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ListBox listBox_Ausgabe;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Suchen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_Ankunftsort;
        private System.Windows.Forms.ComboBox comboBox_Abfahrtsort;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button button_Sponoring;
        private System.Windows.Forms.Button button_Help;
        private System.Windows.Forms.Label Datumsauswahl;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button Verbindungausgehend;
        private System.Windows.Forms.ListBox listBoxAusgehendeverbindungen;
        private System.Windows.Forms.Label Abfahrtsort1;
        private System.Windows.Forms.Button ButtonLocationSuchen;
    }
}


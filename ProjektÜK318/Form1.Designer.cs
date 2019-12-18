namespace ProjektÜK318
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Stationsauswahl = new System.Windows.Forms.TabPage();
            this.dateTimePickerdateTimePickerAnkunft = new System.Windows.Forms.DateTimePicker();
            this.labelDatumAnkunft = new System.Windows.Forms.Label();
            this.textBoxZeiteingabe = new System.Windows.Forms.TextBox();
            this.dateTimePickerAbfahrt = new System.Windows.Forms.DateTimePicker();
            this.labelZeit = new System.Windows.Forms.Label();
            this.labelDatumAbfahrt = new System.Windows.Forms.Label();
            this.buttonVerbindungsuchen = new System.Windows.Forms.Button();
            this.comboBoxAnkunftsort = new System.Windows.Forms.ComboBox();
            this.LabelAbfahrtsort = new System.Windows.Forms.Label();
            this.LabelAnkunftsort = new System.Windows.Forms.Label();
            this.comboBoxAbfahrtsort = new System.Windows.Forms.ComboBox();
            this.Tafel = new System.Windows.Forms.TabPage();
            this.buttonStandort = new System.Windows.Forms.Button();
            this.buttonAbfahrtsplan = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelStationsort = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.tabControl1.SuspendLayout();
            this.Stationsauswahl.SuspendLayout();
            this.Tafel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Stationsauswahl);
            this.tabControl1.Controls.Add(this.Tafel);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1551, 1069);
            this.tabControl1.TabIndex = 0;
            // 
            // Stationsauswahl
            // 
            this.Stationsauswahl.Controls.Add(this.treeView1);
            this.Stationsauswahl.Controls.Add(this.dateTimePickerdateTimePickerAnkunft);
            this.Stationsauswahl.Controls.Add(this.labelDatumAnkunft);
            this.Stationsauswahl.Controls.Add(this.textBoxZeiteingabe);
            this.Stationsauswahl.Controls.Add(this.dateTimePickerAbfahrt);
            this.Stationsauswahl.Controls.Add(this.labelZeit);
            this.Stationsauswahl.Controls.Add(this.labelDatumAbfahrt);
            this.Stationsauswahl.Controls.Add(this.buttonVerbindungsuchen);
            this.Stationsauswahl.Controls.Add(this.comboBoxAnkunftsort);
            this.Stationsauswahl.Controls.Add(this.LabelAbfahrtsort);
            this.Stationsauswahl.Controls.Add(this.LabelAnkunftsort);
            this.Stationsauswahl.Controls.Add(this.comboBoxAbfahrtsort);
            this.Stationsauswahl.Location = new System.Drawing.Point(10, 48);
            this.Stationsauswahl.Name = "Stationsauswahl";
            this.Stationsauswahl.Padding = new System.Windows.Forms.Padding(3);
            this.Stationsauswahl.Size = new System.Drawing.Size(1531, 1011);
            this.Stationsauswahl.TabIndex = 0;
            this.Stationsauswahl.Text = "Stationsauswahl";
            this.Stationsauswahl.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerdateTimePickerAnkunft
            // 
            this.dateTimePickerdateTimePickerAnkunft.Location = new System.Drawing.Point(574, 239);
            this.dateTimePickerdateTimePickerAnkunft.Name = "dateTimePickerdateTimePickerAnkunft";
            this.dateTimePickerdateTimePickerAnkunft.Size = new System.Drawing.Size(532, 38);
            this.dateTimePickerdateTimePickerAnkunft.TabIndex = 10;
            // 
            // labelDatumAnkunft
            // 
            this.labelDatumAnkunft.AutoSize = true;
            this.labelDatumAnkunft.Location = new System.Drawing.Point(568, 173);
            this.labelDatumAnkunft.Name = "labelDatumAnkunft";
            this.labelDatumAnkunft.Size = new System.Drawing.Size(372, 32);
            this.labelDatumAnkunft.TabIndex = 9;
            this.labelDatumAnkunft.Text = "Datum Abfahrt (dd/MM/yyyy)";
            // 
            // textBoxZeiteingabe
            // 
            this.textBoxZeiteingabe.Location = new System.Drawing.Point(12, 377);
            this.textBoxZeiteingabe.Name = "textBoxZeiteingabe";
            this.textBoxZeiteingabe.Size = new System.Drawing.Size(1094, 38);
            this.textBoxZeiteingabe.TabIndex = 8;
            // 
            // dateTimePickerAbfahrt
            // 
            this.dateTimePickerAbfahrt.Location = new System.Drawing.Point(12, 239);
            this.dateTimePickerAbfahrt.Name = "dateTimePickerAbfahrt";
            this.dateTimePickerAbfahrt.Size = new System.Drawing.Size(532, 38);
            this.dateTimePickerAbfahrt.TabIndex = 7;
            // 
            // labelZeit
            // 
            this.labelZeit.AutoSize = true;
            this.labelZeit.Location = new System.Drawing.Point(6, 316);
            this.labelZeit.Name = "labelZeit";
            this.labelZeit.Size = new System.Drawing.Size(182, 32);
            this.labelZeit.TabIndex = 6;
            this.labelZeit.Text = "Zeit (HH/mm)";
            // 
            // labelDatumAbfahrt
            // 
            this.labelDatumAbfahrt.AutoSize = true;
            this.labelDatumAbfahrt.Location = new System.Drawing.Point(6, 173);
            this.labelDatumAbfahrt.Name = "labelDatumAbfahrt";
            this.labelDatumAbfahrt.Size = new System.Drawing.Size(372, 32);
            this.labelDatumAbfahrt.TabIndex = 5;
            this.labelDatumAbfahrt.Text = "Datum Abfahrt (dd/MM/yyyy)";
            this.labelDatumAbfahrt.Click += new System.EventHandler(this.LabelDatum_Click);
            // 
            // buttonVerbindungsuchen
            // 
            this.buttonVerbindungsuchen.Location = new System.Drawing.Point(1146, 34);
            this.buttonVerbindungsuchen.Name = "buttonVerbindungsuchen";
            this.buttonVerbindungsuchen.Size = new System.Drawing.Size(347, 82);
            this.buttonVerbindungsuchen.TabIndex = 4;
            this.buttonVerbindungsuchen.Text = "Verbindung suchen";
            this.buttonVerbindungsuchen.UseVisualStyleBackColor = true;
            this.buttonVerbindungsuchen.Click += new System.EventHandler(this.buttonVerbindungsuchen_Click);
            // 
            // comboBoxAnkunftsort
            // 
            this.comboBoxAnkunftsort.FormattingEnabled = true;
            this.comboBoxAnkunftsort.Location = new System.Drawing.Point(574, 77);
            this.comboBoxAnkunftsort.Name = "comboBoxAnkunftsort";
            this.comboBoxAnkunftsort.Size = new System.Drawing.Size(532, 39);
            this.comboBoxAnkunftsort.TabIndex = 3;
            // 
            // LabelAbfahrtsort
            // 
            this.LabelAbfahrtsort.AutoSize = true;
            this.LabelAbfahrtsort.Location = new System.Drawing.Point(6, 25);
            this.LabelAbfahrtsort.Name = "LabelAbfahrtsort";
            this.LabelAbfahrtsort.Size = new System.Drawing.Size(169, 32);
            this.LabelAbfahrtsort.TabIndex = 2;
            this.LabelAbfahrtsort.Text = "Abfahrtsort :";
            // 
            // LabelAnkunftsort
            // 
            this.LabelAnkunftsort.AutoSize = true;
            this.LabelAnkunftsort.Location = new System.Drawing.Point(568, 25);
            this.LabelAnkunftsort.Name = "LabelAnkunftsort";
            this.LabelAnkunftsort.Size = new System.Drawing.Size(174, 32);
            this.LabelAnkunftsort.TabIndex = 1;
            this.LabelAnkunftsort.Text = "Ankunftsort :";
            this.LabelAnkunftsort.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // comboBoxAbfahrtsort
            // 
            this.comboBoxAbfahrtsort.FormattingEnabled = true;
            this.comboBoxAbfahrtsort.Location = new System.Drawing.Point(12, 77);
            this.comboBoxAbfahrtsort.Name = "comboBoxAbfahrtsort";
            this.comboBoxAbfahrtsort.Size = new System.Drawing.Size(532, 39);
            this.comboBoxAbfahrtsort.TabIndex = 0;
            this.comboBoxAbfahrtsort.DropDown += new System.EventHandler(this.comboBoxAbfahrtsort_DropDown);
            this.comboBoxAbfahrtsort.SelectedIndexChanged += new System.EventHandler(this.comboBoxAbfahrtsort_SelectedIndexChanged);
            // 
            // Tafel
            // 
            this.Tafel.Controls.Add(this.buttonStandort);
            this.Tafel.Controls.Add(this.buttonAbfahrtsplan);
            this.Tafel.Controls.Add(this.comboBox1);
            this.Tafel.Controls.Add(this.labelStationsort);
            this.Tafel.Location = new System.Drawing.Point(10, 48);
            this.Tafel.Name = "Tafel";
            this.Tafel.Padding = new System.Windows.Forms.Padding(3);
            this.Tafel.Size = new System.Drawing.Size(1531, 630);
            this.Tafel.TabIndex = 1;
            this.Tafel.Text = "Tafel";
            this.Tafel.UseVisualStyleBackColor = true;
            // 
            // buttonStandort
            // 
            this.buttonStandort.Location = new System.Drawing.Point(1236, 17);
            this.buttonStandort.Name = "buttonStandort";
            this.buttonStandort.Size = new System.Drawing.Size(289, 82);
            this.buttonStandort.TabIndex = 3;
            this.buttonStandort.Text = "Stations Standort anzeigen";
            this.buttonStandort.UseVisualStyleBackColor = true;
            // 
            // buttonAbfahrtsplan
            // 
            this.buttonAbfahrtsplan.Location = new System.Drawing.Point(923, 17);
            this.buttonAbfahrtsplan.Name = "buttonAbfahrtsplan";
            this.buttonAbfahrtsplan.Size = new System.Drawing.Size(289, 82);
            this.buttonAbfahrtsplan.TabIndex = 2;
            this.buttonAbfahrtsplan.Text = "Abfahrtsplan anzeigen";
            this.buttonAbfahrtsplan.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(14, 60);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(869, 39);
            this.comboBox1.TabIndex = 1;
            // 
            // labelStationsort
            // 
            this.labelStationsort.AutoSize = true;
            this.labelStationsort.Location = new System.Drawing.Point(8, 8);
            this.labelStationsort.Name = "labelStationsort";
            this.labelStationsort.Size = new System.Drawing.Size(296, 32);
            this.labelStationsort.TabIndex = 0;
            this.labelStationsort.Text = "Stationsort Eingeben :";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 439);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(1492, 566);
            this.treeView1.TabIndex = 11;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1569, 1067);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "BlyatBB APP";
            this.tabControl1.ResumeLayout(false);
            this.Stationsauswahl.ResumeLayout(false);
            this.Stationsauswahl.PerformLayout();
            this.Tafel.ResumeLayout(false);
            this.Tafel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Stationsauswahl;
        private System.Windows.Forms.TabPage Tafel;
        private System.Windows.Forms.Label LabelAnkunftsort;
        private System.Windows.Forms.ComboBox comboBoxAnkunftsort;
        private System.Windows.Forms.Label LabelAbfahrtsort;
        private System.Windows.Forms.Label labelZeit;
        private System.Windows.Forms.Label labelDatumAbfahrt;
        private System.Windows.Forms.Button buttonVerbindungsuchen;
        private System.Windows.Forms.DateTimePicker dateTimePickerAbfahrt;
        private System.Windows.Forms.TextBox textBoxZeiteingabe;
        private System.Windows.Forms.DateTimePicker dateTimePickerdateTimePickerAnkunft;
        private System.Windows.Forms.Label labelDatumAnkunft;
        private System.Windows.Forms.Button buttonStandort;
        private System.Windows.Forms.Button buttonAbfahrtsplan;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelStationsort;
        public System.Windows.Forms.ComboBox comboBoxAbfahrtsort;
        private System.Windows.Forms.TreeView treeView1;
    }
}


namespace ProjektÜK318
{
    public partial class Anzeigetafel
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listBoxStationBoard = new System.Windows.Forms.ListBox();
            this.dataGrid_Ausgabe = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Ausgabe)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 61);
            this.label1.TabIndex = 1;
            this.label1.Text = "Von:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1939, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 61);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nach:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1107, 31);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 61);
            this.label3.TabIndex = 3;
            this.label3.Text = "Dauer:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(307, 31);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(334, 61);
            this.label4.TabIndex = 4;
            this.label4.Text = "Abfahrtszeit:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1464, 31);
            this.label5.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(373, 61);
            this.label5.TabIndex = 5;
            this.label5.Text = "Anakunftszeit:";
            // 
            // listBoxStationBoard
            // 
            this.listBoxStationBoard.FormattingEnabled = true;
            this.listBoxStationBoard.ItemHeight = 31;
            this.listBoxStationBoard.Location = new System.Drawing.Point(0, 110);
            this.listBoxStationBoard.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.listBoxStationBoard.Name = "listBoxStationBoard";
            this.listBoxStationBoard.Size = new System.Drawing.Size(3374, 1895);
            this.listBoxStationBoard.TabIndex = 0;
            // 
            // dataGrid_Ausgabe
            // 
            this.dataGrid_Ausgabe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid_Ausgabe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_Ausgabe.Location = new System.Drawing.Point(26, 181);
            this.dataGrid_Ausgabe.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.dataGrid_Ausgabe.Name = "dataGrid_Ausgabe";
            this.dataGrid_Ausgabe.RowHeadersWidth = 102;
            this.dataGrid_Ausgabe.Size = new System.Drawing.Size(2133, 1056);
            this.dataGrid_Ausgabe.TabIndex = 6;
            this.dataGrid_Ausgabe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_Ausgabe_CellContentClick);
            // 
            // Anzeigetafel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(4065, 2461);
            this.Controls.Add(this.dataGrid_Ausgabe);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxStationBoard);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Anzeigetafel";
            this.Text = "Anzeigetafel";
            this.Load += new System.EventHandler(this.Anzeigetafel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Ausgabe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBoxStationBoard;
        private System.Windows.Forms.DataGridView dataGrid_Ausgabe;
    }
}
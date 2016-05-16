namespace PHP_SRS
{
    partial class frmViewAllSales
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
            this.dataGridSales = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSales)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridSales
            // 
            this.dataGridSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSales.Location = new System.Drawing.Point(12, 49);
            this.dataGridSales.Name = "dataGridSales";
            this.dataGridSales.Size = new System.Drawing.Size(950, 490);
            this.dataGridSales.TabIndex = 3;
            this.dataGridSales.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridSales_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 31);
            this.button1.TabIndex = 2;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmViewAllSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 564);
            this.Controls.Add(this.dataGridSales);
            this.Controls.Add(this.button1);
            this.Name = "frmViewAllSales";
            this.Text = "frmViewAllSales";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridSales;
        private System.Windows.Forms.Button button1;
    }
}
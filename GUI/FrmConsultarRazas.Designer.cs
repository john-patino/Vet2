namespace GUI
{
    partial class FrmConsultarRazas
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
            this.dgvRazas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRazas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRazas
            // 
            this.dgvRazas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRazas.Location = new System.Drawing.Point(73, 48);
            this.dgvRazas.Name = "dgvRazas";
            this.dgvRazas.RowHeadersWidth = 51;
            this.dgvRazas.RowTemplate.Height = 24;
            this.dgvRazas.Size = new System.Drawing.Size(581, 300);
            this.dgvRazas.TabIndex = 0;
            // 
            // FrmConsultarRazas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvRazas);
            this.Name = "FrmConsultarRazas";
            this.Text = "FrmConsultarRazas";
            this.Load += new System.EventHandler(this.FrmConsultarRazas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRazas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRazas;
    }
}
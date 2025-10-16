namespace GUI
{
    partial class FrmConsultarVeterinario
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
            this.dgvVeterinarios = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVeterinarios)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVeterinarios
            // 
            this.dgvVeterinarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVeterinarios.Location = new System.Drawing.Point(21, 32);
            this.dgvVeterinarios.Name = "dgvVeterinarios";
            this.dgvVeterinarios.RowHeadersWidth = 51;
            this.dgvVeterinarios.RowTemplate.Height = 24;
            this.dgvVeterinarios.Size = new System.Drawing.Size(489, 179);
            this.dgvVeterinarios.TabIndex = 0;
            // 
            // FrmConsultarVeterinario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 262);
            this.Controls.Add(this.dgvVeterinarios);
            this.Name = "FrmConsultarVeterinario";
            this.Text = "FrmConsultarVeterinario";
            this.Load += new System.EventHandler(this.FrmConsultarVeterinario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVeterinarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVeterinarios;
    }
}
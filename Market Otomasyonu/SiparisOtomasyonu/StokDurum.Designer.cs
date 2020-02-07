namespace SiparisOtomasyonu
{
    partial class StokDurum
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
            this.dataGridViewsStokDurum = new System.Windows.Forms.DataGridView();
            this.btnStokDurum = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewsStokDurum)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewsStokDurum
            // 
            this.dataGridViewsStokDurum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewsStokDurum.Location = new System.Drawing.Point(12, -1);
            this.dataGridViewsStokDurum.Name = "dataGridViewsStokDurum";
            this.dataGridViewsStokDurum.RowHeadersWidth = 51;
            this.dataGridViewsStokDurum.RowTemplate.Height = 24;
            this.dataGridViewsStokDurum.Size = new System.Drawing.Size(790, 357);
            this.dataGridViewsStokDurum.TabIndex = 0;
            // 
            // btnStokDurum
            // 
            this.btnStokDurum.BackColor = System.Drawing.Color.Transparent;
            this.btnStokDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStokDurum.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnStokDurum.Location = new System.Drawing.Point(73, 373);
            this.btnStokDurum.Name = "btnStokDurum";
            this.btnStokDurum.Size = new System.Drawing.Size(245, 65);
            this.btnStokDurum.TabIndex = 19;
            this.btnStokDurum.Text = "Aç";
            this.btnStokDurum.UseVisualStyleBackColor = false;
            this.btnStokDurum.Click += new System.EventHandler(this.btnStokDurum_Click);
            // 
            // StokDurum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStokDurum);
            this.Controls.Add(this.dataGridViewsStokDurum);
            this.Name = "StokDurum";
            this.Text = "StokDurum";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewsStokDurum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewsStokDurum;
        private System.Windows.Forms.Button btnStokDurum;
    }
}
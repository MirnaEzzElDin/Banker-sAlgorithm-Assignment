namespace banker_s_algo
{
    partial class AlgorithmStepsForm
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
            this.txtSteps = new System.Windows.Forms.TextBox();
            this.dgvNeed = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNeed)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSteps
            // 
            this.txtSteps.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtSteps.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSteps.Location = new System.Drawing.Point(0, 216);
            this.txtSteps.Multiline = true;
            this.txtSteps.Name = "txtSteps";
            this.txtSteps.ReadOnly = true;
            this.txtSteps.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSteps.Size = new System.Drawing.Size(1221, 362);
            this.txtSteps.TabIndex = 0;
            // 
            // dgvNeed
            // 
            this.dgvNeed.AllowUserToAddRows = false;
            this.dgvNeed.AllowUserToDeleteRows = false;
            this.dgvNeed.AllowUserToResizeColumns = false;
            this.dgvNeed.AllowUserToResizeRows = false;
            this.dgvNeed.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvNeed.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvNeed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNeed.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvNeed.Location = new System.Drawing.Point(0, 0);
            this.dgvNeed.Name = "dgvNeed";
            this.dgvNeed.RowHeadersWidth = 51;
            this.dgvNeed.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvNeed.RowTemplate.Height = 29;
            this.dgvNeed.Size = new System.Drawing.Size(1221, 210);
            this.dgvNeed.TabIndex = 1;
            // 
            // AlgorithmStepsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 578);
            this.Controls.Add(this.txtSteps);
            this.Controls.Add(this.dgvNeed);
            this.Name = "AlgorithmStepsForm";
            this.Text = "AlgorithmStepsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtSteps;
        private DataGridView dgvNeed;
    }
}
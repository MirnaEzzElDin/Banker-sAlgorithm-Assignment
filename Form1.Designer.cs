namespace banker_s_algo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtAllocation = new System.Windows.Forms.TextBox();
            this.txtRequest = new System.Windows.Forms.TextBox();
            this.txtMaximum = new System.Windows.Forms.TextBox();
            this.numProcessId = new System.Windows.Forms.NumericUpDown();
            this.btnCheckRequest = new System.Windows.Forms.Button();
            this.labelAllocation = new System.Windows.Forms.Label();
            this.labelMaxNeed = new System.Windows.Forms.Label();
            this.RequestR = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ProcessID = new System.Windows.Forms.Label();
            this.txtTotalResources = new System.Windows.Forms.TextBox();
            this.totalR = new System.Windows.Forms.Label();
            this.txtAvailable = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numProcessId)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAllocation
            // 
            this.txtAllocation.Location = new System.Drawing.Point(12, 220);
            this.txtAllocation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAllocation.Multiline = true;
            this.txtAllocation.Name = "txtAllocation";
            this.txtAllocation.Size = new System.Drawing.Size(316, 177);
            this.txtAllocation.TabIndex = 0;
            // 
            // txtRequest
            // 
            this.txtRequest.Location = new System.Drawing.Point(15, 448);
            this.txtRequest.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRequest.Name = "txtRequest";
            this.txtRequest.Size = new System.Drawing.Size(268, 27);
            this.txtRequest.TabIndex = 4;
            // 
            // txtMaximum
            // 
            this.txtMaximum.Location = new System.Drawing.Point(508, 214);
            this.txtMaximum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaximum.Multiline = true;
            this.txtMaximum.Name = "txtMaximum";
            this.txtMaximum.Size = new System.Drawing.Size(367, 183);
            this.txtMaximum.TabIndex = 1;
            // 
            // numProcessId
            // 
            this.numProcessId.Location = new System.Drawing.Point(18, 529);
            this.numProcessId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numProcessId.Name = "numProcessId";
            this.numProcessId.Size = new System.Drawing.Size(160, 27);
            this.numProcessId.TabIndex = 3;
            // 
            // btnCheckRequest
            // 
            this.btnCheckRequest.Location = new System.Drawing.Point(521, 448);
            this.btnCheckRequest.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCheckRequest.Name = "btnCheckRequest";
            this.btnCheckRequest.Size = new System.Drawing.Size(252, 95);
            this.btnCheckRequest.TabIndex = 5;
            this.btnCheckRequest.Text = "Check Request";
            this.btnCheckRequest.UseVisualStyleBackColor = true;
            this.btnCheckRequest.Click += new System.EventHandler(this.btnCheckRequest_Click);
            // 
            // labelAllocation
            // 
            this.labelAllocation.AutoSize = true;
            this.labelAllocation.Location = new System.Drawing.Point(9, 195);
            this.labelAllocation.Name = "labelAllocation";
            this.labelAllocation.Size = new System.Drawing.Size(147, 20);
            this.labelAllocation.TabIndex = 6;
            this.labelAllocation.Text = "Resources Allocation";
            // 
            // labelMaxNeed
            // 
            this.labelMaxNeed.AutoSize = true;
            this.labelMaxNeed.Location = new System.Drawing.Point(517, 189);
            this.labelMaxNeed.Name = "labelMaxNeed";
            this.labelMaxNeed.Size = new System.Drawing.Size(77, 20);
            this.labelMaxNeed.TabIndex = 7;
            this.labelMaxNeed.Text = "Max Need";
            // 
            // RequestR
            // 
            this.RequestR.AutoSize = true;
            this.RequestR.Location = new System.Drawing.Point(18, 416);
            this.RequestR.Name = "RequestR";
            this.RequestR.Size = new System.Drawing.Size(126, 20);
            this.RequestR.TabIndex = 8;
            this.RequestR.Text = "Resource Request";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(521, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Available Resources";
            // 
            // ProcessID
            // 
            this.ProcessID.AutoSize = true;
            this.ProcessID.Location = new System.Drawing.Point(18, 496);
            this.ProcessID.Name = "ProcessID";
            this.ProcessID.Size = new System.Drawing.Size(77, 20);
            this.ProcessID.TabIndex = 10;
            this.ProcessID.Text = "Process ID";
            // 
            // txtTotalResources
            // 
            this.txtTotalResources.Location = new System.Drawing.Point(16, 93);
            this.txtTotalResources.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTotalResources.Name = "txtTotalResources";
            this.txtTotalResources.Size = new System.Drawing.Size(323, 27);
            this.txtTotalResources.TabIndex = 0;
            // 
            // totalR
            // 
            this.totalR.AutoSize = true;
            this.totalR.Location = new System.Drawing.Point(15, 68);
            this.totalR.Name = "totalR";
            this.totalR.Size = new System.Drawing.Size(112, 20);
            this.totalR.TabIndex = 12;
            this.totalR.Text = "Total Resources";
            // 
            // txtAvailable
            // 
            this.txtAvailable.Location = new System.Drawing.Point(524, 93);
            this.txtAvailable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAvailable.Name = "txtAvailable";
            this.txtAvailable.Size = new System.Drawing.Size(351, 27);
            this.txtAvailable.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(16, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(852, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Note: Please Enter the total Resources and the available resources as a space sep" +
    "arated vector (1 3 2) with no spaces at the end ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(12, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(767, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Note: Please Enter the Resources Allocation and the Max Need as space separated M" +
    "atrices with rows and columns";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label3.Location = new System.Drawing.Point(12, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(616, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = " each row is separated by \"enter\" and columns are separated by spaces with no ext" +
    "ra spaces";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label5.Location = new System.Drawing.Point(21, 580);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Starting from P0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 654);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.totalR);
            this.Controls.Add(this.txtTotalResources);
            this.Controls.Add(this.ProcessID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RequestR);
            this.Controls.Add(this.labelMaxNeed);
            this.Controls.Add(this.labelAllocation);
            this.Controls.Add(this.btnCheckRequest);
            this.Controls.Add(this.numProcessId);
            this.Controls.Add(this.txtMaximum);
            this.Controls.Add(this.txtAvailable);
            this.Controls.Add(this.txtRequest);
            this.Controls.Add(this.txtAllocation);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Banker\'s Algorithm";
            ((System.ComponentModel.ISupportInitialize)(this.numProcessId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtAllocation;
        private TextBox txtRequest;
        private TextBox txtMaximum;
        private NumericUpDown numProcessId;
        private Button btnCheckRequest;
        private Label labelAllocation;
        private Label labelMaxNeed;
        private Label RequestR;
        private Label label4;
        private Label ProcessID;
        private TextBox txtTotalResources;
        private Label totalR;
        private Label lblSystemState;
        private TextBox txtAvailable;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
    }
}
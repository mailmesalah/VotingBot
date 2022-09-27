namespace WFAVotingBot
{
    partial class FMain
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
            this.buttonStart = new System.Windows.Forms.Button();
            this.TextBoxLink = new System.Windows.Forms.TextBox();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.LabelStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.ColumnSerialNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnProxyAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TextBoxParameters = new System.Windows.Forms.TextBox();
            this.TextBoxMethod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.StatusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(12, 240);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(155, 38);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // TextBoxLink
            // 
            this.TextBoxLink.Location = new System.Drawing.Point(12, 214);
            this.TextBoxLink.Name = "TextBoxLink";
            this.TextBoxLink.Size = new System.Drawing.Size(781, 20);
            this.TextBoxLink.TabIndex = 5;
            this.TextBoxLink.Text = "http://en.wikipedia.org/wiki/Main_Page";
            // 
            // StatusStrip
            // 
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel,
            this.LabelStatus});
            this.StatusStrip.Location = new System.Drawing.Point(0, 330);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(805, 22);
            this.StatusStrip.TabIndex = 6;
            // 
            // StatusLabel
            // 
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // LabelStatus
            // 
            this.LabelStatus.Name = "LabelStatus";
            this.LabelStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // DGV
            // 
            this.DGV.AllowUserToDeleteRows = false;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnSerialNo,
            this.ColumnProxyAddress,
            this.ColumnStatus});
            this.DGV.Location = new System.Drawing.Point(12, 25);
            this.DGV.Name = "DGV";
            this.DGV.ReadOnly = true;
            this.DGV.RowHeadersVisible = false;
            this.DGV.Size = new System.Drawing.Size(781, 183);
            this.DGV.TabIndex = 7;
            // 
            // ColumnSerialNo
            // 
            this.ColumnSerialNo.Frozen = true;
            this.ColumnSerialNo.HeaderText = "Serial No";
            this.ColumnSerialNo.Name = "ColumnSerialNo";
            this.ColumnSerialNo.ReadOnly = true;
            // 
            // ColumnProxyAddress
            // 
            this.ColumnProxyAddress.Frozen = true;
            this.ColumnProxyAddress.HeaderText = "Proxy Address";
            this.ColumnProxyAddress.Name = "ColumnProxyAddress";
            this.ColumnProxyAddress.ReadOnly = true;
            this.ColumnProxyAddress.Width = 450;
            // 
            // ColumnStatus
            // 
            this.ColumnStatus.Frozen = true;
            this.ColumnStatus.HeaderText = "Status";
            this.ColumnStatus.Name = "ColumnStatus";
            this.ColumnStatus.ReadOnly = true;
            this.ColumnStatus.Width = 200;
            // 
            // TextBoxParameters
            // 
            this.TextBoxParameters.Location = new System.Drawing.Point(523, 247);
            this.TextBoxParameters.Name = "TextBoxParameters";
            this.TextBoxParameters.Size = new System.Drawing.Size(244, 20);
            this.TextBoxParameters.TabIndex = 8;
            // 
            // TextBoxMethod
            // 
            this.TextBoxMethod.Location = new System.Drawing.Point(523, 273);
            this.TextBoxMethod.Name = "TextBoxMethod";
            this.TextBoxMethod.Size = new System.Drawing.Size(244, 20);
            this.TextBoxMethod.TabIndex = 9;
            this.TextBoxMethod.Text = "POST";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(435, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Parameters";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(435, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Method";
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 352);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxMethod);
            this.Controls.Add(this.TextBoxParameters);
            this.Controls.Add(this.DGV);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.TextBoxLink);
            this.Controls.Add(this.buttonStart);
            this.Name = "FMain";
            this.Text = "Simple Voting Bot";
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.TextBox TextBoxLink;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel LabelStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSerialNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProxyAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStatus;
        private System.Windows.Forms.TextBox TextBoxParameters;
        private System.Windows.Forms.TextBox TextBoxMethod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}


namespace SDRSharp.GpredictConnector
{
    partial class Controlpanel
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

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkBoxEnable = new System.Windows.Forms.CheckBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelFrequency = new System.Windows.Forms.Label();
            this.labelDescserverStat = new System.Windows.Forms.Label();
            this.labelDescLastFrq = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.LinkLabel();
            this.checkBoxForceFreq = new System.Windows.Forms.CheckBox();
            this.groupBoxFreqOffset = new System.Windows.Forms.GroupBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxFreqOffset.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBoxEnable
            // 
            this.checkBoxEnable.AutoSize = true;
            this.checkBoxEnable.Location = new System.Drawing.Point(3, 3);
            this.checkBoxEnable.Name = "checkBoxEnable";
            this.checkBoxEnable.Size = new System.Drawing.Size(58, 17);
            this.checkBoxEnable.TabIndex = 1;
            this.checkBoxEnable.Text = "enable";
            this.checkBoxEnable.UseVisualStyleBackColor = true;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(83, 23);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(44, 13);
            this.labelStatus.TabIndex = 2;
            this.labelStatus.Text = "standby";
            // 
            // labelFrequency
            // 
            this.labelFrequency.AutoSize = true;
            this.labelFrequency.Location = new System.Drawing.Point(83, 36);
            this.labelFrequency.Name = "labelFrequency";
            this.labelFrequency.Size = new System.Drawing.Size(16, 13);
            this.labelFrequency.TabIndex = 4;
            this.labelFrequency.Text = "---";
            // 
            // labelDescserverStat
            // 
            this.labelDescserverStat.AutoSize = true;
            this.labelDescserverStat.Location = new System.Drawing.Point(0, 23);
            this.labelDescserverStat.Name = "labelDescserverStat";
            this.labelDescserverStat.Size = new System.Drawing.Size(77, 13);
            this.labelDescserverStat.TabIndex = 5;
            this.labelDescserverStat.Text = "Server Status :";
            // 
            // labelDescLastFrq
            // 
            this.labelDescLastFrq.AutoSize = true;
            this.labelDescLastFrq.Location = new System.Drawing.Point(3, 36);
            this.labelDescLastFrq.Name = "labelDescLastFrq";
            this.labelDescLastFrq.Size = new System.Drawing.Size(74, 13);
            this.labelDescLastFrq.TabIndex = 7;
            this.labelDescLastFrq.Text = "Last Freq set :";
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.Location = new System.Drawing.Point(83, 3);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(28, 13);
            this.labelVersion.TabIndex = 8;
            this.labelVersion.TabStop = true;
            this.labelVersion.Text = "v0.0";
            // 
            // checkBoxForceFreq
            // 
            this.checkBoxForceFreq.AutoSize = true;
            this.checkBoxForceFreq.Location = new System.Drawing.Point(6, 53);
            this.checkBoxForceFreq.Name = "checkBoxForceFreq";
            this.checkBoxForceFreq.Size = new System.Drawing.Size(124, 17);
            this.checkBoxForceFreq.TabIndex = 9;
            this.checkBoxForceFreq.Text = "force to gpredict freq";
            this.checkBoxForceFreq.UseVisualStyleBackColor = true;
            // 
            // groupBoxFreqOffset
            // 
            this.groupBoxFreqOffset.Controls.Add(this.label1);
            this.groupBoxFreqOffset.Controls.Add(this.maskedTextBox1);
            this.groupBoxFreqOffset.Location = new System.Drawing.Point(4, 77);
            this.groupBoxFreqOffset.Name = "groupBoxFreqOffset";
            this.groupBoxFreqOffset.Size = new System.Drawing.Size(154, 56);
            this.groupBoxFreqOffset.TabIndex = 10;
            this.groupBoxFreqOffset.TabStop = false;
            this.groupBoxFreqOffset.Text = "frequency offset";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(6, 20);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "kHz";
            // 
            // Controlpanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxFreqOffset);
            this.Controls.Add(this.checkBoxForceFreq);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.labelDescLastFrq);
            this.Controls.Add(this.labelDescserverStat);
            this.Controls.Add(this.labelFrequency);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.checkBoxEnable);
            this.MinimumSize = new System.Drawing.Size(185, 55);
            this.Name = "Controlpanel";
            this.Size = new System.Drawing.Size(185, 167);
            this.groupBoxFreqOffset.ResumeLayout(false);
            this.groupBoxFreqOffset.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelFrequency;
        private System.Windows.Forms.Label labelDescserverStat;
        private System.Windows.Forms.Label labelDescLastFrq;
        public System.Windows.Forms.CheckBox checkBoxEnable;
        public System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.LinkLabel labelVersion;
        private System.Windows.Forms.CheckBox checkBoxForceFreq;
        private System.Windows.Forms.GroupBox groupBoxFreqOffset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}

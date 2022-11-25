namespace SGBTK0.View
{
    partial class WorkControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.WorkNameLabel = new System.Windows.Forms.Label();
            this.MaterialCostLabel = new System.Windows.Forms.Label();
            this.WorkTimeLabel = new System.Windows.Forms.Label();
            this.CheckBox = new System.Windows.Forms.CheckBox();
            this.WorkTimeCost = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // WorkNameLabel
            // 
            this.WorkNameLabel.AutoSize = true;
            this.WorkNameLabel.Location = new System.Drawing.Point(3, 13);
            this.WorkNameLabel.Name = "WorkNameLabel";
            this.WorkNameLabel.Size = new System.Drawing.Size(76, 16);
            this.WorkNameLabel.TabIndex = 0;
            this.WorkNameLabel.Text = "WorkName";
            // 
            // MaterialCostLabel
            // 
            this.MaterialCostLabel.AutoSize = true;
            this.MaterialCostLabel.Location = new System.Drawing.Point(199, 14);
            this.MaterialCostLabel.Name = "MaterialCostLabel";
            this.MaterialCostLabel.Size = new System.Drawing.Size(82, 16);
            this.MaterialCostLabel.TabIndex = 1;
            this.MaterialCostLabel.Text = "MaterialCost";
            // 
            // WorkTimeLabel
            // 
            this.WorkTimeLabel.AutoSize = true;
            this.WorkTimeLabel.Location = new System.Drawing.Point(281, 14);
            this.WorkTimeLabel.Name = "WorkTimeLabel";
            this.WorkTimeLabel.Size = new System.Drawing.Size(70, 16);
            this.WorkTimeLabel.TabIndex = 2;
            this.WorkTimeLabel.Text = "WorkTime";
            // 
            // CheckBox
            // 
            this.CheckBox.AutoSize = true;
            this.CheckBox.Location = new System.Drawing.Point(387, 15);
            this.CheckBox.Name = "CheckBox";
            this.CheckBox.Size = new System.Drawing.Size(18, 17);
            this.CheckBox.TabIndex = 3;
            this.CheckBox.UseVisualStyleBackColor = true;
            this.CheckBox.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // WorkTimeCost
            // 
            this.WorkTimeCost.AutoSize = true;
            this.WorkTimeCost.Location = new System.Drawing.Point(414, 14);
            this.WorkTimeCost.Name = "WorkTimeCost";
            this.WorkTimeCost.Size = new System.Drawing.Size(38, 15);
            this.WorkTimeCost.TabIndex = 4;
            this.WorkTimeCost.Text = "TimeCost";
            // 
            // WorkControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.WorkTimeCost);
            this.Controls.Add(this.WorkTimeLabel);
            this.Controls.Add(this.CheckBox);
            this.Controls.Add(this.MaterialCostLabel);
            this.Controls.Add(this.WorkNameLabel);
            this.Name = "WorkControl";
            this.Size = new System.Drawing.Size(597, 43);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WorkNameLabel;
        private System.Windows.Forms.Label MaterialCostLabel;
        private System.Windows.Forms.Label WorkTimeLabel;
        private System.Windows.Forms.CheckBox CheckBox;
        private System.Windows.Forms.Label WorkTimeCost;
    }
}

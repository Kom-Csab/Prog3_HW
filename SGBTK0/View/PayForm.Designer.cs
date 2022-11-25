namespace SGBTK0.View
{
    partial class PayForm
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
            this.ServiceOrderCountLabel = new System.Windows.Forms.Label();
            this.MaterialCostTitleLabel = new System.Windows.Forms.Label();
            this.WorkCostTitleLabel = new System.Windows.Forms.Label();
            this.Sum = new System.Windows.Forms.Label();
            this.ServiceOrderCount = new System.Windows.Forms.Label();
            this.MaterialCostNumber = new System.Windows.Forms.Label();
            this.WorkCostNumber = new System.Windows.Forms.Label();
            this.SumOfPayment = new System.Windows.Forms.Label();
            this.CountOfServicesLabel = new System.Windows.Forms.Label();
            this.CountOfServices = new System.Windows.Forms.Label();
            this.TotalWorkTimeLabel = new System.Windows.Forms.Label();
            this.TotalWorkTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ServiceOrderCountLabel
            // 
            this.ServiceOrderCountLabel.AutoSize = true;
            this.ServiceOrderCountLabel.Location = new System.Drawing.Point(53, 53);
            this.ServiceOrderCountLabel.Name = "ServiceOrderCountLabel";
            this.ServiceOrderCountLabel.Size = new System.Drawing.Size(130, 16);
            this.ServiceOrderCountLabel.TabIndex = 0;
            this.ServiceOrderCountLabel.Text = "Munkalapok száma: ";
            // 
            // MaterialCostTitleLabel
            // 
            this.MaterialCostTitleLabel.AutoSize = true;
            this.MaterialCostTitleLabel.Location = new System.Drawing.Point(53, 128);
            this.MaterialCostTitleLabel.Name = "MaterialCostTitleLabel";
            this.MaterialCostTitleLabel.Size = new System.Drawing.Size(96, 16);
            this.MaterialCostTitleLabel.TabIndex = 1;
            this.MaterialCostTitleLabel.Text = "Anyagköltség: ";
            // 
            // WorkCostTitleLabel
            // 
            this.WorkCostTitleLabel.AutoSize = true;
            this.WorkCostTitleLabel.Location = new System.Drawing.Point(53, 167);
            this.WorkCostTitleLabel.Name = "WorkCostTitleLabel";
            this.WorkCostTitleLabel.Size = new System.Drawing.Size(94, 16);
            this.WorkCostTitleLabel.TabIndex = 2;
            this.WorkCostTitleLabel.Text = "Munkaköltség:";
            // 
            // Sum
            // 
            this.Sum.AutoSize = true;
            this.Sum.Location = new System.Drawing.Point(53, 248);
            this.Sum.Name = "Sum";
            this.Sum.Size = new System.Drawing.Size(73, 16);
            this.Sum.TabIndex = 3;
            this.Sum.Text = "Összesen: ";
            // 
            // ServiceOrderCount
            // 
            this.ServiceOrderCount.AutoSize = true;
            this.ServiceOrderCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ServiceOrderCount.Location = new System.Drawing.Point(201, 53);
            this.ServiceOrderCount.Name = "ServiceOrderCount";
            this.ServiceOrderCount.Size = new System.Drawing.Size(14, 16);
            this.ServiceOrderCount.TabIndex = 4;
            this.ServiceOrderCount.Text = "0";
            // 
            // MaterialCostNumber
            // 
            this.MaterialCostNumber.AutoSize = true;
            this.MaterialCostNumber.ForeColor = System.Drawing.Color.Green;
            this.MaterialCostNumber.Location = new System.Drawing.Point(201, 128);
            this.MaterialCostNumber.Name = "MaterialCostNumber";
            this.MaterialCostNumber.Size = new System.Drawing.Size(14, 16);
            this.MaterialCostNumber.TabIndex = 5;
            this.MaterialCostNumber.Text = "0";
            // 
            // WorkCostNumber
            // 
            this.WorkCostNumber.AutoSize = true;
            this.WorkCostNumber.ForeColor = System.Drawing.Color.Red;
            this.WorkCostNumber.Location = new System.Drawing.Point(201, 167);
            this.WorkCostNumber.Name = "WorkCostNumber";
            this.WorkCostNumber.Size = new System.Drawing.Size(14, 16);
            this.WorkCostNumber.TabIndex = 6;
            this.WorkCostNumber.Text = "0";
            // 
            // SumOfPayment
            // 
            this.SumOfPayment.AutoSize = true;
            this.SumOfPayment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.SumOfPayment.Location = new System.Drawing.Point(201, 248);
            this.SumOfPayment.Name = "SumOfPayment";
            this.SumOfPayment.Size = new System.Drawing.Size(14, 16);
            this.SumOfPayment.TabIndex = 7;
            this.SumOfPayment.Text = "0";
            // 
            // CountOfServicesLabel
            // 
            this.CountOfServicesLabel.AutoSize = true;
            this.CountOfServicesLabel.Location = new System.Drawing.Point(53, 91);
            this.CountOfServicesLabel.Name = "CountOfServicesLabel";
            this.CountOfServicesLabel.Size = new System.Drawing.Size(100, 16);
            this.CountOfServicesLabel.TabIndex = 8;
            this.CountOfServicesLabel.Text = "Munkák száma:";
            // 
            // CountOfServices
            // 
            this.CountOfServices.AutoSize = true;
            this.CountOfServices.Location = new System.Drawing.Point(201, 91);
            this.CountOfServices.Name = "CountOfServices";
            this.CountOfServices.Size = new System.Drawing.Size(14, 16);
            this.CountOfServices.TabIndex = 9;
            this.CountOfServices.Text = "0";
            // 
            // TotalWorkTimeLabel
            // 
            this.TotalWorkTimeLabel.AutoSize = true;
            this.TotalWorkTimeLabel.Location = new System.Drawing.Point(53, 207);
            this.TotalWorkTimeLabel.Name = "TotalWorkTimeLabel";
            this.TotalWorkTimeLabel.Size = new System.Drawing.Size(110, 16);
            this.TotalWorkTimeLabel.TabIndex = 10;
            this.TotalWorkTimeLabel.Text = "Teljes munkaidő:";
            // 
            // TotalWorkTime
            // 
            this.TotalWorkTime.AutoSize = true;
            this.TotalWorkTime.Location = new System.Drawing.Point(201, 207);
            this.TotalWorkTime.Name = "TotalWorkTime";
            this.TotalWorkTime.Size = new System.Drawing.Size(14, 16);
            this.TotalWorkTime.TabIndex = 11;
            this.TotalWorkTime.Text = "0";
            // 
            // PayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 301);
            this.Controls.Add(this.TotalWorkTime);
            this.Controls.Add(this.TotalWorkTimeLabel);
            this.Controls.Add(this.CountOfServices);
            this.Controls.Add(this.CountOfServicesLabel);
            this.Controls.Add(this.SumOfPayment);
            this.Controls.Add(this.WorkCostNumber);
            this.Controls.Add(this.MaterialCostNumber);
            this.Controls.Add(this.ServiceOrderCount);
            this.Controls.Add(this.Sum);
            this.Controls.Add(this.WorkCostTitleLabel);
            this.Controls.Add(this.MaterialCostTitleLabel);
            this.Controls.Add(this.ServiceOrderCountLabel);
            this.Name = "PayForm";
            this.Text = "Fizetés";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ServiceOrderCountLabel;
        private System.Windows.Forms.Label MaterialCostTitleLabel;
        private System.Windows.Forms.Label WorkCostTitleLabel;
        private System.Windows.Forms.Label Sum;
        private System.Windows.Forms.Label ServiceOrderCount;
        private System.Windows.Forms.Label MaterialCostNumber;
        private System.Windows.Forms.Label WorkCostNumber;
        private System.Windows.Forms.Label SumOfPayment;
        private System.Windows.Forms.Label CountOfServicesLabel;
        private System.Windows.Forms.Label CountOfServices;
        private System.Windows.Forms.Label TotalWorkTimeLabel;
        private System.Windows.Forms.Label TotalWorkTime;
    }
}
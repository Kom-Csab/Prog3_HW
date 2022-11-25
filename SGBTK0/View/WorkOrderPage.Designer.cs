namespace SGBTK0
{
    partial class WorkOrderPage
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
            this.WorkOptionsTable = new System.Windows.Forms.TableLayoutPanel();
            this.MaterialCostTitleLabel = new System.Windows.Forms.Label();
            this.WorkTimeLabel = new System.Windows.Forms.Label();
            this.WorkCostTitleLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.WorkCostNumber = new System.Windows.Forms.Label();
            this.MaterialCostNumber = new System.Windows.Forms.Label();
            this.WorkCostTitleLabel1 = new System.Windows.Forms.Label();
            this.MaterialCostTitleLabel1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // WorkOptionsTable
            // 
            this.WorkOptionsTable.AutoScroll = true;
            this.WorkOptionsTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.WorkOptionsTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.WorkOptionsTable.ColumnCount = 1;
            this.WorkOptionsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.14027F));
            this.WorkOptionsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.92308F));
            this.WorkOptionsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.66063F));
            this.WorkOptionsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.036144F));
            this.WorkOptionsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 137F));
            this.WorkOptionsTable.Location = new System.Drawing.Point(1, 34);
            this.WorkOptionsTable.Name = "WorkOptionsTable";
            this.WorkOptionsTable.RowCount = 1;
            this.WorkOptionsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 263F));
            this.WorkOptionsTable.Size = new System.Drawing.Size(602, 254);
            this.WorkOptionsTable.TabIndex = 0;
            // 
            // MaterialCostTitleLabel
            // 
            this.MaterialCostTitleLabel.AutoSize = true;
            this.MaterialCostTitleLabel.Location = new System.Drawing.Point(196, 17);
            this.MaterialCostTitleLabel.Name = "MaterialCostTitleLabel";
            this.MaterialCostTitleLabel.Size = new System.Drawing.Size(90, 16);
            this.MaterialCostTitleLabel.TabIndex = 1;
            this.MaterialCostTitleLabel.Text = "Anyagköltség";
            // 
            // WorkTimeLabel
            // 
            this.WorkTimeLabel.AutoSize = true;
            this.WorkTimeLabel.Location = new System.Drawing.Point(292, 17);
            this.WorkTimeLabel.Name = "WorkTimeLabel";
            this.WorkTimeLabel.Size = new System.Drawing.Size(66, 16);
            this.WorkTimeLabel.TabIndex = 2;
            this.WorkTimeLabel.Text = "Munkaidő";
            // 
            // WorkCostTitleLabel
            // 
            this.WorkCostTitleLabel.AutoSize = true;
            this.WorkCostTitleLabel.Location = new System.Drawing.Point(423, 17);
            this.WorkCostTitleLabel.Name = "WorkCostTitleLabel";
            this.WorkCostTitleLabel.Size = new System.Drawing.Size(61, 16);
            this.WorkCostTitleLabel.TabIndex = 3;
            this.WorkCostTitleLabel.Text = "Munkadíj";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SaveBtn);
            this.panel1.Controls.Add(this.WorkCostNumber);
            this.panel1.Controls.Add(this.MaterialCostNumber);
            this.panel1.Controls.Add(this.WorkCostTitleLabel1);
            this.panel1.Controls.Add(this.MaterialCostTitleLabel1);
            this.panel1.Location = new System.Drawing.Point(1, 294);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(651, 54);
            this.panel1.TabIndex = 3;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(480, 20);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(98, 27);
            this.SaveBtn.TabIndex = 4;
            this.SaveBtn.Text = "Rögzítés";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // WorkCostNumber
            // 
            this.WorkCostNumber.AutoSize = true;
            this.WorkCostNumber.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.WorkCostNumber.ForeColor = System.Drawing.Color.Red;
            this.WorkCostNumber.Location = new System.Drawing.Point(375, 21);
            this.WorkCostNumber.Name = "WorkCostNumber";
            this.WorkCostNumber.Size = new System.Drawing.Size(41, 23);
            this.WorkCostNumber.TabIndex = 3;
            this.WorkCostNumber.Text = "0 Ft";
            // 
            // MaterialCostNumber
            // 
            this.MaterialCostNumber.AutoSize = true;
            this.MaterialCostNumber.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.MaterialCostNumber.ForeColor = System.Drawing.Color.Green;
            this.MaterialCostNumber.Location = new System.Drawing.Point(145, 21);
            this.MaterialCostNumber.Name = "MaterialCostNumber";
            this.MaterialCostNumber.Size = new System.Drawing.Size(41, 23);
            this.MaterialCostNumber.TabIndex = 2;
            this.MaterialCostNumber.Text = "0 Ft";
            // 
            // WorkCostTitleLabel1
            // 
            this.WorkCostTitleLabel1.AutoSize = true;
            this.WorkCostTitleLabel1.Location = new System.Drawing.Point(291, 25);
            this.WorkCostTitleLabel1.Name = "WorkCostTitleLabel1";
            this.WorkCostTitleLabel1.Size = new System.Drawing.Size(67, 16);
            this.WorkCostTitleLabel1.TabIndex = 1;
            this.WorkCostTitleLabel1.Text = "Munkadíj: ";
            // 
            // MaterialCostTitleLabel1
            // 
            this.MaterialCostTitleLabel1.AutoSize = true;
            this.MaterialCostTitleLabel1.Location = new System.Drawing.Point(29, 25);
            this.MaterialCostTitleLabel1.Name = "MaterialCostTitleLabel1";
            this.MaterialCostTitleLabel1.Size = new System.Drawing.Size(96, 16);
            this.MaterialCostTitleLabel1.TabIndex = 0;
            this.MaterialCostTitleLabel1.Text = "Anyagköltség: ";
            // 
            // WorkOrderPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 349);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.WorkCostTitleLabel);
            this.Controls.Add(this.WorkTimeLabel);
            this.Controls.Add(this.MaterialCostTitleLabel);
            this.Controls.Add(this.WorkOptionsTable);
            this.Name = "WorkOrderPage";
            this.Text = "Munkalap készítése";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WorkOrderPage_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel WorkOptionsTable;
        private System.Windows.Forms.Label MaterialCostTitleLabel;
        private System.Windows.Forms.Label WorkTimeLabel;
        private System.Windows.Forms.Label WorkCostTitleLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label WorkCostNumber;
        private System.Windows.Forms.Label MaterialCostNumber;
        private System.Windows.Forms.Label WorkCostTitleLabel1;
        private System.Windows.Forms.Label MaterialCostTitleLabel1;
        private System.Windows.Forms.Button SaveBtn;
    }
}
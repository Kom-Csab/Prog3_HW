namespace SGBTK0
{
    partial class BusinessCardForm
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
            this.CloseBn = new System.Windows.Forms.Button();
            this.ActualTimeLabel = new System.Windows.Forms.Label();
            this.NeptunKódLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CloseBn
            // 
            this.CloseBn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CloseBn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CloseBn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.CloseBn.Location = new System.Drawing.Point(100, 202);
            this.CloseBn.Name = "CloseBn";
            this.CloseBn.Size = new System.Drawing.Size(93, 42);
            this.CloseBn.TabIndex = 0;
            this.CloseBn.Text = "Ok";
            this.CloseBn.UseVisualStyleBackColor = true;
            this.CloseBn.Click += new System.EventHandler(this.CloseBn_Click);
            // 
            // ActualTimeLabel
            // 
            this.ActualTimeLabel.AutoSize = true;
            this.ActualTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ActualTimeLabel.Location = new System.Drawing.Point(33, 67);
            this.ActualTimeLabel.Name = "ActualTimeLabel";
            this.ActualTimeLabel.Size = new System.Drawing.Size(112, 20);
            this.ActualTimeLabel.TabIndex = 1;
            this.ActualTimeLabel.Text = "Jelenlegi idő: ";
            // 
            // NeptunKódLabel
            // 
            this.NeptunKódLabel.AutoSize = true;
            this.NeptunKódLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.NeptunKódLabel.Location = new System.Drawing.Point(33, 123);
            this.NeptunKódLabel.Name = "NeptunKódLabel";
            this.NeptunKódLabel.Size = new System.Drawing.Size(169, 20);
            this.NeptunKódLabel.TabIndex = 2;
            this.NeptunKódLabel.Text = "Neptun kód: SGBTK0";
            // 
            // BusinessCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 256);
            this.Controls.Add(this.NeptunKódLabel);
            this.Controls.Add(this.ActualTimeLabel);
            this.Controls.Add(this.CloseBn);
            this.Name = "BusinessCardForm";
            this.Text = "Névjegy";
            this.Load += new System.EventHandler(this.BusinessCardForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseBn;
        private System.Windows.Forms.Label ActualTimeLabel;
        private System.Windows.Forms.Label NeptunKódLabel;
    }
}
using SGBTK0.Model;
using SGBTK0.View;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SGBTK0
{
    public partial class WorkOrderPage : Form
    {
        bool ConfirmedClose;
        WorkContainer worksFromFile;
        ServiceOrder OrderOfServices;
        Dictionary<CheckBox, Work> ServiceOptions;

        public WorkOrderPage(WorkContainer worksFromFile)
        {
            this.worksFromFile = worksFromFile;
            OrderOfServices = new ServiceOrder();
            ServiceOptions = new Dictionary<CheckBox, Work>();
            InitializeComponent();
            FillTable();
        }

        public void FillTable()
        {
            WorkOptionsTable.RowStyles.Clear();
            WorkOptionsTable.RowCount = ServiceOptions.Count;
            for (int i = 0; i < WorkOptionsTable.RowStyles.Count; i++)
            {
                WorkOptionsTable.RowStyles[i].SizeType = SizeType.Absolute;
                WorkOptionsTable.RowStyles[i].Height = 200;
            }
            WorkOptionsTable.Refresh();

            int row = 0;
            for (int i = 0; i < worksFromFile.Count(); i++)
            {
                var work = new WorkControl(worksFromFile[i]);
                work.SelectionChanged += CheckBox_IsChanged;
                WorkOptionsTable.Controls.Add(work, 0, row++);
            }
        }

        private void CheckBox_IsChanged(WorkControl work, bool isChecked)
        {
            if (isChecked)
            {
                OrderOfServices.AddItem(work.Work);
                WorkCostNumber.Text = OrderOfServices.TotalTimeCost.ToString() + "Ft";
                MaterialCostNumber.Text = OrderOfServices.TotalMaterialCost.ToString() + "Ft";
            }
            else
            {
                OrderOfServices.DeleteItem(work.Work);
                WorkCostNumber.Text = OrderOfServices.TotalTimeCost.ToString() + "Ft";
                MaterialCostNumber.Text = OrderOfServices.TotalMaterialCost.ToString() + "Ft";
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (!ConfirmedClose)
            {
                if (MessageBox.Show("Rögzíti a munkalapot?", "Figyelem!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    MainForm.OrderedServices.Add(OrderOfServices);
                    ConfirmedClose = true;
                    Close();
                }
            }
        }

        private void WorkOrderPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!ConfirmedClose)
            {
                if (MessageBox.Show("Biztossan ki szeretne lépni mentés nélkül?", "Figyelem!", MessageBoxButtons.YesNo) != DialogResult.Yes)
                {
                    e.Cancel = true;
                }
                else
                {
                    ConfirmedClose = true;
                    this.Close();
                }
            }
        }
    }
}

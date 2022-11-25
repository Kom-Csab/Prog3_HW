using SGBTK0.Model;
using System;
using System.Windows.Forms;

namespace SGBTK0.View
{
    public partial class WorkControl : UserControl
    {
        public Work Work
        {
            get; private set;
        }

        public delegate void SelectionChangedHandler(WorkControl sender, bool isChecked);

        public WorkControl(Work work)
        {
            InitializeComponent();
            WorkNameLabel.Text = work.Name;
            MaterialCostLabel.Text = work.MaterialCost.ToString();
            CheckBox.Checked = false;
            WorkTimeLabel.Text = work.Time;
            WorkTimeCost.Text = work.TimeCost.ToString();
            WorkTimeCost.Visible = false;
            Work = work;
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            //Ha az adott munkát kiválasztjuk, megjelenik az utolsó oszlopban percre pontosan kiszámolva a munkadíj
            if (CheckBox.Checked)
            {
                WorkTimeCost.Visible = true;
            }
            else
            {
                WorkTimeCost.Visible = false;
            }

            SelectionChanged?.Invoke(this, CheckBox.Checked);
        }

        public event SelectionChangedHandler SelectionChanged;
    }
}

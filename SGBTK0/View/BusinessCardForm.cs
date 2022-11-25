using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGBTK0
{
    public partial class BusinessCardForm : Form
    {
        public BusinessCardForm()
        {
            InitializeComponent();
        }

        private async void BusinessCardForm_Load(object sender, EventArgs e)
        {
            while (true)
            {
                ActualTimeLabel.Text = String.Format("Jelenlegi idő: {0}", DateTime.Now.ToShortDateString());
                await Task.Delay(1000);
            }
        }

        private void CloseBn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

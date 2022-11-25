using SGBTK0.Model;
using SGBTK0.View;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace SGBTK0
{
    public partial class MainForm : Form
    {
        WorkContainer workContainer;

        public static List<ServiceOrder> OrderedServices
        {
            get; private set;
        }

        public MainForm()
        {
            OrderedServices = new List<ServiceOrder>();
            workContainer = new WorkContainer();
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SetControlsVisibility(false); //Munkalap és fizetés opció ne legyen látható az adatok betöltése előtt
        }

        private void fájlBetöltéseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog OfD = new OpenFileDialog
            {
                Multiselect = false,
                InitialDirectory = Application.StartupPath,
            };

            if(OfD.ShowDialog() == DialogResult.OK)
            {

                try
                {
                    workContainer.Reset(); //Így elkerülhető, hogy ugyanazokat az adatokat többször is betöltsük
                    OrderedServices.Clear(); //Újonnan betöltött adatok esetében, az előzőekben rögzített munkalapoknak
                                            //is törlődniük kell

                    workContainer.AddWorks(new Loader<Work>().LoadFromFile(OfD.FileName, Parser.Parse));

                    munkalapToolStripMenuItem.Enabled = true;
                    fizetésToolStripMenuItem.Enabled = true;
                }
                catch(IOException io)
                {
                    MessageBox.Show(io.ToString());
                }
                catch(NullReferenceException nre)
                {
                    MessageBox.Show(nre.ToString());
                }
                catch(IndexOutOfRangeException iex)
                {
                    MessageBox.Show(iex.ToString());
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

                SetControlsVisibility(true);
            }
        }

        private void munkalapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new WorkOrderPage(workContainer).ShowDialog();
        }

        private void fizetésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new PayForm(OrderedServices).ShowDialog();
        }

        private void névjegyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new BusinessCardForm().ShowDialog();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Biztossan ki szeretne lépni?", "Figyelem!", MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

        private void kilépésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SetControlsVisibility(bool visibility)
        {
            munkalapToolStripMenuItem.Visible = visibility;
            fizetésToolStripMenuItem.Visible = visibility;
        }
    }
}

using SGBTK0.Model;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SGBTK0.View
{
    public partial class PayForm : Form
    {
        int TotalMaterialCost;
        int TotalTimeCost;
        int CountOfOrders;
        int CountOfWorks;
        int EntireWorkTime;
        int TotalPayment;

        public PayForm(List<ServiceOrder> OrderedServices)
        {
            CountOfOrders = OrderedServices.Count;
            CountOfWorks = (from ServiceOrder in OrderedServices select ServiceOrder.Count).Sum();
            TotalMaterialCost = (from ServiceOrder in OrderedServices select ServiceOrder.TotalMaterialCost).Sum();
            TotalTimeCost = (from ServiceOrder in OrderedServices select ServiceOrder.TotalTimeCost).Sum();
            EntireWorkTime = (from ServiceOrder in OrderedServices select ServiceOrder.TotalMinutes).Sum();
            TotalPayment = TotalMaterialCost + TotalTimeCost;
            InitializeComponent();
            LoadLabels();
            ClearWorkSheets(OrderedServices); //Megjelenítés után törli a rögzített munkalapokat
        }

        private void LoadLabels()
        {
            ServiceOrderCount.Text = CountOfOrders.ToString() + " db";
            CountOfServices.Text = CountOfWorks.ToString() + " db";
            MaterialCostNumber.Text = TotalMaterialCost.ToString() + " Ft";
            WorkCostNumber.Text = TotalTimeCost.ToString() + " Ft";
            SumOfPayment.Text = TotalPayment.ToString() + " Ft";

            var TotalHours = (EntireWorkTime >= 60 ? EntireWorkTime / 60 + "ó " : "");
            var TotalMinutes = (EntireWorkTime % 60 + "p");
            TotalWorkTime.Text = TotalHours + TotalMinutes;
        }

        private void ClearWorkSheets(List<ServiceOrder> OrderedServices)
        {
            OrderedServices.Clear();
        }
    }
}

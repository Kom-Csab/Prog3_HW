using System.Collections.Generic;
using System.Linq;

namespace SGBTK0.Model
{
    public class ServiceOrder
    {
        List<Work> OrderedServices;

        #region Element Access
        public int Count
        {
            get
            {
                return OrderedServices.Count;
            }
        }

        public Work this[int index]
        {
            get
            {
                return OrderedServices[index];
            }
        }
        #endregion

        public int TotalTimeCost
        {
            get
            {
                var minutes = (from order in OrderedServices
                               select order.Minutes + order.Hours * 60).Sum();

                //Minden megkezdett fél óra számít
                int totalHalfHours = (minutes % 30 == 0 ? minutes / 30 : minutes / 30 + 1);

                return totalHalfHours * 7500;
            }
        }

        public int TotalMaterialCost
        {
            get
            {
                return (from item in OrderedServices
                        select item.MaterialCost).Sum();
            }
        }

        public int TotalMinutes
        {
            get
            {
                return (from Work in OrderedServices select Work.Minutes).Sum();
            }
        }

        public ServiceOrder()
        {
            OrderedServices = new List<Work>();
        }

        public void AddItem(Work work)
        {
            OrderedServices.Add(work);
        }

        public void DeleteItem(Work work)
        {
            OrderedServices.Remove(work);
        }
    }
}

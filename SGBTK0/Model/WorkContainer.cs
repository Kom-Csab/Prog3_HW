using System.Collections.Generic;

namespace SGBTK0.Model
{
    public class WorkContainer
    {
        List<Work> workList;

        public WorkContainer()
        {
            this.workList = new List<Work>();
        }

        #region Element Access

        public int Count()
        {
            return workList.Count;
        }

        public Work this[int index]
        {
            get { return workList[index]; }
        }

        #endregion

        public void AddWorks(List<Work> worksFormFile)
        {
            workList.AddRange(worksFormFile);
        }

        public void Reset()
        {
            workList.Clear();
        }
    }
}

namespace SGBTK0.Model
{
    public class Work
    {
        public static double CostPerHour = 15000;

        int minutes;
        public string Name { get; private set; }
        public int Minutes
        {
            get
            {
                return minutes % 60;
            }
        }
        public int Hours
        {
            get
            {
                return minutes / 60;
            }
        }
        public int MaterialCost { get; private set; }
        public string Time
        {
            get
            {
                return $"{(Hours > 0 ? Hours + "ó " : "")}" +
                    $"{(Minutes >= 0 ? Minutes + "p" : "")}";
            }
        }
        public double TimeCost
        {
            get
            {
                double num = (minutes % 60 == 0 ? minutes / 60 : 60.0 / minutes);
                return CostPerHour/num;
            }
        }

        public Work(string Name, int minutes, int MaterialCost)
        {
            this.Name = Name;
            this.minutes = minutes;
            this.MaterialCost = MaterialCost;
        }
    }

}

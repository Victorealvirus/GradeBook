namespace GradeBook
{
    public class Stats
    {
        public double Avg;
        public double high;
        public double low;

        public Stats()
        {
            Avg = 0.0;
            high = double.MinValue;
            low = double.MaxValue;
        }

        public char Letter
        {
            get {
                switch (Avg)
                {
                    case var d when d >= 90.0:
                        return 'A';

                    case var d when d >= 80.0:
                        return 'B';

                    case var d when d >= 70.0:
                        return 'C';

                    case var d when d >= 60.0:
                        return 'D';

                    default:
                        return 'F';
                }
            }
        }
    }
}

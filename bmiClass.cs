namespace BMRandBMI
{
    public class bmiClass
    {
        public double metric(double kg, double m){
            return kg/m*m;
        }
        public double imperial(double lb, double inch){
            return (lb/inch*inch)*703;
        }
    }
}
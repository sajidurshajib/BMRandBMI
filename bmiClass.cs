namespace BMRandBMI
{
    public class bmiClass
    {
        public double metric(double kg, double m){
            return kg/(m*m);
        }
        public double imperial(double lb, double inch){
            return (lb/(inch*inch))*703;
        }
        public string bmiCondition(double yourBmi){
            string st="none";
            if(yourBmi <= 18.5){
                st="Underweight";
            }
            else if(yourBmi > 18.5 &&yourBmi <= 23.0){
                st="Healthy range";
            }
            else if(yourBmi > 23.0 && yourBmi <= 27.0){
                st="Over weight";
            }
            else if(yourBmi > 27){
                st="Obese";
            }
            return st;
        }
    }
}
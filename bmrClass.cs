namespace BMRandBMI
{
    public class bmrClass
    {
        public double metric(double weight, int heightcm, int age, int gender){
            double result=0;
            if(gender == 1){
                result=66.47+(13.75*weight)+(5.003*heightcm)-(6.755*age);
            }
            else if(gender == 0){
                result=655.1+(9.563*weight)+(1.85*heightcm)-(4.676*age);
            }
            return result;
        }

        public double imperial(double weight, int heightinch, int age, int gender){
            double result=0;
            if(gender == 1){
                result=66.47+(6.24*weight)+(12.7*heightinch)-(6.755*age);
            }
            else if(gender == 0){
                result=655.1+(4.35*weight)+(4.7*heightinch)-(4.7*age);
            }
            return result;
        }
    }
}
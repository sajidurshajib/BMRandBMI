using System;
namespace BMRandBMI
{
    public class bmrClass
    {
        public bmrClass(){
            Console.WriteLine("\n\tExercise\t\t\tExercise rate");
            Console.WriteLine("\t--------------------------------------------");
            Console.WriteLine("\tRarely exercise\t\t\t1.2");
            Console.WriteLine("\t1-3 days per week\t\t1.375");
            Console.WriteLine("\t3-5 days per week\t\t1.55");
            Console.WriteLine("\t5-7 days per week\t\t1.725");
            Console.WriteLine("\tExercise twice everyday\t\t1.9");
        }
        public double metric(double weight, double heightcm, int age, int gender){
            double result=0;
            if(gender == 1){
                result=66.47+(13.75*weight)+(5.003*heightcm)-(6.755*age);
            }
            else if(gender == 0){
                result=655.1+(9.563*weight)+(1.85*heightcm)-(4.676*age);
            }
            return result;
        }

        public double imperial(double weight, double heightinch, int age, int gender){
            double result=0;
            if(gender == 1){
                result=66.47+(6.24*weight)+(12.7*heightinch)-(6.755*age);
            }
            else if(gender == 0){
                result=655.1+(4.35*weight)+(4.7*heightinch)-(4.7*age);
            }
            return result;
        }
        public double bmrCondition(double yourBmr, double exercise){
            double caloriesBurn = yourBmr * exercise;
            return caloriesBurn;
        }
    }
}
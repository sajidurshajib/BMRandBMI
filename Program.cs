using System;

namespace BMRandBMI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\t.:|| Measured your Health... :) ||:.\n\n");
            Console.WriteLine("[1] BMI");
            Console.WriteLine("[2] BMR");
            Console.WriteLine("[3] Converter");
            Console.WriteLine("[4] Your weight on other planet(for Fun)");

            Console.Write("\n$option number: ");
            int select = Convert.ToInt32(Console.ReadLine());

            if(select == 1){
                Console.WriteLine();
                bmiClass bmi = new bmiClass();
                Console.WriteLine("[1] Metric (kg, m)");
                Console.WriteLine("[2] Imperial (lb, inch)");

                Console.Write("\n$option number: ");
                int standared = Convert.ToInt32(Console.ReadLine());
                
                Console.WriteLine();
                if(standared == 1){
                    Console.Write("Your weight in kg: ");
                    double yourWeight=Convert.ToDouble(Console.ReadLine());
                    Console.Write("Your height in meter: ");
                    double yourHeight=Convert.ToDouble(Console.ReadLine());
                
                    Console.WriteLine("\nStatus: You are {0}",bmi.bmiCondition(bmi.metric(yourWeight,yourHeight)));

                }
                else if(standared == 2){
                    Console.Write("Your weight in pound: ");
                    double yourWeight=Convert.ToDouble(Console.ReadLine());
                    Console.Write("Your height in inch: ");
                    double yourHeight=Convert.ToDouble(Console.ReadLine());
                
                    Console.WriteLine("\nStatus: You are {0}.",bmi.bmiCondition(bmi.imperial(yourWeight,yourHeight)));

                }
                else{
                    Console.WriteLine("Invalid option number...!");
                }
            }
            else if(select == 2){
                Console.WriteLine();
                bmrClass bmr = new bmrClass();
                Console.WriteLine();

                Console.WriteLine("[1] Metric (kg, m)");
                Console.WriteLine("[2] Imperial (lb, inch)");

                Console.Write("\n$option number: ");
                int selectMode=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Note: maintain standered [matric=kg,m and imperial=lb,inch]\n");

                Console.Write("Weight: ");
                double yourWeight=Convert.ToDouble(Console.ReadLine());

                Console.Write("Height: ");
                double yourHeight=Convert.ToDouble(Console.ReadLine());

                Console.Write("Age: ");
                int yourAge=Convert.ToInt32(Console.ReadLine());

                Console.Write("Gender [1=male] [0=female]: ");
                int yourGender=Convert.ToInt32(Console.ReadLine());

                Console.Write("Exercise rate: ");
                double exc=Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();

                if(selectMode==1){
                    Console.WriteLine("Calori needed: {0}",bmr.bmrCondition(bmr.metric(yourWeight,yourHeight,yourAge,yourGender),exc));
                }
                else if(selectMode==2){
                    Console.WriteLine("Calori needed: {0}",bmr.bmrCondition(bmr.imperial(yourWeight,yourHeight,yourAge,yourGender),exc));
                }
                else{
                    Console.WriteLine("You have only 2 option. Use 1 or 2");
                }

            }
            else if(select == 3){
                converter cn = new converter();
                Console.WriteLine("\n\tConverter section\n");
                Console.WriteLine("[1] foot >> inch >> meter");
                Console.WriteLine("[2] kg >> pound");

                Console.WriteLine();
                Console.Write("$option number: ");
                int convertOption = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                if(convertOption == 1){
                    Console.Write("Foot:");
                    int ft=Convert.ToInt32(Console.ReadLine());
                    Console.Write("Inch:");
                    int inch=Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine();
                    Console.WriteLine("{0}\'{1} fit",ft,inch);
                    Console.WriteLine("{0} inch",cn.footToinch(ft)+inch);
                    Console.WriteLine("{0} meter",cn.inchTometer(cn.footToinch(ft)+inch));
                }
                else if(convertOption == 2){
                    Console.WriteLine();
                    Console.Write("kg: ");
                    int kg= Convert.ToInt32(Console.ReadLine());
                    
                    Console.WriteLine("Pound : {0} lb",cn.kgTopound(kg));
                }
                else{
                    Console.WriteLine("Invalid option number...!");
                }

            }
            else if(select == 4){
                anotherPlanet ano = new anotherPlanet();
                Console.Write("\nYour weight on earth (kg): ");
                double youOnEarth= Convert.ToDouble(Console.ReadLine());
                Console.Write("Planet Code: ");
                double surfaceCode= Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Your alien weight: {0} kg",ano.alienWeight(youOnEarth,surfaceCode));
            }
            else{
                Console.WriteLine("\nInvalid option number...!");
            }

        Console.WriteLine("\n\nTerminated...\n\n");
        }
    }
}

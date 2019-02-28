namespace BMRandBMI
{
    public class converter
    {
        public double kgTopound(double kg){
            return kg*2.20462;
        }
        public double poundTokg(int p){
            return p*0.453592;
        } 
        public int footToinch(int f){
            return f*12;
        }
        public double inchTometer(int i){
            return i*0.0254;
        }
        public double inchTocenti(int i){
            return i/0.39370;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace IdealWeight
{
    class DataUser
    {
        int height, wieght;

        public void Set_height(int h)
        {
            if (h> 0)
                height = h;
        }

        public void Set_wieght(int w)
        {
            if (w > 0)
                wieght = w;
        }

        public double Ideal_Weight()
        {
            double resul;
            resul = (height - 100) -((height-150)/2);
            return resul;
        }

        public double IMT()
        {
            double h;
            h = wieght / (height*0.01 * height*0.01);
            return h;
        }


        public string Status_IMT()
        {
            string str = "";
            double f = IMT();
            if(f<16) { str = "Дефицит массы тела"; }
            else if((f>16)&&(f<18.5)) { str = "Недостаточная масса тела"; }
            else if ((f > 18.5) && (f < 24.99)) { str = "Норма"; }
            else if ((f > 25) && (f < 35)) { str = "Избыточная масса тела"; }
            else if ((f > 30) && (f < 35)) { str = "Ожирение первой степени";} 
            else if ((f > 35) && (f < 40)) { str = "Ожирение второй степени"; }
            else if (f > 40) { str = "Ожирение третьей степени"; }
            return str;
        }
    }
}

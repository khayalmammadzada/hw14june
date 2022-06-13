using System;
namespace hw14junetask2
{
    public class Milk:Product
    {
        public double FatPercent;
        Milk[] milks = new Milk[0];
        public void AddMilk(Milk milk)
        {
            Array.Resize(ref milks, milks.Length + 1);
            milks[milks.Length - 1] = milk;
        }


    }
}

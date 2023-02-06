using System;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {
            drum baraban = new drum(48);
            guitar gitara = new guitar(5);
            trumpet truba = new trumpet(7.4f);
            Tool[] tools = {baraban, gitara, truba };
            for (int i = 0; i < tools.Length; i++)
            {
                tools[i].play();

            }
        }
    }
    public interface Tool
    {

        void play()
        {
            
        }
        ////////////////////////////////////////
        ////////////////////////////////////////
        ////////////////////////////////////////
        ////////////////////////////////////////
        ////////////////////////////////////////
        //НЕЛЬЗЯ ПРИСВОИТЬ ПЕРЕМЕННУЮ ИНТЕРФЕЙСУ
        ////////////////////////////////////////
        ////////////////////////////////////////
        ////////////////////////////////////////
        ////////////////////////////////////////
        ////////////////////////////////////////
        ////////////////////////////////////////
    }
    public class guitar : Tool
    {
        public sbyte Str;
        public guitar(sbyte str)
        {
            Str = str;
        }
        public void play()
        {
            Console.WriteLine("Играет гитара " + "с количеством струн " + "'" + Str + "'");
        }
    }
    

    public class drum : Tool
    {
        public int Size;
        public drum(int size)
        {
            Size = size;
        }
        public void play()
        {
            Console.WriteLine("Играет барабан " + "размером " + "'" + Size + "'");
        }
    }
    public class trumpet : Tool
    {
        public float Dm;
        public trumpet(float dm)
        {
            Dm = dm;
        }
        public void play()
        {
            Console.WriteLine("Играет труба " + "диаметром " + "'" + Dm + "'");
        }
    }
}

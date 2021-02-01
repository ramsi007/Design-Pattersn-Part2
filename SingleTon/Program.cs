using System;
using System.Threading;

namespace SingleTon
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i=1; i<=5; i++)
            {
            SingleTon s = SingleTon.GetInstance();
                s.Traiter("T"+i);
            }

        }
    }

    public class SingleTon
    {
        private static SingleTon singleTon = new SingleTon();
        private int Compteur;

        private SingleTon()
        {
            Console.WriteLine("instanciation du singleTon");
        }

        public static SingleTon GetInstance()
        {
            return singleTon;
        }

        public void Traiter(string TaskName)
        {
            Console.WriteLine("Traitement de la tâche " + TaskName);
            for(int i =0; i<5; i++)
            {
                try
                {
                    ++Compteur;
                    Console.WriteLine("..." + Compteur);
                    Thread.Sleep(1000);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }     
            }
            Console.WriteLine("fin de traitement de la tâche  " + TaskName + " Compteur : " + Compteur);
        }
    }
}

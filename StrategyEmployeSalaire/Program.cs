using System;

namespace StrategyEmployeSalaire
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new EmployeeMaroc("F1111", 3000);
            Employee emp2 = new EmployeeAlgerie("K84755", 4000);

            Console.WriteLine(emp1.getSalairebrutMensuel());
            Console.WriteLine(emp1.GetSalaireNetMensuel());

            Console.WriteLine(emp2.getSalairebrutMensuel());
            Console.WriteLine(emp2.GetSalaireNetMensuel());


            //Console.WriteLine(emp1.getSalairebrutMensuel());
            //Console.WriteLine(emp1.GetSalaireNetMensuel(new MarocIGR()));

            //Console.WriteLine(emp1.getSalairebrutMensuel());
            //Console.WriteLine(emp1.GetSalaireNetMensuel(new AlgerieIGR()));

            //Console.WriteLine(emp1.getSalairebrutMensuel());
            //Console.WriteLine(emp1.GetSalaireNetMensuel(new TunisieIGR()));
        }
    }

    //// Premier Solution en utilisant l'interface

    //public class Employee
    //{
    //    private string Cin;
    //    private float SalairebrutMensuel;

    //    public float getSalairebrutMensuel()
    //    {
    //        return this.SalairebrutMensuel;
    //    }

    //    public void setSalairebrutmensuel(float SalairebrutMensuel)
    //    {
    //        this.SalairebrutMensuel = SalairebrutMensuel;
    //    }
    //    public Employee()
    //    {

    //    }

    //    public Employee(string cin, float salaireM)
    //    {
    //        this.Cin = cin;
    //        this.SalairebrutMensuel = salaireM;
    //    }

    //    public float GetSalaireNetMensuel(StrategyIGR Sigr)
    //    {
    //        float igr = Sigr.CalculerIGR(this);
    //        float SalaireNetAnnuel = SalairebrutMensuel * 12 - igr;
    //        return SalaireNetAnnuel / 12;
    //    }
    //}

    //public interface StrategyIGR
    //{
    //    public float CalculerIGR(Employee emp);

    //}

    //public class MarocIGR : StrategyIGR
    //{
    //    //Employee emp = new Employee();

    //    public float CalculerIGR(Employee e)
    //    {
    //        float SalaireBrutAnnuel = e.getSalairebrutMensuel() * 12;
    //        float Taux = 15;
    //        return SalaireBrutAnnuel * Taux / 100;
    //    }
    //}

    //public class AlgerieIGR :StrategyIGR
    //{
    //    Employee emp = new Employee();
    //    public float CalculerIGR(Employee e)
    //    {
    //        float SalaireBrutAnnuel = e.getSalairebrutMensuel() * 12;
    //        float Taux = 20;
    //        return SalaireBrutAnnuel * Taux / 100;
    //    }
    //}

    //public class TunisieIGR : StrategyIGR
    //{
    //    Employee emp = new Employee();
    //    public float CalculerIGR(Employee e)
    //    {
    //        float SalaireBrutAnnuel = e.getSalairebrutMensuel() * 12;
    //        float Taux = 25;
    //        return SalaireBrutAnnuel * Taux / 100;
    //    }
    //}


    // Dexième solution en Utlisant la Classe abstraite


    public abstract class Employee
    {
        protected string Cin;
        protected float SalairebrutMensuel;

        public float getSalairebrutMensuel()
        {
            return this.SalairebrutMensuel;
        }

        public void setSalairebrutmensuel(float SalairebrutMensuel)
        {
            this.SalairebrutMensuel = SalairebrutMensuel;
        }

        public Employee(string cin, float salaireM)
        {
            this.Cin = cin;
            this.SalairebrutMensuel = salaireM;
        }

        public abstract float GetSalaireNetMensuel();
        //{
        //    float igr = Sigr.CalculerIGR(this);
        //    float SalaireNetAnnuel = SalairebrutMensuel * 12 - igr;
        //    return SalaireNetAnnuel / 12;
        //}
    }

    public class EmployeeMaroc : Employee
    {
        public EmployeeMaroc(string cin, float salaire):base(cin, salaire)
        {

        }

        public float CalculerIGR()
        {
            float SalaireBrutAnnuel = getSalairebrutMensuel() * 12;
            float Taux = 25;
            return SalaireBrutAnnuel * Taux / 100;
        }

        public override float GetSalaireNetMensuel()
        {
            float igr = CalculerIGR();
            float SalaireNetAnnuel = SalairebrutMensuel * 12 - igr;
            return SalaireNetAnnuel / 12;
        }
    }


    public class EmployeeAlgerie : Employee
    {
        public EmployeeAlgerie(string cin, float salaire) : base(cin, salaire)
        {

        }

        public float CalculerIGR()
        {
            float SalaireBrutAnnuel = getSalairebrutMensuel() * 12;
            float Taux = 25;
            return SalaireBrutAnnuel * Taux / 100;
        }

        public override float GetSalaireNetMensuel()
        {
            float igr = CalculerIGR();
            float SalaireNetAnnuel = SalairebrutMensuel * 12 - igr;
            return SalaireNetAnnuel / 12;
        }
    }
}

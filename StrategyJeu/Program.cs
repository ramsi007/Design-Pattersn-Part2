using System;

namespace StrategyJeu
{
    class Program
    {
        static void Main(string[] args)
        {
            Personnage chevalier  = new Chevalier();
            chevalier.SetArme(new ComportementPoignard());
            chevalier.Combattre();

            Personnage roi = new Roi();
            roi.SetArme(new ComportementArcEtFleche());
            roi.Combattre();

            Personnage reine = new Reine();
            reine.SetArme(new ComportementHache());
            reine.Combattre();

            Personnage troll = new Troll();
            troll.SetArme(new ComportementPoignard());
            troll.Combattre();
            Console.ReadKey();

        }
    }

    public abstract class Personnage
    {
        protected string Nom;
        protected int Score;
        protected ComportementArme Arme;
        public abstract void Combattre();

        public void SetArme(ComportementArme a)
        {
            this.Arme = a;
        }
    }

    public class Chevalier:Personnage
    {
        public Chevalier()
        {
            this.Arme = new ComportementArcEtFleche();
        }

        public override void Combattre()
        {
            Console.WriteLine("je suis un Chevalier ...");
            this.Arme.UtiliserArme();

        }
    }

    public class Roi : Personnage
    {


        public override void Combattre()
        {
            Console.WriteLine("je suis un roi");
            this.Arme.UtiliserArme();
        }
    }

    public class Reine : Personnage
    {
        public override void Combattre()
        {
            Console.WriteLine("je suis une reine");
            this.Arme.UtiliserArme();
        }
    }

    public class Troll : Personnage
    {
        public override void Combattre()
        {
            Console.WriteLine("je suis un troll");
            this.Arme.UtiliserArme();
        }
    }

    public interface ComportementArme
    {
        public void UtiliserArme();
    }


    public class ComportementHache : ComportementArme
    {
        public void UtiliserArme()
        {
            Console.WriteLine(" J'utilise L'arme Hache");
        }
    }

    public class ComportementArcEtFleche : ComportementArme
    {
        public void UtiliserArme()
        {
            Console.WriteLine(" J'utilise L'arme Arc et fleche");
        }
    }

    public class ComportementPoignard : ComportementArme
    {
        public void UtiliserArme()
        {
            Console.WriteLine(" J'utilise L'arme Poignard");
        }
    }

}

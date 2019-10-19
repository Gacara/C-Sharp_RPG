using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JDR
{
    public abstract class Monster
    {
        public bool isalive { get; private set; }

        public Monster()
        {
            isalive = true;
        }

        public abstract void Attaquer(Joueur joueur);
        public void Mourir()
        {
            isalive = false;
        }

    }

    public class creeps : Monster
    {
        public override void Attaquer(Joueur joueur)
        {

            if (isalive)
            joueur.SubitDegats(1);   

        }
    }


    public class boss : Monster
    {
        public override void Attaquer(Joueur joueur)
        {

            int demonstre = new Random().Next(1,7);

            Console.WriteLine(" Réaction du BOSS face à l'attaque : ");
            if (demonstre <= 4)
            {
                joueur.SubitDegats(demonstre);
                Console.WriteLine(" Tu te prends bagdad : il t'enlève " + demonstre + " hp");
                Console.WriteLine(" ");
                
            }
           

            if (demonstre > 4)
            {
                Console.WriteLine(" Attaque manquée.. la chance :)" );
                Console.WriteLine(" ");
               
            }
          


        }


    }



}

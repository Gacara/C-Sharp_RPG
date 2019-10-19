using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JDR
{
    public class Joueur
    {
        public int pointsdevie { get; private set; }
        public int nombredepoints = 0;
        public int gold = 750;
        public int epee = 1;
        public int monstres = 0;
        
        public bool isalive
        {
            get
            {
                if (pointsdevie>0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public Joueur()
        {
            pointsdevie = 10;
        }

        public void Attaque()
        {

        }
        public void IncrMonstre()
        {
            monstres++;
        }
        public void SubitDegats(int n)
        {
            pointsdevie -= n;
            if (pointsdevie < 0)
                pointsdevie = 0;
        }
        public void Heal(int h)
        {
            pointsdevie += h;
            if (pointsdevie > 10)
           pointsdevie = 10;
        }
    

        public void AttaqueCreeps(Monster monster, int epee)
        {
            if (pointsdevie > 0)
            {

                int dejoueur = new Random().Next(epee, 7);
                int demonstre = new Random().Next(1, 6);

                Console.WriteLine("\n Attaque du joueur contre le monstre : " + dejoueur + " contre " + demonstre);


                if (dejoueur > demonstre)
                {

                    Console.WriteLine("\n Le monstre meurt, vous gagnez 75 OR");
                    IncrMonstre();
                    gold += 75;
                }
                if (dejoueur == demonstre)
                {
                    Console.WriteLine("\n Oups, le monstre s'est echappé, vous repartez broucouille");
                }
                if (dejoueur < demonstre)
                {
                    Console.WriteLine("\n Diantre, le monstre vous mord et vous fait perdre 1 HP");
                    pointsdevie-= 1;


                }
                monster.Mourir();

                System.Threading.Thread.Sleep(2500);
                Console.Clear();
            } 
            else
            {
                Console.WriteLine("\n Vous êtes mort !");
                System.Threading.Thread.Sleep(3000);
                Console.Clear();
            }
               

        }


        public void AttaqueBoss(Monster monster, int epee)
        {
            
            int dejoueur = new Random().Next(epee, 7);
            int demonstre = new Random().Next(4, 7);


            Console.WriteLine("");
            Console.WriteLine(" Debut du tour : attaque du joueur contre le monstre : " + dejoueur + " contre " + demonstre);
            if (dejoueur > demonstre)
            {

              monster.Mourir();
                
            }
            if (dejoueur == demonstre)
            {
                Console.WriteLine(" Attaque non létale..");
            }

        }


    }
}

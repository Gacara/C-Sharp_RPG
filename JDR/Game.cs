using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace JDR
{
    class Game
    {


        public Game()
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\yourmusic.wav";
            player.Play();

            Console.Clear();
            Joueur Perso = new Joueur();


            
        /*  Console.WriteLine("\n \n Vous êtes un héros en quête de gloire");
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("\n Combattez des monstres, achetez vous des armes et tenter de vaincre le BOSS ! ");
            System.Threading.Thread.Sleep(4000);
            Console.Clear();
            Console.WriteLine("\n Les combats se déroulent en lançant des dés");
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("\n Plus votre arme est puissante, plus vous avez de chance de réussir votre coup");
            System.Threading.Thread.Sleep(4000);
            Console.WriteLine("\n Un coup réussi OS votre cible (même le BOSS), vous pouvez donc finir le jeu avec une arme low cost");
            System.Threading.Thread.Sleep(4000);
            Console.WriteLine("\n Tuez un maximum de petits monstres pour gagner de l'or ! Mais attention à votre barre de vie !");
            System.Threading.Thread.Sleep(4000);
            Console.Clear();
            Console.WriteLine("\n Vous commencez avec ces caractéristiques : \n \n" +
                " Vos points de vie : " + Perso.pointsdevie + "\n" +
                " Votre OR : " + Perso.gold + "\n");
            System.Threading.Thread.Sleep(6000);*/


        int nb = 0;
               string arme ="0";

                while (nb == 0)
            {
                

            
                int b = Perso.nombredepoints;
                Console.Clear();
                Console.WriteLine("\n PV : " + Perso.pointsdevie + "\n OR : " + Perso.gold + " \n EPEE : " + Perso.epee + " \n");

                Console.WriteLine("\n Vous avez 3 choix : \n");
                Console.WriteLine(" [1] Combattre des monstres ");
                Console.WriteLine(" [2] Marchand");
                Console.WriteLine(" [3] Vaincre le BOSS !");
                

                Console.WriteLine(" ");

                 string a = Console.ReadLine();
                  
                Console.WriteLine(" ");

                    switch (a)
                    {
                        case "1":
                        Console.Clear();

                        
                        for (int i=1; i<6; i++)
                        {
                            creeps e1 = new creeps();
                            
                            while (e1.isalive && Perso.pointsdevie > 0)
                            {
                                Console.WriteLine("\n PV : " + Perso.pointsdevie + "\n OR : " + Perso.gold + " \n");
                                Console.WriteLine("\n Monstre n " + i);
                                Perso.AttaqueCreeps(e1, Perso.epee);
                      
                            }
                            if (Perso.pointsdevie <= 0)
                            {

                                Console.WriteLine(" ");
                                Console.WriteLine(" Vous avez 0 hp, vous avez perdu");
                                System.Threading.Thread.Sleep(4000);
                                Console.Clear();
                                Console.WriteLine("\n Vous avez perdu \n");
                                Console.WriteLine(" PV restants " + Perso.pointsdevie +
                                "\n Vous avez tué : " + Perso.monstres + " monstres \n" +
                               " Or restant : " + Perso.gold + "\n" +
                                " Points : " + Perso.monstres * 2.5);
                                nb++;
                                break;
                            }


                        }
                        if(Perso.pointsdevie > 0)
                        Console.WriteLine("\n Vous avez combattu tous les monstres ! ");
                        System.Threading.Thread.Sleep(2000);

                        
                            break;

                        case "2":
                        Console.Clear();

                        Console.WriteLine("\n PV : " + Perso.pointsdevie + "\n OR : " + Perso.gold + 
                            "\n\n Bienvenue chez votre marchand d'armes préféré, que puis je faire pour vous ? \n \n" +
                           
                            " [0] 200 Or : Potion de soin ( +5 HP )\n \n" +
                            " [1] 1000 Or : Epée en mousse {2,6} \n" +
                            " [2] 1750 Or : Epée parfumée au bois de hêtre {3,6}\n" +
                            " [3] 2500 Or : Epée en adamantium {4,6} \n\n" +
                            " [4] Je cherche juste la sortie ! ") ;
                        arme = Console.ReadLine();
                        switch (arme){
                            case "0":
                                if (Perso.gold < 200)
                                {
                                    Console.Clear();
                                    Console.WriteLine("\n Or actuel : " + Perso.gold + "\n \n Vous n'avez pas assez d'argent, le vendeur vous jette dehors d'un coup de pied au fesses bien mérité ! \n");
                                    System.Threading.Thread.Sleep(4000);
                                    break;
                                }
                                if (Perso.pointsdevie == 10)
                                {
                                    Console.Clear();
                                    Console.WriteLine("\n Vous avez déjà vos 10 HP, sortez de là ! \n");
                                    System.Threading.Thread.Sleep(4000);
                                    break;
                                }

                                Perso.gold -= 200;
                                Perso.Heal(5);
                                Console.Clear();
                                Console.WriteLine("\n PV : " + Perso.pointsdevie );
                                System.Threading.Thread.Sleep(2000);
                                Console.WriteLine("\n Or actuel : " + Perso.gold + "\n \n Vous repartez de l'échoppe, ressourcé et plein d'énergie \n");
                                System.Threading.Thread.Sleep(4000);
                                break;
                            case "1":
                                if (Perso.gold < 1000)
                                {
                                    Console.Clear();
                                    Console.WriteLine("\n Or actuel : " + Perso.gold + "\n \n Vous n'avez pas assez d'argent, le vendeur vous jette dehors d'un coup de pied au fesses bien mérité ! \n");
                                    System.Threading.Thread.Sleep(4000);
                                    break;
                                }
                                Perso.epee = 1;
                                Perso.gold -= 1000;
                                Console.Clear();
                                Console.WriteLine("\n Or actuel : " + Perso.gold + "\n \n Vous repartez de l'échoppe, vous demandant si cette simple éponge fera l'affaire :/ \n");
                                System.Threading.Thread.Sleep(4000);
                                break;
                            case "2":
                                if (Perso.gold < 1750)
                                {
                                    Console.Clear();
                                    Console.WriteLine("\n Or actuel : " + Perso.gold + "\n \n Vous n'avez pas assez d'argent, le vendeur vous jette dehors d'un coup de pied au fesses bien mérité ! \n");
                                    System.Threading.Thread.Sleep(4000);
                                    break;
                                }
                                Perso.epee = 3;
                                Perso.gold -= 1750;
                                Console.Clear();
                                Console.WriteLine("\n Or actuel : " + Perso.gold + "\n \n Vous repartez de l'échoppe, votre brindille en poche \n");
                                System.Threading.Thread.Sleep(4000);
                                break;
                            case "3":
                                if (Perso.gold < 2500)
                                {
                                    Console.Clear();
                                    Console.WriteLine("\n Or actuel : " + Perso.gold + "\n \n Vous n'avez pas assez d'argent, le vendeur vous jette dehors d'un coup de pied au fesses bien mérité ! \n");
                                    System.Threading.Thread.Sleep(4000);
                                    break;
                                }
                                Perso.epee = 4;
                                Perso.gold -= 2500;
                                Console.Clear();
                                Console.WriteLine("\n Or actuel : " + Perso.gold + "\n \n Vous repartez de l'échoppe, nul monstre ne peut vous résister maintenant ! \n");
                                System.Threading.Thread.Sleep(2000);
                                break;
                            case "4":
                                Console.Clear();
                                Console.WriteLine("\n Or actuel : " + Perso.gold + "\n \n Trop pauvre ou simplement perdu, vous ressortez de l'échoppe. \n");
                                System.Threading.Thread.Sleep(2000);
                                break;

                        }
                        
                        break;

                    case "3":
                        Console.Clear();
                        if(arme == "0")
                        {
                            Console.WriteLine("\n Vous êtes trop faible pour vous attaquer au boss maintenant, achetez vous une arme avant !");
                            System.Threading.Thread.Sleep(3000);
                            Console.Clear();
                            break;
                        }
                        boss b1 = new boss();
                        int cpt = 0;
                            while (true)
                            {
                            cpt++;
                            Console.WriteLine("\n Tour n " + cpt);
                            System.Threading.Thread.Sleep(1000);
                            Perso.AttaqueBoss(b1, Perso.epee);
                                if (b1.isalive)
                                {
                                
                                b1.Attaquer(Perso);
                                    Console.WriteLine(" Vos HP : " + Perso.pointsdevie);
                                System.Threading.Thread.Sleep(4000);
                                Console.Clear();

                                if (Perso.pointsdevie <= 0)
                                    {

                                        Console.WriteLine(" ");
                                        Console.WriteLine("\n Vous avez 0 hp, vous avez perdu");
                                        System.Threading.Thread.Sleep(4000);
                                    Console.Clear();
                                    Console.WriteLine("\n Vous avez perdu \n");
                                    Console.WriteLine(" PV restants " + Perso.pointsdevie +
                                    "\n Vous avez tué : " + Perso.monstres + " monstres \n" +
                                   " Or restant : " + Perso.gold + "\n" +
                                    " Points : " + Perso.monstres * 2.5);
                                    nb++;
                                    break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine(" Le boss est vaincu !  Félicitation !\n \n");
                                    nb++;
                                 double points = Perso.monstres * 2.5 + 100;
                                    Console.WriteLine(" PV restants " + Perso.pointsdevie +
                                    "\n Vous avez tué : " +Perso.monstres + " monstres \n" +
                                    " Or restant : " + Perso.gold + "\n" +
                                    " Points : " + points);
                                    System.Threading.Thread.Sleep(4000);
                                    break;

                                }
                            }
                            break;

                    }
            }
        }
            }

        




    }
}

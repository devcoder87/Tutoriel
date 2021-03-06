﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lance la méthode pour choisir un personnage
            ChoisirPersonnage();
        }

        static void ChoisirPersonnage()
        {
            // On efface la console avant d'écrire dessus
            Console.Clear();

            // Affiche un texte sur plusieurs lignes
            Console.WriteLine(
                "Veuillez sélectionner un personnage" +
                "\n-------------------------------------" +
                "\n\n 1. Guerrier" +
                " \n 2. Magicien "
                );

            // Début de la saisie
            switch(Console.ReadKey().KeyChar)
            {
                // Si 1 est pressé... On passe à une autre méthode et on passe "Guerrier" en paramètre
                case '1': ConfirmerPersonnage("Guerrier"); break;

                // Si 2 est pressé... On passe à une autre méthode et on passe "Magicien" en paramètre
                case '2': ConfirmerPersonnage("Magicien");  break;
            }
            
        }

        // Méthode qui permet de confirmer le personnage choisi
        static void ConfirmerPersonnage(string joueur)
        {
            Console.Clear();
            Console.WriteLine(
                "Vous avez choisir le " + joueur +
                "\n\nQue voulez-vous faire ?" +
                "\n-------------------------" +
                "\n\n 1. Démarrer l'aventure " +
                "\n 2. Changer de personnage");

            switch (Console.ReadKey().KeyChar)
            {
                case '1': DemarrerHistoire(); break;
                case '2': ChoisirPersonnage(); break;
            }

        }

        // Méthode qui permet de démarrer l'histoire
        static void DemarrerHistoire()
        {
            Console.Clear();
            Console.WriteLine("Une belle aventure vous attend... Pressez une touche pour continuer");

            // Attend une saisie avant de poursuivre (= fermer l'appli)111111111111
            Console.ReadKey();
        }
    }
}

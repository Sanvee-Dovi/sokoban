using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Sokoban_project
{
    public class Jeu
    {
        // Enum etat 
        public enum Etat
        {
            Vide,
            Mur,
            Cible
        }

        //attribut grille qui represente la grille de jeu
        private Etat[,] grille;

        //attribut de type liste qui represente la liste des caisses qui sont des positions
        private List<Position> caisses;

        //les propriétés de caisses
        public List<Position> Caisses
        {
            get{return caisses ;}
        }

        //chaine de caratere contenant les symboles de la map
        static string grilleTxt = "..XXXXXX..XXX.oo.XXXX..o..o..XX........XXXX....XXX..XX.CXX...XXXC.XXX..X.CP.C.X..X......X..XXXXXXXX.";

        // attribut position qui represente la position du personage
        private Position personage;

        public Position Personnage
        {
            get{return personage ;}
        }

        public  void ToucheAppuyee(Key key)
        {
            Position newPos = new Position(personage.x, personage.y);

            CalculNewPos( newPos, key);

            if (CaseOk(newPos, key))
            {
                personage = newPos;
            }

        }

        private static void CalculNewPos(Position newPos, Key key)
        {
            switch (key)
            {
                case Key.Down:
                    newPos.x++;
                    break;
                case Key.Up:
                    newPos.x--;
                    break;
                case Key.Left:
                    newPos.y--;
                    break;
                case Key.Right:
                    newPos.y++;
                    break;
            }
        }

        private bool CaseOk(Position newPos, Key key)
        {
            //rencontre de mur 
           if(grille[newPos.x,newPos.y] == Etat.Mur)
            {
                return false;
            }

            //cas de caisse

            return true;
        }


        // constructeur de Jeu
        public Jeu()
        {
            this.grille = new Etat[10, 10];
            initcarte();

        }

        //fonction qui permet d'initialisation de la  carte

        private void initcarte()
        {
            //creation d'une liste de caisse
            caisses = new List<Position>(); 

            for (int ligne = 0; ligne < 10; ligne++)
            {
                for (int colonne = 0; colonne < 10; colonne++)
                {
                    switch (grilleTxt[ligne * 10 + colonne])
                    {
                        case '.':
                            grille[ligne, colonne] = Etat.Vide;
                            break;
                        case 'X':
                            grille[ligne, colonne] = Etat.Mur;
                            break;
                        case 'o':
                            grille[ligne, colonne] = Etat.Cible;
                            break;
                        case 'P':
                            grille[ligne, colonne] = Etat.Vide;
                            personage = new Position(ligne, colonne);
                            break;
                        case 'C':
                            caisses.Add(new Position(ligne, colonne));
                            grille[ligne, colonne] = Etat.Vide;
                            break;


                    }
                }
            }
        }

        public Etat  Case(int ligne, int colonne)
        {
            return grille[ligne,colonne];
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Sokoban_project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        Jeu jeu;
        public MainWindow()
        {
            InitializeComponent();
            jeu = new Jeu();

            Dessiner();

        }

        private void Dessiner()
        {
            DessinerCarte();
            DessinerCaisses();
            DessinerPersonnage();
        }

        private void DessinerPersonnage()
        {
            Rectangle r = new Rectangle();
            r.Width = 38;
            r.Height = 37;
            r.Margin = new Thickness(jeu.Personnage.y * 50 + 7, jeu.Personnage.x * 50 + 7,0,0);
            r.Fill = new ImageBrush(new BitmapImage(new Uri("images/perso.png", UriKind.Relative)));

            cnvMobiles.Children.Add(r);
        }

        private void DessinerCaisses()
        {
            foreach(Position pos in jeu.Caisses)
            {
                Rectangle r = new Rectangle();
                r.Width = 44;
                r.Height = 44;
                r.Margin = new Thickness(pos.y *50 + 4, pos.x *50 +4,0,0);

                r.Fill = new ImageBrush(new BitmapImage(new Uri("images/caisse.png", UriKind.Relative)));
                cnvMobiles.Children.Add(r);
            } 
        }

        private void DessinerCarte()
        {
            for(int ligne =0; ligne < 10; ligne++)
            {
                for(int colonne =0; colonne <10; colonne++)
                {
                    Rectangle r = new Rectangle();
                    r.Width = 50;
                    r.Height = 50;  
                    r.Margin = new Thickness(colonne*50,ligne*50,0,0);
                    switch (jeu.Case(ligne,colonne)){
                        case Jeu.Etat.Vide :
                            r.Fill = new ImageBrush(new BitmapImage(new Uri("images/sol.png", UriKind.Relative)));
                            break;
                        case Jeu.Etat.Mur :
                            r.Fill = new ImageBrush(new BitmapImage(new Uri("images/mur.png", UriKind.Relative)));
                            break;
                        case Jeu.Etat.Cible :
                            r.Fill = new ImageBrush(new BitmapImage(new Uri("images/cible.png", UriKind.Relative)));
                            break;

                    }
                   
                    cnvGrille.Children.Add(r);
                }
            }
        }
    }
}

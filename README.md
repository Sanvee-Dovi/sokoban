# SOKOBAN
***
## Sanvee Cédric DOVI

***
## Explication du Projet sokoban
ce projet  consiste à la création du célèbre jeu Sokoban , avec les différents outils de dévéloppement ci dessous.

***

### Outils de devéloppement 
- [ ] C#
- [ ] Microsoft Visual Code 2022
- [ ] Microsoft Blend 
- [ ] .NET
  
***


## Partie 1 : Mise en place de l'interface graphique de la grille de jeu  

* Création d'un canvas contenant la grille de jeu.
* Creation d'un bouton recommencer qui permet de redemarrer le jeu.
* Création d'un Textblock qui contient le nombre de déplacements éffectuer par le joueur.
  
***
## Partie 2 : Initialisation de la grille de jeu

* Création de la classe position 
* Création de la classe de jeu
* inplementation de la classe de jeu par la création de initcarte
* Création initcart qui permet d'initialisé la grille par les etats  en fonction des caratères fourni (X=mur,o=cible,.= vide etc..)
  
***
## Partie 3 : Affichage de la carte via interface graphique 

* modification de main windows
* parcours de la grille de jeu et ajoute d'image au case spécifique , (vide = sol.png, mur = mur.png , cible = cible .png)
* création de la fonction dessiner et inpléme,tation de cette dernière qui s'assure de déssiner les différents de la grille de jeu
  
***
## Partie 4 : Affichages de Caisse et du personnage via interface graphique

* creation et implentation de la fonction dessisnercaisses qui permet de dessiner nos caisses sur la grille de jeu
* creation et implenmation de la fonction dessinerpersonnage qui permet de dessiner le personnage sur la grille de jeu
  
***

## Partie 5 : Gestion des Déplacements du personnage

* Creéation d'une fonction toucheappuyee qui permet d'effectuer les mouvements du personnage en fonction de la touche appuyée
* Creéation et implémentation  de la fonction Redessiner qui permet de redesssiner les élément de la grille en cas de Déplacements 
  
***

## Partie 6 : Gestion de Déplacements par rapport au mur

* création et implement de la fonction CalculNewPos qui calcul la nouvelle position en fonction du deplacement
* mise en place du test CaseOk pour s'assurer s'il y a pas un mur sur notre nouvelle case
  
***

## Partie 7 : Gestion de Déplacement des caisses

* Création de la fonction CaisseInpos qui nous permet de detecter l'existence d'une caisse la notre prochain case par rapport au déplacement
* gestion des déplacements des casse par rapport au faite si il y a l'existence d'un mur , d'un espace ou d'une autre caisse
  
***

## Partie 8 : Gestion du nombre de déplacements

* Gestion du nombre de déplacements en créant une variable pour
* dessiner ou ecrire le nombre de déplacements via l'interface graphique grace à la fonction afficherDéplacements
  
***

## Partie 9 : Gestion du bouton recommencer

* création de l'évenement click sur le bouton recommencer 
* création de la fonction restart qui permet d'initialiser la carte

***

## Partie 10 : Fin de l'implémentation du Jeu

* vérification si l'utilisateur a gagné
* afficher le box de notifications pour nous signalez notre victoire

# Fin   


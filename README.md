# Rallye Lecture

Le principe était de réaliser une application Windows Form en C# permettant à un professeur d'alimenter une base de données avec un fichier csv. Le fichier csv contient donc une liste d'élève (prénom et nom).
Par la suite après avoir lancé le programme, des identifiants de connexion à notre site sont donc créées.

Le projet est divisé en 3 grandes parties :

* Lecture des informations d'un fichier csv.
* Ecriture d'un fichier csv avec les informations de connection de chaques eleves.
* Alimentation d'une base de données.

Les outils mis en oeuvre : 
* Git
* Visual Studio
* C#
* Windows Form

### Cas d'utilisation

![Capture.png](https://image.noelshack.com/fichiers/2019/13/3/1553701046-capture.png)<br>


### Diagrammes de classe

![Capture2.png](https://image.noelshack.com/fichiers/2019/13/3/1553701172-capture2.png)<br>
![Capture3.png](https://image.noelshack.com/fichiers/2019/13/3/1553701182-capture3.png)<br>


### Développement

Nous retrouvons donc deux interfaces Windows Forms :

![Capture.png](https://image.noelshack.com/fichiers/2019/13/3/1553695324-capture.png)<br>
La première permet à un enseignant (et uniquement à un enseignant) de se connecter à l'application.

![Capture2.png](https://image.noelshack.com/fichiers/2019/13/3/1553695327-capture2.png)<br>
La seconde est donc l'interface principale.
Nous y retrouvons : 
* Choix d'un répertoire contenant des csv.
* Choix du csv à utiliser.
* Choix de l'année scolaire.
* Choix du niveau scolaire.
* Choix de la génération du mot de passe.

### Schéma de la base de données
![Capture.png](https://image.noelshack.com/fichiers/2019/13/3/1553696893-capture3.png)<br>
![Capture.png](https://image.noelshack.com/fichiers/2019/13/3/1553696895-capture4.png)


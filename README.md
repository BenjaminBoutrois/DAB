# DAB

Mini-projet de Distributeur Automatique de Billets (DAB) réalisé par [Benjamin Boutrois](https://github.com/BenjaminBoutrois).

Ce projet est décomposé en 3 parties :

- DAB.Webservice : API Web (REST) qui héberge la base de données et répond aux requêtes du client (.NET Core 5.0)
- DAB.Client : Blazor WebAssembly qui fonctionne comme client et qui consomme l'API Web en envoyant des requêtes (.NET Core 5.0)
- DAB.Models : Bibliothèque de classes qui contient des classes utilisées par DAB.Client et DAB.Webservice (.NET Standard 2.0)

## Notice pour déboguer avec Visual Studio 2019 :

1. Lancer Visual Studio 2019
2. Créer un projet en clonant le dépôt https://github.com/BenjaminBoutrois/DAB.git
3. Dans le projet DAB.Webservice, appliquer les migrations vers une base de données SQL :
    * Ouvrir la Console du Gestionnaire de package
    * Dans la console, sélectionner le Projet par défaut : DAB.Webservice
    * Dans la console, entrer `update-database` (cette commande va appliquer les migrations et créer la base de données)
4. Lancer le projet DAB.Client en débogage
5. Lancer le projet DAB.Webservice en débogage

Exemple de compte pour tester :

Numéro de compte : 1234123412341234    
Code : 1234

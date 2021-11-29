# DAB

Mini-projet de Distributeur Automatique de Billets (DAB) réalisé par [Benjamin Boutrois](https://github.com/BenjaminBoutrois).

Ce projet est décomposé en 3 parties :

- DAB.Webservice : API Web (REST) qui héberge la base de données et répond aux requêtes du client (.NET Core 5.0)
- DAB.Client : Blazor WebAssembly qui fonctionne comme client et qui consomme l'API Web en envoyant des requêtes (.NET Core 5.0)
- DAB.Models : Bibliothèque de classes qui contient des classes utilisées par DAB.Client et DAB.Webservice (.NET Standard 2.0)

# ShopEase

Simple Full-Stack E-Commerce application built with .NET.

## Technologies utilisées

- .NET 10 / C#
- ASP.NET Core MVC
- Razor Views, HTML, CSS, Bootstrap
- Git & GitHub

## Fonctionnalités principales

- **Front-Office** (clients) : consultation des produits par catégorie, panier, passage de commande
- **Back-Office** (administrateur) : gestion des produits, des catégories et des commandes
- Gestion des produits
- Gestion des catégories
- Gestion du panier
- Gestion des commandes

## Structure du projet

```
ShopEase/
├── ShopEase.slnx              # Solution
└── src/
    └── ShopEase.Web/          # Application ASP.NET Core MVC
        ├── Controllers/       # Front-Office (clients)
        ├── Models/
        ├── Views/
        ├── Areas/Admin/       # Back-Office (administrateur)
        └── wwwroot/           # Fichiers statiques (CSS, JS, images)
```

## Lancer le projet

```bash
dotnet run --project src/ShopEase.Web
```

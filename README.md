# ProductManager

Eine webbasierte Anwendung zur Verwaltung von Produkten, entwickelt mit **ASP.NET Core MVC** und **Bootstrap**.

## Überblick

ProductManager ist ein Lern- und Portfolio-Projekt, das grundlegende CRUD-Funktionen (Create, Read, Update, Delete) demonstriert. Die Anwendung bietet eine übersichtliche Benutzeroberfläche zur Verwaltung von Produktinformationen.

## Funktionen

- **Produktübersicht:** Alle Produkte anzeigen
- **Produkt erstellen:** Neue Produkte mit Name, Beschreibung und Preis hinzufügen
- **Produktdetails:** Informationen zu einem einzelnen Produkt anzeigen
- **Produkt bearbeiten:** Bestehende Produktdaten aktualisieren
- **Produkt löschen:** Produkte nach einer Bestätigung entfernen
- **Validierung:** Eingaben serverseitig prüfen und Fehlermeldungen anzeigen
- **Responsive Design:** Benutzeroberfläche mit Bootstrap für verschiedene Bildschirmgrößen

## Technologien

- C#
- .NET 10
- ASP.NET Core MVC
- Razor Views
- Bootstrap
- Data Annotations
- In-Memory-Datenspeicherung

## Projektstruktur

```text
ProductManager/
├── Controllers/
├── Mappers/
├── Models/
├── Services/
├── ViewModels/
├── Views/
│   ├── Home/
│   ├── Products/
│   └── Shared/
├── wwwroot/
├── Program.cs
└── ProductManager.csproj
```

## Voraussetzungen

- .NET 10 SDK
- Eine Entwicklungsumgebung wie Visual Studio 2026 oder Visual Studio Code
- Git

## Installation und Ausführung

Repository klonen:

```bash
git clone https://github.com/DEIN-BENUTZERNAME/ProductManager.git
cd ProductManager
```

Abhängigkeiten wiederherstellen:

```bash
dotnet restore
```

Anwendung starten:

```bash
dotnet run
```

Öffne anschließend die URL, die im Terminal angezeigt wird, in deinem Browser.

## Datenspeicherung

Aktuell werden die Produktdaten im Arbeitsspeicher gehalten. Es wird noch keine Datenbank verwendet. Deshalb gehen Änderungen verloren, wenn die Anwendung beendet oder neu gestartet wird.

Eine persistente Datenspeicherung mit Entity Framework Core und einer Datenbank ist eine mögliche zukünftige Erweiterung.

## Mögliche Erweiterungen

- Datenbankintegration mit Entity Framework Core
- Such- und Filterfunktionen
- Sortierung und Pagination
- Automatisierte Tests
- Verbesserte Benutzer- und Fehlerbehandlung

## Ziel des Projekts

Dieses Projekt dient dazu, praktische Erfahrungen mit ASP.NET Core MVC, dem Model-View-Controller-Prinzip, Formularvalidierung, Dependency Injection und einer strukturierten Trennung von Zuständigkeiten zu sammeln.

## Autor

**Slim Boudjedra**

[GitHub-Profil](https://github.com/slimboudjedra)

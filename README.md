# .NET Templates

Eine kleine Sammlung von verschiedenen Templates zur Beschleunigung der .NET-Entwicklung  und vereinfachten NuGet-Veröffentlichung.

## Beschreibung

`Kurmann.Templates` bietet eine kleine Palette von .NET Projekt-Templates, die speziell darauf ausgelegt sind, Entwicklern einen schnellen Start und eine Einhaltung von Best Practices in der .NET Entwicklung zu ermöglichen. Die enthaltenen Templates umfassen eine vorstrukturierte Basis für verschiedene Projekttypen, inklusive aller nötigen Konfigurationen für eine effiziente Veröffentlichung als NuGet-Paket.

## Installation

Die Installation der Templates erfolgt unkompliziert über die .NET CLI:

```bash
dotnet new --install Kurmann.Templates
```

## Verfügbare Templates

Nach der Installation sind verschiedene Templates nutzbar, die den Entwicklungsprozess unterstützen:

### Klassenbibliothek Template

- **Kurzname:** `nuget-classlib`
- Erstellt eine .NET Klassenbibliothek im "Kurmann"-Namespace, vorbereitet für die NuGet-Veröffentlichung.

#### Nutzung Klassenbibliotheks-Template

```bash
dotnet new nuget-classlib -n MeinNugetPaket -o src
```

### GitHub-Action für NuGet-Veröffentlichung

- **Kurzname:** `nuget-classlib-workflow`
- Generiert eine GitHub-Action-Workflow-Datei für die automatische Veröffentlichung auf NuGet.org.

#### Nutzung GitHub-Action

```bash
dotnet new nuget-classlib-workflow
```

### Template: .NET Gitignore

- **Kurzname:** `dotnet-gitignore`
- Erstellt ein `.gitignore` im Arbeitsverzeichnis speziell für .NET-Entwicklungen, basierend auf aktuellen Best Practices und gängigen Ignorierungsregeln für .NET-Projekte.

#### Nutzung Gitignore-Template

Nach der Installation des `Kurmann.Templates` Pakets kann das `.gitignore` Template wie folgt angewendet werden:

```bash
dotnet new dotnet-gitignore
```

Dieser Befehl fügt ein vorkonfiguriertes `.gitignore` zu Ihrem Projekt hinzu, das eine Vielzahl von für .NET-Projekte typischen temporären Dateien und Verzeichnissen ignoriert.

## Lizenz

Das Projekt steht unter der [Apache 2.0 Lizenz](LICENSE).

## Änderungsverlauf

- keine

### Unveröffentlicht

### Version 0.4.0 - 2024-04-08

- Neues Template "entities-repo" erstellt zur Initialisierung eines ganzen GitHub-Repositorys mit .NET-Projekten Entities mit Tests, Gitignore, Nuget-Packaging-Workflow.

### Version 0.3.3 - 2024-04-08

#### Hinzugefügt

- Klassenbibliothekts-Template unterstützt die Angabe von Namespaces

### Version 0.3.2 - 2024-04-08

#### Hinzugefügt

- Änderungsverlauf aus den zugehörigen veröffentlichen Nuget-Packages in dieses Readme integriert.

### Version 0.3.1 - 2024-04-08

#### Geändert

- Vereinfachter Workflow für Zwischenreleases mit automatischer Datumsvergabe bei Vorschauversionen nach dem Vorbild aus "Kurmann.Messaging"

### Version 0.3.0 - 2024-04-06

#### Hinzugefügt

- Template erstellt zur Erstellung einer GitHub-Action für die automatische Veröffentlichung von NuGet-Paketen.

### Version 0.2.0 - 2024-04-06

#### Hinzugefügt

- Template erstellt zur Erstellung einer Klassenbibliothek im Kurmann-Namespace.

### Version 0.1.0 - 2024-04-06

#### Hinzugefügt

- Template zur Erstellung einer Gitignore-Datei.
- Erste Veröffentlichung mit einer Vorlage für eine .NET-Klassenbibliothek mit NuGet-Unterstützung.
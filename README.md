# .NET Templates

## Archivierung

### Dieses Repository wird archiviert

**Hinweis:** Dieses Repository wird nicht mehr aktiv weiterentwickelt und ist archiviert. Aufgrund der Entscheidung vom 31. Mai 2024, die Arbeiten nicht mehr in mehreren Repositories, sondern im Monorepo [kurmann/videoschnitt](https://github.com/kurmann/videoschnitt) weiterzuführen, ist die Sinnhaftigkeit dieser Repository-Templates nicht mehr gegeben.

---

Eine kleine Sammlung von verschiedenen Templates zur Beschleunigung der .NET-Entwicklung  und vereinfachten NuGet-Veröffentlichung.

## Beschreibung

`Kurmann.Templates` bietet eine kleine Palette von .NET Projekt-Templates, die speziell darauf ausgelegt sind, Entwicklern einen schnellen Start und eine Einhaltung von Best Practices in der .NET Entwicklung zu ermöglichen. Die enthaltenen Templates umfassen eine vorstrukturierte Basis für verschiedene Projekttypen, inklusive aller nötigen Konfigurationen für eine effiziente Veröffentlichung als NuGet-Paket.

## Installation

Die Installation der Templates erfolgt unkompliziert über die .NET CLI:

```bash
dotnet new install Kurmann.Templates
```

## Verfügbare Templates

Nach der Installation sind verschiedene Templates nutzbar, die den Entwicklungsprozess unterstützen:

### Entities GitHub Repository Template

Dieses Template dient der Erstellung eines GitHub-Repositories, das eine .NET-Klassenbibliothek für Entitäten beinhaltet. Es enthält eine vorbereitete `.gitignore`, GitHub Actions für die Veröffentlichung von NuGet-Paketen und unterstützt eine klare und einheitliche Ordnerstruktur für Ihr Projekt.

**Kurzname**: `entities-repo`

#### Verwendung

Um ein neues Repository für Ihre .NET-Entitätsklassen zu initialisieren, verwenden Sie den folgenden Befehl in Ihrem Terminal:

```bash
dotnet new entities-repo -n ProjectName --namespace RootNamespace --description ProjectDescription
```

Mit diesem Befehl wird eine klare und einheitliche Verzeichnisstruktur für Ihr Repository erstellt, die die Entwicklung und Veröffentlichung von NuGet-Paketen vereinfacht. Das generierte Repository sieht wie folgt aus:

```text
ProjectName/
├── .github/
│   └── workflows/
│       └── dotnet.yml
├── src/
│   ├── Entities/
│   │   ├── Entities.csproj
│   │   └── SampleClass.cs
│   └── ProjectName.sln
├── Tests/
│   ├── GlobalUsings.cs
│   ├── SampleClassTests.cs
│   └── Tests.csproj
├── .gitignore
├── LICENSE
├── README.md
└── PackageIcon.png
```

Diese Struktur beinhaltet alles, was Sie für ein professionelles Entity-Management benötigen, einschließlich Continuous Integration und Package Publishing.

Der **Namespace** wird vom Parameter `--namespace`übernommen. Die SampleClass bekommt bspw. den Namespace `RootNamespace.ProjectName`.

Die **ProjectDescription** wird integriert im resultierenden README.md und im `Description`-Tag beim `Entities.csproj` und somit auch imm zugehörigen NuGet-Package.

### Services GitHub Repository Template

Dieses Template automatisiert die Erstellung eines vollständigen GitHub-Repositories für ein ServiceCollection, die mit dem IServiceCollection-Interface eingebunden werden kann. Es integriert VSCode Debug Einstellungen und enthält die vollständigen Workflows aus dem Repository "kurmann/GitHub.Workflows".

**Kurzname**: `services-repo`

#### Verwendung

```bash
dotnet new services-repo -n IhrProjektName --namespace IhrRootNamespace --description "Kurze Beschreibung Ihres Projekts"
```

Die Verzeichnisstruktur Ihres neuen Repositorys sieht wie folgt aus:

```text
IhrProjektName/
├── .devcontainer/
│   └── devcontainer.json
├── .github/
│   ├── release-drafter-config.yml
│   └── workflows/
│       ├── draft_release.yml
│       └── publish_package.yml
├── .vscode/
│   ├── launch.json
│   └── tasks.json
├── src/
│   ├── Application/
│   │   ├── Program.cs
│   │   └── Application.csproj
│   └── Services/
│       ├── Commands/
│       │   ├── ICommand.cs
│       │   └── SampleModule.cs
│       ├── Queries/
│       │   ├── IQueryService.cs
│       │   └── SampleQuery.cs
│       └── Hosted/
│           └── SampleHostedService.cs
│       ├── Services.csproj
│       ├── ServiceCollection.cs
│       └── ProjectNameSettings.cs
├── .gitignore
├── LICENSE
├── PackageIcon.png
├── README.md
└── IhrProjektName.sln
```

Diese Struktur unterstützt Sie bei der Entwicklung einer .NET Service Library und bereitet alles vor für Continuous Integration und NuGet Package Publishing.

#### Besonderheiten des Templates

- **VSCode Debug-Einstellungen**: Mit `launch.json` und `tasks.json` für eine optimierte Debugging-Erfahrung direkt in VSCode.
- **GitHub Workflows**: Automatisiert den Release-Prozess mit `draft_release.yml`, `publish_package.yml` und `release-drafter-config.yml`, übernommen aus dem Repository "kurmann/GitHub.Workflows".
- **Erweiterbare Service-Konfiguration**: Die `ServiceCollectionExtensions` ermöglicht es, Services und Konfigurationen modular zu Ihrem .NET-Projekt hinzuzufügen.

```csharp
// ServiceCollection.cs

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using IhrRootNamespace.IhrProjektName.Services;

namespace IhrRootNamespace.IhrProjektName;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddIhrProjektName(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        // Bindet Root-Konfigurationswerte an IhrProjektNameSettings
        services.Configure<IhrProjektNameSettings>(configuration.GetSection(IhrProjektNameSettings.SectionName));
        
        // Dienste hinzufügen
        services.AddHostedService<SampleHostedService>();
        
        return services;
    }
}
```

Inklusive einer `README.md`-Vorlage, die Sie mit Anweisungen für die Verwendung des Templates und Informationen zur Repository-Struktur versorgt. Die enthaltene Lizenzdatei und die Vorlage für das Paket-Icon stellen sicher, dass Ihr Repository von Anfang an professionell wirkt.

#### Integration in bestehende Projekte

Um die Services in einem bestehenden Projekt zu nutzen, fügen Sie die `AddIhrProjektName`-Methode zur Konfiguration Ihrer `IServiceCollection` hinzu. Dies ermöglicht es Ihnen, die Dienste und Einstellungen, die durch das Template bereitgestellt werden, einfach zu integrieren und zu verwenden.

#### Schlussfolgerung

Das `Services GitHub Repository Template` ist ein mächtiges Werkzeug, um ein standardisiertes, sofort einsatzbereites Service-Repository aufzusetzen. Es spart Zeit und sorgt dafür, dass Best Practices von Anfang an eingehalten werden. Durch die Vorstrukturierung und die mitgelieferten Workflows für GitHub Actions kann der Entwicklungs- und Veröffentlichungsprozess erheblich beschleunigt und vereinfacht werden.

### Template: .NET Gitignore

Erstellt ein `.gitignore` im Arbeitsverzeichnis speziell für .NET-Entwicklungen, basierend auf aktuellen Best Practices und gängigen Ignorierungsregeln für .NET-Projekte.

**Kurzname:** `dotnet-gitignore`

#### Nutzung Gitignore-Template

Nach der Installation des `Kurmann.Templates` Pakets kann das `.gitignore` Template wie folgt angewendet werden:

```bash
dotnet new dotnet-gitignore
```

Dieser Befehl fügt ein vorkonfiguriertes `.gitignore` zu Ihrem Projekt hinzu, das eine Vielzahl von für .NET-Projekte typischen temporären Dateien und Verzeichnissen ignoriert.

## Lizenz

Das Projekt steht unter der [Apache 2.0 Lizenz](LICENSE).

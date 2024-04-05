# Templates

Sammlung von .NET Projekt-Templates zur einschliesslich vorbereiteter NuGet-Klassenbibliotheken und GitHub Actions für eine effiziente Veröffentlichung

## Beschreibung

`Kurmann.Templates` ist eine Sammlung von .NET Projekt-Templates, die darauf ausgelegt sind, die schnelle und standardisierte Entwicklung von .NET Anwendungen und Bibliotheken zu unterstützen. Diese Templates erleichtern den Entwicklungsstart, indem sie eine vorstrukturierte Projektbasis bieten, die den Best Practices entspricht und für die direkte Veröffentlichung als NuGet-Paket vorbereitet ist.

## Installation

Die Templates können einfach über die .NET CLI installiert werden:

```bash
dotnet new --install Kurmann.Templates
```

## Verfügbare Templates

Nach der Installation stehen folgende Templates zur Verfügung:

### Klassenbibliothek Template

**Kurzname:** `nuget-classlib`

Dieses Template erstellt eine .NET Klassenbibliothek vorbereitet mit allen notwendigen Konfigurationen für die Veröffentlichung als NuGet-Paket im "Kurmann"-Namespace.

#### Anwendung Klassenbibliothek-Template

```bash
dotnet new nuget-classlib -n MeinNugetPaket -o src
```

Dieser Befehl erstellt ein neues Projekt mit dem Namen `MeinNugetPaket` basierend auf dem `nuget-classlib` Template im "src"-Verzeichnis.

### GitHub-Action für NuGet-Veröffentlichung

**Kurzname:** `nuget-classlib-workflow`

Ein zugehöriges Template, das eine GitHub-Actions-Workflow-Datei generiert, um die erstellte Klassenbibliothek automatisch auf NuGet.org zu veröffentlichen.

#### Anwendung GitHub Action-Template

```bash
dotnet new nuget-classlib-workflow
```

Dieser Befehl fügt eine GitHub-Action-Workflow-Datei zum Verzeichnis `.github/workflows` deines Projekts hinzu, die für die Veröffentlichung auf NuGet.org konfiguriert ist, passend zur Klassenbibliothek, die mit `dotnet new nuget-classlib` erstellt werden kann.

## Nutzung der Templates

1. **Erstellung der Klassenbibliothek:**

   Beginnen Sie mit der Erstellung einer neuen Klassenbibliothek, die als Grundlage für Ihr NuGet-Paket dient. Nutzen Sie das `nuget-classlib` Template, um eine Projektstruktur zu erhalten, die bereits alle notwendigen Konfigurationen für die NuGet-Paketierung enthält.

2. **Konfiguration der GitHub-Action:**

   Um die Veröffentlichung Ihrer Klassenbibliothek auf NuGet.org zu automatisieren, fügen Sie die durch das `nuget-classlib-workflow` Template generierte GitHub-Actions-Workflow-Datei zu Ihrem Projekt hinzu. Passen Sie bei Bedarf die Workflow-Konfiguration an, um Ihren Veröffentlichungsprozess zu optimieren.

3. **Anpassung und Entwicklung:**

   Entwickeln und erweitern Sie Ihre Klassenbibliothek gemäß den Anforderungen Ihres Projekts. Die mit dem Template erstellte Struktur und Konfiguration unterstützt Sie dabei, eine klare und wartbare Codebasis zu pflegen.

4. **Veröffentlichung:**

   Sobald Ihre Klassenbibliothek fertiggestellt und getestet ist, nutzen Sie die automatisierte GitHub-Action, um Ihr Paket auf NuGet.org zu veröffentlichen. Stellen Sie sicher, dass Sie Ihre NuGet-API-Schlüssel korrekt in den GitHub Secrets konfiguriert haben.

## Lizenz

`Kurmann.Templates` ist unter der Apache License 2.0 lizenziert. Dies ermöglicht eine breite Nutzung und Anpassung, solange die Bedingungen der Lizenz eingehalten werden. Die vollständigen Lizenzbedingungen finden Sie in der [LICENSE](./LICENSE)-Datei.

# Definition Refactoring
Im Sinne der eigenen sowie Verständlichkeit des Codes durch andere
wird dieser "aufgeräumt" und gewissen Standards unterworfen.

## Vor- und Nachteile von Refactoring
### Vorteile
- bessere Lesbarkeit
- bessere Verständlichkeit
- bessere Wiederverwertbarkeit

### Nachteile
- erhöhter Zeitaufwand, ohne wesentlichen Unterschied in der Funktionalität des Programms
- neue Fehler können sich einschleichen

## Refactoring Schritte
1. Definition eines Test-Cases
2. Check ob der aktuelle Code funktioniert. Commiten als Back-up!
3. "Zusammenräumen" des gewünschten Abschnitts
4. Test der Funktionalität des veränderten Codes
5. Wenn Punkt 4. erfolgreich: Commiten des neuen Codes mit verständlicher Commit-Message
6. Im Code mit dem Refactoring fortfahren

## Prinzipien von guten Code
### DRY - Don’t Repeat Yourself
- Code-Wiederholungen vermeiden. Siehe objektorientierte Programmierung.

### KISS - Keep it Simple, Stupid
- Bei mehreren Möglichkeiten der Problemlösung immer den einfachsten Weg bestreiten.

### YAGNI - You Ain’t Gonna Need It
- Nicht benötigten Code löschen bzw. überprüfen, ob ein gewisser Abschnitt wirklich benötigt wird.

### SoC - Separation of Concerns
- Verschiede Problemstellungen in kleiner Probleme aufteilen.

### Principle of least Astonishment
- Der Benutzer einer Schnittstelle sollte keine Überarschungen erleben z.B. sprechende Klassennamen usw. verwenden.

### Single Responsibility Principle
- Eine Klasse = nur eine Funktion/einen Zweck.

## Code Smell
- Code Smell bezeichnet schwer verständlichen und schlecht strukturierten Code.

## 10 Code-Smell-Typen
### 1. Kommentare
- Genügend Kommentare, um den Code zu erklären, aber nicht zu viele.

### 2. Undurchsichte Bezeichnungen
- Sprechende Namen verwenden.

### 3. Renundanter Code
- Siehe DRY - Don't Repeat Yourself.

### 4. Zu lange Methoden
- Eine Methode soll nur eine Funktion erfüllen und nicht zuviele Zeilen Code beinhalten.

### 5. Zu kurze Bezeichnungen
- Ähnlich Punkt 2. sollen sprechende Namen verwendet werden.

### 6. Zu lange Bezeichnungen
- ... die Namen sollten aber auch nicht zu lange sein.

### 7. Tiefe Verschaftelungen
- Verschachtelungen erschweren die Lesbarkeit und Verständlichkeit. Just don't.

### 8. Leerzeilen
- Unnötige Zeilen löschen. Jedoch ist es Usus, dass die letzte Zeile eines Scripts eine Leerzeile ist.

### 9. Unbenutzter Code
- Unnötiger Code erschwert nur die Verständlichkeit. Löschen!

### 10. Falsche Klammern
- Falsche Klammern können für Errors sorgen.

Vielen Dank an @aweng für die Vorlage! **DRY 4 THE WIN!!!11einseinself**

# Santa Run
Das originale REAMDE.md inkl. Copyright des Spiels findet man unter [README_GAME.md](README_GAME.md).
Im Folgenden werden nur die Veränderungen beschrieben. **Refectoring inkl. Test cases wurde gemacht, siehe Commits.**

## Development Platform
- Unity 2019.1.14f1 on macOS Catalina
  - Scripting Runtime: .NET 4.x Equivalent
  - API-Level: .NET Standard 2.0
- Visual Studio for Mac v8.3.11 (build 1)

Programmentwurf - Protokoll
typl
Name: [Name, Vorname]
Martrikelnummer: [MNR]
Abgabedatum: [DATUM]

# Kapitel 1: Einführung (4P)
Übersicht über die Applikation (1P)
Was macht die Applikation? Wie funktioniert sie? Welches Problem löst sie/welchen Zweck hat sie?
- 
Starten der Applikation (1P)
Wie startet man die Applikation? Was für Voraussetzungen werden benötigt? Schritt-für-Schritt-
Anleitung
- 
Technischer Überblick (2P)
Nennung und Erläuterung der Technologien (z.B. Java, MySQL, …), jeweils Begründung für den
Einsatz der Technologien
- 

# Kapitel 2: Softwarearchitektur (8P)
Clean Architecture (4P)
In der Vorlesung wurde Clean Architecture vorgestellt. Diese muss in der Applikation umgesetzt
werden. Analyse und Begründung inkl. UML der wichtigsten Klassen, sowie Einordnung dieser
Klassen in die gewählte Architektur
- 
Domain Code (1P)
kurze Erläuterung in eigenen Worten, was Domain Code ist – 1 Beispiel im Code zeigen, das bisher
noch nicht gezeigt wurde
- 
Analyse der Dependency Rule (3P)
In der Vorlesung wurde im Rahmen der ‘Clean Architecture’ die s.g. Dependency Rule vorgestellt. Je 1
Klasse zeigen, die die Dependency Rule einhält und 1 Klasse, die die Dependency Rule verletzt;
jeweils UML (mind. die betreffende Klasse inkl. der Klassen, die von ihr abhängen bzw. von der sie
abhängt) und Analyse der Abhängigkeiten in beide Richtungen (d.h., von wem hängt die Klasse ab und
wer hängt von der Klasse ab) in Bezug auf die Dependency Rule
Positiv-Beispiel: Dependency Rule
- 
Negativ-Beispiel: Dependency Rule
- 

# Kapitel 3: SOLID (8P)
Analyse SRP (3P)
jeweils eine Klasse als positives und negatives Beispiel für SRP; jeweils UML und Beschreibung der
Aufgabe bzw. der Aufgaben und möglicher Lösungsweg des Negativ-Beispiels (inkl. UML)
Positiv-Beispiel
- 
Negativ-Beispiel
- 
Analyse OCP (3P)
jeweils eine Klasse als positives und negatives Beispiel für OCP; jeweils UML und Analyse mit
Begründung, warum das OCP erfüllt/nicht erfüllt wurde – falls erfüllt: warum hier sinnvoll/welches
Problem gab es? Falls nicht erfüllt: wie könnte man es lösen (inkl. UML)?
Positiv-Beispiel
- 
Negativ-Beispiel
- 
Analyse LSP/ISP/DIP (2P)
jeweils eine Klasse als positives und negatives Beispiel für entweder LSP oder ISP oder DIP; jeweils
UML und Begründung, warum hier das Prinzip erfüllt/nicht erfüllt wird; beim Negativ-Beispiel UML
einer möglichen Lösung hinzufügen
Anm.: es darf nur ein Prinzip ausgewählt werden; es darf NICHT z.B. ein positives Beispiel für LSP
und ein negatives Beispiel für ISP genommen werden
gewähltes Prinzip
- 
Positiv-Beispiel
- 
Negativ-Beispiel
- 

# Kapitel 4: Weitere Prinzipien (8P)
Analyse GRASP: Geringe Kopplung (3P)
eine bis jetzt noch nicht behandelte Klasse als positives Beispiel geringer Kopplung; UML mit
zusammenspielenden Klassen, Aufgabenbeschreibung der Klasse und Begründung, warum hier eine
geringe Kopplung vorliegt; es müssen auch die Aufrufer/Nutzer der Klasse berücksichtigt werden
- 
Analyse GRASP: Polymorphismus/Pure Fabrication (3P)
eine Klasse als positives Beispiel entweder von Polymorphismus oder von Pure Fabrication; UML
Diagramm und Begründung, warum es hier zum Einsatz kommt
- 
DRY (2P)
ein Commit angeben, bei dem duplizierter Code/duplizierte Logik aufgelöst wurde; Code-Beispiele
(vorher/nachher) einfügen; begründen und Auswirkung beschreiben – ggf. UML zum Verständnis
ergänzen
- 

# Kapitel 5: Unit Tests (8P)
10 Unit Tests (2P)
Zeigen und Beschreiben von 10 Unit-Tests und Beschreibung, was getestet wird
- 
ATRIP: Automatic, Thorough und Professional (2P)
je Begründung/Erläuterung, wie ‘Automatic’, ‘Thorough’ und ‘Professional’ realisiert wurde – bei
‘Thorough’ zusätzlich Analyse und Bewertung zur Testabdeckung
- 
Fakes und Mocks (4P)
Analyse und Begründung des Einsatzes von 2 Fake/Mock-Objekten (die Fake/Mocks sind ohne
Dritthersteller-Bibliothek/Framework zu implementieren); zusätzlich jeweils UML Diagramm mit
Beziehungen zwischen Mock, zu mockender Klasse und Aufrufer des Mocks
- 

# Kapitel 6: Domain Driven Design (8P)
Ubiquitous Language (2P)
4 Beispiele für die Ubiquitous Language; jeweils Bezeichung, Bedeutung und kurze Begründung,
warum es zur Ubiquitous Language gehört
Bezeichung Bedeutung Begründung
- 
Repositories (1,5P)
UML, Beschreibung und Begründung des Einsatzes eines Repositories; falls kein Repository
vorhanden: ausführliche Begründung, warum es keines geben kann/hier nicht sinnvoll ist – NICHT,
warum es nicht implementiert wurde
- 
Aggregates (1,5P)
UML, Beschreibung und Begründung des Einsatzes eines Aggregates; falls kein Aggregate
vorhanden: ausführliche Begründung, warum es keines geben kann/hier nicht sinnvoll ist– NICHT,
warum es nicht implementiert wurde
- 
Entities (1,5P)
UML, Beschreibung und Begründung des Einsatzes einer Entity; falls keine Entity vorhanden:
ausführliche Begründung, warum es keine geben kann/hier nicht sinnvoll ist– NICHT, warum es nicht
implementiert wurde
- 
Value Objects (1,5P)
UML, Beschreibung und Begründung des Einsatzes eines Value Objects; falls kein Value Object
vorhanden: ausführliche Begründung, warum es keines geben kann/hier nicht sinnvoll ist– NICHT,
warum es nicht implementiert wurde
- 

# Kapitel 7: Refactoring (8P)
Code Smells (2P)
jeweils 1 Code-Beispiel zu 2 unterschiedlichen Code Smells (die benannt werden müssen) aus der
Vorlesung; jeweils Code-Beispiel und einen möglichen Lösungsweg bzw. den genommen Lösungsweg
beschreiben (inkl. (Pseudo-)Code)
CODE SMELL 1
- 
CODE SMELL 2
- 
2 Refactorings (6P)
2 unterschiedliche Refactorings aus der Vorlesung jeweils benennen, anwenden, begründen, sowie
UML vorher/nachher liefern; jeweils auf die Commits verweisen – die Refactorings dürfen sich nicht
mit den Beispielen der Code überschneiden
- 

# Kapitel 8: Entwurfsmuster (8P)
2 unterschiedliche Entwurfsmuster aus der Vorlesung (oder nach Absprache auch andere) jeweils
benennen, sinnvoll einsetzen, begründen und UML-Diagramm
Entwurfsmuster: Name (4P)
- 
Entwurfsmuster: Name (4P)
- 

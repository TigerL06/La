# La1100
# Projekt-Dokumentation

☝️ Alle Text-Stellen, welche mit einem ✍️ beginnen, können Sie löschen, sobald Sie die entsprechende Stellen ausgefüllt haben.
Liam Gideon Koch

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
|   23.08.2022    | 0.0.1   | Wir haben mit dem Projekt gestarrtet, ich habe die User Stories und Testfälle fertig. Die Plannung noch nicht ganz.|
|   30.08.2022    | 0.0.2     |  Ich habe heute nach dem Plan gearbeitet, bin aber schneller voran gekommen und habe das Projekt fast fertig Programmiert.             |
|06.09.2022|0.0.3| Heute habe ich die letzten User Stories abgeschlossen und meine Projekt-Dokumenttaion verbessert.|
|       | 1.0.0   |   |                                                           

## 1 Informieren

### 1.1 Ihr Projekt

✍️ Wir müssen auf C# einen Zufallsgenerator programmieren, in dem die Zufallszahl erraten werden kann.

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1    |     muss            |  Funktionale Anforderung   | Als Spieler möchte ich das das Programm eine Zufallszahl generiert, damit man das Programm spielen kann |
| 2 |  musss | Qualitätsanforderung | Als Spieler möchte ich das die Zufallszahl nicht erkennbar ist, damit man auch raten muss |
| 3 | muss |  Funktionale Anforderung |Als ein Spieler möchte ich eine Zahl eingeben, damit ich gewinne |
| 4 | muss | Funktionale Anforderung | Als Spieler möchte ich sehen ob die Zahl falsch oder richtig ist, damit ich weiss wann ich gewonnen habe|
| 5 | muss    |    Funktionale Anforderung    | Als Spieler möchte ich sehen, ob die Zahle die ich eingegeben habe grösser oder kleiner als die Zufallszahl ist, damit ich weiss ob ich sie verkleiner oder vergrösser muss |
|6|muss|Funktionale Anforderung| Als Spieler möchte ich das Programm sich so lange wiederholt bis ich die Zahl erraten habe, damit ich mehrere Versuche habe|
| 7 |    muss     |   Funktionale Anforderung       | Als Spieler möchte ich wenn die Geheimzahl erraten wurde, sollte die Anzahl der Rateversuche ausgegeben werden |
|8|muss| Funtionale Anforderung | Als Spieler möchte ich, dass das Programm mit einer Fehleingabe umgehen kann, damit es nicht aufhängt.|


✍️ Jede User Story hat eine ganzzahlige Nummer (1, 2, 3 etc.), eine Verbindlichkeit (Muss oder Kann?), und einen Typ (Funktional, Qualität, Rand). Die User Story selber hat folgende Form: *Als ein 🤷‍♂️ möchte ich 🤷‍♂️, damit 🤷‍♂️*.

### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1  |  Das Programm ist noch nicht gestartet |   Programm starten  | Geben Sie eine Zahl zwischen 1 und 100 ein: |
|2.1| Programm ist gestartet und bittet um eine Zahl| Zahl | Die Zufallszahl wird nicht angezeigt |
| 3.1  | Das Programm ist gestartet und bittet um eine Zahl   | Zahl |  Zahl wird angezeigt |
|4.1|Das Programm ist gestartet und bittet um eine Zahl | Zahl | Antwort: richtig oder falsch |
|5.1| Das Programm ist gestartet und eine eine Zahl ist eingebenen worden, Die Zahl ist falsch.| Enter | Antwort: grösser oder kleiner |
|6.1| Das Programm ist gestartet und die eine Zahl ist eingeben worden | Enter | Das Programm läuft weiter|
|7.1| Das Programm ist schon gestartet worden und man hat die Zufallszahl erraten | Enter | Anzahl Versuche werden angezeigt |
|8.1|Das Programm ist gestartet und bittet um eine Zahl| Eingabe von etwas anderm als einer Zahl|Programm zeigt an das es ein Fehler gab und bittet um eine neue Eingabe|

|||||

### 1.4 Diagramme

![Screenshot 2022-08-23 102807](https://user-images.githubusercontent.com/110893121/186110776-b1a6a218-6507-48f2-b3fa-01c40fec68a5.png)


## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A  | 30.08.2022    |    Koch       | Ein Zufallszahl programmieren   |         45      |
| 2.A  | 30.08.2022       |           |  Informieren wie ich etwas im Programm verbergen kann  |      20         |
|2.B|30.08.2022 |Koch| Programmieren, dass Zufallszahl verborgen bleibt|25|
|3.A|30.08.2022 | Koch |Informieren wie ich in einem Programm eine Spalte einfügen kann, wo die Spieler ihre Zahl eingeben können|20|
|3.B|30.08.2022 |Koch|Die Spalte programmieren|25|
|4.A|30.08.2022|Koch| Informieren wie die Zahl vom Spieler mit der Zufallszahl vergleichen kann |20|
|4.B|30.08.2022|Koch| Vergleich mit der Zufallszahl programmieren|25|
|5.A|30.08.2022|Koch|Eine Schleife programmieren| 20 |
|5.B|30.08.2022|Koch|Sich informieren wie man die Schleife beenden kann, wenn die Zahl erraten worden ist|30|
|5.C|30.08.2022|Koch|Die Schleife so deklarieren, dass sich beendet wenn die Zahl erraten worden ist .|30|
|6.A|06.09.2022|Koch| Informieren wie man dem Spieler sagen kann, dass seine Zahl grösser oder kleiner, als die Zufallszahl ist.|20|
|6.B|06.09.2022|Koch|Das Programm so programmieren, dass sie Zahl vergleicht und eine Ausgabe mach. In der dann steht ob sie grösser oder kleiner als die Zufallszahl ist |25|
|7.A|06.09.2022|Koch| Informieren wie man die Versüche auflistet und anzeigen kann. |20|
|7.B|06.09.2022|Koch| Das Programm anweisen die Anzahl der Versuche auszugeben.|25|
|8.A|06.09.2022|Koch|Das Programm so programmieren das es mit einer Fehl eingabe umgehen kann.|45|
Total: 270 min.



✍️ Ein Arbeitspaket sollte etwa 45' für eine Person in Anspruch nehmen. Die totale Anzahl Arbeitspakete sollte etwa Folgendem entsprechen: `Anzahl R-Sitzungen` ╳ `Anzahl Gruppenmitglieder` ╳ `4`. Wenn Sie also zu dritt an einem Projekt arbeiten, für welches zwei R-Sitzungen geplant sind, sollten Sie auf `2` ╳ `3` ╳`4` = `24` Arbeitspakete kommen. Sollten Sie merken, dass Sie hier nicht genügend Arbeitspakte haben, denken Sie sich weitere "Kann"-User Stories für Kapitel 1.2 aus.

## 3 Entscheiden

✍️ Dokumentieren Sie hier Ihre Entscheidungen und Annahmen, die Sie im Bezug auf Ihre User Stories und die Implementierung getroffen haben.

## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  |  30.08.2022   |   Koch       |       45        |          15      |
| 2.A |    30.08.2022   |    Koch       |         20      |        5       |
|2.B | 30.08.2022 |Koch |25|10|
|3.A| 30.08.2022 |Koch |20|5|
|3.B| 30.08.2022 |Koch |25|10|
|4.A| 30.08.2022 |Koch |20|5|
|4.B| 30.08.2022 |Koch |25|10|
|5.A| 30.08.2022 |Koch |20|5|
|5.B|30.08.2022|Koch|30|10|
|5.C|30.08.2022|Koch|30|10|
|6.A|30.08.2022|Koch|20|10|
|6.B|30.08.2022|Koch|25|10|
|7.A|30.08.2022|Koch|20|15|
|7.B|30.08.2022|Koch|25|15|
|8.A|06.09.2022|Koch|45|120|


## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  |  13.09.2022     |          |   Liam Gideon Koch     |
| 2.1 |   13.09.2022      |          |  Liam Gideon Koch         |
|3.1| 13.09.2022 ||Liam Gideon Koch   |
|4.1| 13.09.2022 ||Liam Gideon Koch   |
|5.1| 13.09.2022 ||Liam Gideon Koch   |
|6.1| 13.09.2022 ||Liam Gideon Koch   |
|7.1| 13.09.2022 ||Liam Gideon Koch   |
|8.1| 13.09.2022 ||Liam Gideon Koch   |

✍️ Vergessen Sie nicht, ein Fazit hinzuzufügen, welches das Test-Ergebnis einordnet.

### 5.2 Exploratives Testen

| BR-№ | Ausgangslage | Eingabe | Erwartete Ausgabe | Tatsächliche Ausgabe |
| ---- | ------------ | ------- | ----------------- | -------------------- |
| I    |              |         |                   |                      |
| ...  |              |         |                   |                      |

✍️ Verwenden Sie römische Ziffern für Ihre Bug Reports, also I, II, III, IV etc.

## 6 Auswerten

✍️ Fügen Sie hier eine Verknüpfung zu Ihrem Lern-Bericht ein.

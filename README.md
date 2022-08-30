# La1100
# Projekt-Dokumentation

☝️ Alle Text-Stellen, welche mit einem ✍️ beginnen, können Sie löschen, sobald Sie die entsprechende Stellen ausgefüllt haben.

✍️ Ihr Gruppenname, Koch

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
|   23.08.2022    | 0.0.1   | Wir haben mit dem Projekt gestarrtet, ich habe die User Stories und Testfälle fertig. Die Plannung noch nicht ganz.|
|   30.08.2022    | 0.0.2     |  Ich habe heute nach dem Plan gearbeitet, bin aber schneller voran gekommen und habe das Projekt fast fertig Programmiert.             |
|       | 1.0.0   |                                                              |

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
|5|muss|Funktionale Anforderung| Als Spieler möchte ich das Programm sich so lange wiederholt bis ich die Zahl erraten habe, damit ich mehrere Versuche habe|
| 6 | muss    |    Funktionale Anforderung    | Als Spieler möchte ich sehen, ob die Zahle die ich eingegeben habe grösser oder kleiner als die Zufallszahl ist, damit ich weiss ob ich sie verkleiner oder vergrösser muss |
| 7 |    muss     |   Funktionale Anforderung       | Als Spieler möchte ich wenn die Geheimzahl erraten wurde, sollte die Anzahl der Rateversuche ausgegeben werden |


✍️ Jede User Story hat eine ganzzahlige Nummer (1, 2, 3 etc.), eine Verbindlichkeit (Muss oder Kann?), und einen Typ (Funktional, Qualität, Rand). Die User Story selber hat folgende Form: *Als ein 🤷‍♂️ möchte ich 🤷‍♂️, damit 🤷‍♂️*.

### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1  |  Ich möchte eine zufällige Zahl generiernen |   Programm starten  | Das Programm hat eine Zahl generiert die ich nicht kenne  |
|2.1| Ich möchte das die Zufallszahl nicht sichtbar ist| Programm verdeckt die Zahl | Die Zahl wird nicht angezeigt |
| 3.1  | Ich möchte eine Zahl eingeben   | Eine Zahl |  Zahl wird eingelesen |
|4.1| Ich möchte wissen ob meine Zahl korrekt oder falsch ist | Programm vergleicht die Zahlen| Antwort: richtig oder falsch |
|5.1|Ich möchte eine Schleife generieren|Das Programm wird ausgeführt| Das Programm wird so lange ausgeführt bis man die Zahl erraten hat|
|6.1| Ich möchte wissen ob meine Zahl grösser oder kleiner, als die Zufallszahl ist| Programm vergleicht die Zahlen | Antwort: grösser oder kleiner |
|7.1| Ich möchte wenn ich die Zufallszahl errate wissen wie viele Versuche ich gebraucht habe| Programm liestet die Versuche auf | Aufgeliestete Versuche werden angezeigt |
|||||
|||||

### 1.4 Diagramme

![Screenshot 2022-08-23 102807](https://user-images.githubusercontent.com/110893121/186110776-b1a6a218-6507-48f2-b3fa-01c40fec68a5.png)


## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A  | 30.08.2022    |    Koch       | Ein Zufallsgenerator programmieren   |         45      |
| 2.A  | 30.08.2022       |           |  Informieren wie ich etwas im Programm verbergen kann        |      20         |
|2.B|30.08.2022 |Koch| Programmieren, dass Zufallszahl verborgen ist|25|
|3.A|30.08.2022 | Koch |Informieren wie ich in einem Programm eine Spalte einfügen kann, wo die Spieler ihre Zahl eingeben können|20|
|3.B|30.08.2022 |Koch|Die Spalte programmieren|25|
|4.A|30.08.2022|Koch| Informieren wie die Zahl vom Spieler mit der Zufallszahl vergleichen kann |20|
|4.B|30.08.2022|Koch| Das gelernte programmieren|25|
|5.A|30.08.2022|Koch|Eine Schleife programmieren| 20 |
|5.B|30.08.2022|Koch|Sich informieren wie man die Schleife beenden kann, wenn die Zahl erraten worden ist|30|
|5.C|30.08.2022|Koch|Das gelernte Programmiern|30|
|6.A|06.09.2022|Koch| Informieren wie man die Zahl vom Spieler mit der Zufallszahl vergleicht, ob die Spielerzahl grösser oder kleiner ist |20|
|6.B|06.09.2022|Koch|Das gelernte programmieren |25|
|7.A|06.09.2022|Koch| Informieren wie man die Versüche auflistet und anzeigt |20|
|7.B|06.09.2022|Koch|Das gelernte anwenden|25|
Total: 270 min.



✍️ Ein Arbeitspaket sollte etwa 45' für eine Person in Anspruch nehmen. Die totale Anzahl Arbeitspakete sollte etwa Folgendem entsprechen: `Anzahl R-Sitzungen` ╳ `Anzahl Gruppenmitglieder` ╳ `4`. Wenn Sie also zu dritt an einem Projekt arbeiten, für welches zwei R-Sitzungen geplant sind, sollten Sie auf `2` ╳ `3` ╳`4` = `24` Arbeitspakete kommen. Sollten Sie merken, dass Sie hier nicht genügend Arbeitspakte haben, denken Sie sich weitere "Kann"-User Stories für Kapitel 1.2 aus.

## 3 Entscheiden

✍️ Dokumentieren Sie hier Ihre Entscheidungen und Annahmen, die Sie im Bezug auf Ihre User Stories und die Implementierung getroffen haben.

## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  |  30.08.2022   |   Koch       |       45        |          15oooooooooooo        |
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

✍️ Tragen Sie jedes Mal, wenn Sie ein Arbeitspaket abschließen, hier ein, wie lang Sie effektiv dafür hatten.

## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  |       |          |        |
| ...  |       |          |        |

✍️ Vergessen Sie nicht, ein Fazit hinzuzufügen, welches das Test-Ergebnis einordnet.

### 5.2 Exploratives Testen

| BR-№ | Ausgangslage | Eingabe | Erwartete Ausgabe | Tatsächliche Ausgabe |
| ---- | ------------ | ------- | ----------------- | -------------------- |
| I    |              |         |                   |                      |
| ...  |              |         |                   |                      |

✍️ Verwenden Sie römische Ziffern für Ihre Bug Reports, also I, II, III, IV etc.

## 6 Auswerten

✍️ Fügen Sie hier eine Verknüpfung zu Ihrem Lern-Bericht ein.

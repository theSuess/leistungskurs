# Stream

> Ein Stream ist wie ein Fluss. Es ist nicht wichtig woher die Daten kommen und wohin sie fließen.

Stream ist eine abstrakte C# Klasse. Daher müssen folgende Methoden implementiert werden:
* Flush
* Seek
* SetLength
* Read
* Write

Des Weiteren sind noch Properties für die Implementation nötig.

Der Vorteil, dadurch das alle Streams von `Stream` erben, ist dass man Objekte der Child-Klasse in einen Stream boxen kann. Dies wird wichtig, wenn wir Decorator verwenden.

Hier boxen wir einen FileStream in einen Stream. 
~~~csharp
Stream st = new FileStream(...);
~~~

## Decorator

Ein Decorator-Stream verkleidet einen anderen Stream. Das bedeutet, der Decorator-Stream manipuliert Daten.

verschlüsselte Daten -> FileStream -> CryptoStream -> Daten unverschlüsselt

Wichtig dafür ist, der Decorator-Stream einen Stream als Konstruktor Argument annimmt. Dieser Stream wird der Input Stream sein.

~~~csharp
using(FileStream fs = File.Open("test",FileMode.Create))
using(GZipStream gs = new GZipStream(fs,CompressionMode.Compress))
{

}
~~~

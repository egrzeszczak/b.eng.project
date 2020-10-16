# Wymagania

|Wymagania Funkcjonalne|
|-|
|Program powinien wykrywać port z podłączonym mikrokontrolerem, który obsługuje grawer laserowy|
|Program powinien umożliwić użytkownikowi zainstalowanie odpowiedniego sterownika (CH341SER), jeśli nie został on wykryty na systemie użytkownika|
|Program przed pracą powinien mieć możliwość: przetestować połączenie z mikrokontrolerem, funkcjonalność grawera laserowego oraz wygrawerować obraz testowy|
|Użytkownik może wgrać plik z instrukcjami GCode do programu|
|Użytkownik może wgrać pliki graficzne (formaty: JPEG, PNG, SVG) do programu|
|Użytkownik może zapisać plik z instrukcjami GCode|
|Program ma przetwarzać obrazy rastrowe i wektorowe (formaty: JPEG, PNG, SVG) na sekwencję kodów (GCode) zrozumiałych dla mikrokontrolera|
|Program ma dać możliwość użytkownikowi awaryjnego wstrzymania i awaryjnego anulowania procesu grawerowania w trakcie|
|Program ma poinformować użytkownika o pozostałym czasie grawerowania podczas wykonywania zadania|
|Użytkownik ma miec możliość sterowania ręcznie laserem za pomocą przycisków, ustawiania szybkości i mocy lasera a także ma mieć dostęp|
|Program ma mieć dostęp do terminala mikrokontrolera, wyświetlać komendy wysyłane i odbierać wiadomości zwrotne od mikrokontrolera|
|Program powinien dać możliwość wyświetlenia użytkownikowi obecnie wysyłane komendy do mikrokontrolera|
|Program powinien ostrzegać użytkownika o długim czasie pracy grawera oraz automatycznie przerywać pracę grawera, jeśli grawer będzie pracował dłużej niż 15 minut bez przerwy|
|Program będzie mógł po wczytaniu obrazu/instrukcji GCode zasymulować przebieg grawerowania i odtworzyć symulacje w programie|

---

|Wymagania niefunkcjonalne|
|-|
|Program powinien być obsługiwany na systemie Windows 10|
|Aplikacja ma zostać napisana w języku C#, w środowisku Microsoft Visual Studio|
|Aplikacja powinna obierać się na platformie .NET Framework 4.8|
|Wygląd aplikacji będzie oparty na frameworku WPF|
|Program powinien współpracować z sterownikiem CH341SER, odpowiadający za komunikację z grawerem|


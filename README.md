# Szolgáltatás Orientált Programozás Beadandó

## Rövid leírás

WCF szerveroldal és Winform kliens MySQL adatbázissal. A Host elindítása után, kliensekkel tudunk csatlakozni arra. Egy kliens elindítását követően egy Login window fogad minket, ahol be kell jelentkezni (ez egyben regisztráció is, tehát ha a felhasználó még nem létezik létre fogja hozni az adatbázisban). A következő ablakban egy adatok kezelésére alkalmas felület található, ahol zenékkel tudunk CRUD műveleteket végezni. Ha több kliens van csatlakozva a szerverre és valamelyik végrehajt egy műveletet, akkor nem fog frissülni automatikusan a felület, erre a célre van a Refresh gomb.

## Telepítési útmutató

Xampp használata javasolt, Apache (80 port), és MySQL (3306 port) szolgáltatásokkal.

- Az SQL mappában lévő mellékelt .sql fájl importálása
- A projekt áthelyezése az htdocs mappába
- A szerver a 8000-es porton fog futni

## Használati útmutató

A Host/bin/Debug elérési úton található Host.exe futtatása rendszergazdaként javasolt. Ezután a WinForm nevű mappában (ez lesz a kliens) a bin/debug elérési úton a WinForm.exe elindításával a kliens megpróbál a host-ra csatlakozni.

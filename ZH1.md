# C# nyelvi eszközök
a/ Mi a delegate kulcsszó funkciója a C# nyelvben? /4p/

b1/ Valósítson meg eg általános szűrőfüggvnt C# nelven. A **függvény** neve legen `Filter`, **két paraméter**t várjon, egy `integer` **listát** és egy `delegate`-et, **visszatérési érték**ként egy új `integer` **listát** adjon.  
A függvény a végrehajtás során egyessével meghívja a paraméterként kapott `delegate`-et az egyes `integer`ekre, s eredményül egy-egy logikai értéket kap a `delegate`-től. Ha az érték `True` hozzáfűzi az integert a végső listához, mellyel végül visszatér.  
Mutassa be egy példán a függvény használatát!
A példában a bemeneti listában a számok legyenek 1-20-ig a kimenetben pedig csak a párosak maradjanak. /12p/

b2/ `MyAlgorithm` osztály egy `DoWork()` nevű publikus metódust tartalmaz, melynek törzsében egy for ciklus elszámol 0-tól 100-ig. Publikál egy `ProgressChanged` nevű eseményt(event), melyet a for ciklus minden iterációjában kivált, s paraméterként átadja benne a ciklusváltozó aktuális értékét.  
Valósítsa meg a `MyAlgorithm` osztályt és mutasson példát a használatára (példányosítás, eseményre feliratkozás, DoWork hívása, esemény kezelése) /12p/

# Eseményvezérelt programozás és gráfmegjelenítés
a1\ Milyen adatok tartoznak egy Windows üzenethez (a 4 lényegeset adja meg)? /3p/

a2\ Mivel jár, ha két vezérlő szülő-gyerek viszonyban van egymással? 4 lényeges tulajdonságot adjon meg.

b\ Ismertesse röviden a `partial class` (részleges osztály) fogalmát és adja meg egy fontos szerepét /3p/

c\ Irjon alkalmazás részletet, amely az `(50,50)` koordinátában megjelenít egy **fekete** színű **1 pixel** vastag **folytonos** vonallal rajzolt, **kitöltetlen**, **100 pixel** oldalhosszúságú **négyzet**et**.  
Ha a felhasználó lenyomja az "s" billentyűt, a négyzet vonalának színe 10 másodperc alatt ússzon át kékbe.
Csak az időzítő (`Timer`) alapú megoldás elfogadható! /13p/


# Szálkezelés
a\ Mikor érdemes több szálú alkalmazást készíteni? 3esetet adjon meg rövid indoklással, ügyeljen a pontos megfogalmazásra /3p/

b\ Írjon C# osztályt, mely egy egész számokat tároló sort (FIFO) valósít meg.
Legyen egy `Get` metódusa, mely a sor első elemét adja vissza (törli is azt).
Ha a sor üres, a művelet blokkolva várakozzon, amíg be nem tesznek egy elemet a sorba.  
Legyen egy `Add(int value)` metódusa, amely a sor végére teszi az értéket.  
Ügyeljen arra, hogy az osztály bármely függvényét tetszőleges szál hívhatja. A blokkolásnál hatékony megoldásra törekedjen, kerüljük az aktív várakozást.  
Az elemek tárolására pl a `List<T>` osztály használható (`Add`, `Remove` műveletekkel) /11p/

c1\ Ismertesse röviden, milyen célt szolgál a `Control` osztály `Invoke` művelete /2p/

c2\ 2 szál: egyik `ObjA`-ra majd `ObjB`-re zárol. A másik fordított sorrendben használja ezeket `lock` blokkban. Rejt-e veszélyt a megközelítés, ha igen mit? /2p/ 

# ADO.NET
Írjon ADO.NET kapcsolat alapú modellt követő példakódot, amely:  
- beszúr egy tetszőleges rekordot az alábbi táblába: `Student(__StudentID__, Name, TAJ) `  
A megoldásban nem szükséges SQL paramétereket használnia! A StudentID az adatbázis által automatikusan generált oszlop. /16p/
- az alábbi táblából törli azokat a rekordokat meleknél a személ születési éve (earOfBirth) kisebb 1950-nél, vag nincs megadva: `(__PersionID__, Name, YearOfBirth)` /16p/


# Csővezeték architektúra
a\ Ismertesse az adatnyelő által vezérelt csővezeték architektúrát szekvenciadiagramm segítségével (magyarázattal) /9p/

b\ Adjon meg pszeudo kódot szűrő (filter) komponens megvalósításához adatnyelő által vezérlet csővezeték architektúrában /6p/

# Document-View architektúra
Adja meg a document-view architektúra osztálydiagramját, magyarázattal. Adja meg a szereplő osztályok szerepét és, hogy miért került bevezetésre /15p/

# Dispose minta, Genetikus típusok, Bináris komponensek (reflexiók)
a\ Mikor célszerű dispose mintát használni? És mit biztosít számunkra? (3p)

b\ Adott az alábbi irányelv: egy objektum destruktorában ne férünk hozzá a felügyelt tagváltozásokhoz.
Adja meg 1 mondatban, miért /2p/

c1\ reflexió fogalma? 3 konkrét szolgáltatás /4p/

c2\ példakód egy adott osztályban szereplő tagváltozók neveinek listázására! /6p/

d\ Példakód saját, osztályokhoz kapcsolható (egyszerű/paraméter nélküli) .NET attribútum definiálására, használatára és lekérdezésére /9p/


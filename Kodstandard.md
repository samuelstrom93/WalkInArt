# DSU21_2
Distribuerad systemutveckling


## Kodstandarder


### Branches
* Döp branch så att man kan koppla kortnummer till task i Trello samt ett deskriptivt namn för enklare förståelse av branchen. T.ex. ```feature/#kortnummer_x``` Där kortnummer motsvarar kort i Trello samt x motsvarar feature som jobbas på. Feature är utbytbart beroende på typ av arbete.
T.ex. ```layout/#124_HomePage```för designarbete på hemsidan.
* När du jobbar med t.ex. **Design-branchen**, skapa en branch utifrån design. När du sedan är färdig med ditt arbete gör du sedan en pull request eller kollar med andra i gruppen så att den godkänns av någon utöver dig själv innan den pushas in till Design-branchen. Sedan kan vi när vi känner oss redo för en sprint release pusha mot **Develop-branchen** och slutligen **Master-branchen** när det är godkänt av produktägare.

* ```databas/``` för databasarbete.
* ```layout/```för design-arbete.

På så sätt får vi en bra struktur på våra branches och de blir enklare att arbeta med branches och hitta dem. 

### HTML
* Bind ihop klasser och id med bindestreck - ```grid-art``` istället för ```gridArt```
* Deskriptiva namn på CSHTML-sidorna så att det är tydligt vad sidan innefattar.
* Använd semantisk HTML istället för att överanvända div-element så att HTML-koden blir både med tillgänglig och lättförståelig.

### CSS
* Använd färgkoder - ```color: #fff``` istället för ```color: white;```
* Inga block-element inuti inline-element
* Modularisera och strukturera CSS i separata css-filer. Skapa en egen css-fil ```categories.css``` för kategori-sidan.

### JavaScript
* Försök så långt som det är möjligt att lägga allt som rör JavaScript kod i JS-filerna för att få en bättre översikt på JavasScript-koden. Använd i den mån det går hellre EventListener i JS-filerna istället för t.ex. onclick eller onchange i HTML-koden.
*  Kommentera JavaScript kod som inte är självförklarande.

### C#-metoder
* Kommentera metoder och kod som inte är självförklarande eller behöver en förklaring.
* Använd tre snedstreck "///" för att skapa en kommentar i VS till metoder som är mer omfattande och kräver förklaring. Kommentera gärna parameter för en mer ingående förståelse för hur metoden fungerar.
        
        /// <summary>
        /// Filterar vilka filmer som ska visas mha. inparametrar. 
        /// </summary>
        /// <param name="count">Hämtar antalet filmer</param>
        /// <param name="sortOrder"></param>
        /// <param name="sortType"></param>
        /// <returns></returns>
        
        
### Övrigt
* **Boy scout rule** - när du är inne i en ny branch och hittar kod som inte används eller kod som går att skriva om. Gör görna det så får vi koden tillsammans mycket snyggare. Innan du ändrar någon annans kod - fråga gärna denna person så att man inte har sönder något.
* Använd indentering till din fördel för att göra koden mer läsbar. ```Ctrl + k + f``` på markerad kod i Visual Studio för att formattering av koden.


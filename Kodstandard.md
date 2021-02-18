# DSU21_2
Distribuerad systemutveckling


# Förslag på kodstandarder!!!

## Kodstandarder


### Branches
* Döp branch med ett vettigt namn. T.ex. ```feature/#kortnummer_x``` Där kortnummer motsvarar kort i Trello samt x motsvarar feature som jobbas på. Feature är utbytbart beroende på typ av arbete.
T.ex. ```layout/#124_HomePage```för designarbete på hemsidan.
* När du jobbar med t.ex. **Design-branchen**, skapa en branch utifrån design. När du sedan är färdig med ditt arbete gör du sedan en pull request som behöver godkännas av någon än dig själv för att få pushas in till Design-branchen. Sedan kan vi när vi känner oss redo för en sprint release pusha mot **Develop-branchen** och slutligen **Master-branchen** när det är godkänt av produktägare.

**Förslag**
* ```testing/``` för enhetstestning.
* ```layout/```för design-arbete.
* fler förslag?

På så sätt får vi en bra mappstruktur och enklare att arbeta med branches.

### HTML/CSS
* Använd färgkoder - ```color: #fff``` istället för ```color: white;```
* Bind ihop klasser och id med bindestreck - ```grid-art``` istället för ```gridArt```
* Strukturera CSS i separata css-filer. Skapa en ```categories.css``` för category-sidan.



### Enhetstestning
* Testklass ska sluta på **Should**. T.ex. ```PlayerCharacterShould``` och då kan metod heta ```BeInExperiencedWhenNew()```.
På så sätt svarar metodnamnet ```BeInExperiencedWhenNew()``` på testklassen med ```...Should```.



### C#-metoder
* Använd tre snedstreck "///" för att skapa en kommentar i VS till metoder som kräver är mer omfattande och kräver förklaring. Kommentera gärna parameter för en mer ingående förståelse för hur metoden fungerar.
        
        /// <summary>
        /// Filterar vilka filmer som ska visas mha. inparametrar. 
        /// </summary>
        /// <param name="count">Hämtar antalet filmer</param>
        /// <param name="sortOrder"></param>
        /// <param name="sortType"></param>
        /// <returns></returns>
        
        
## FLER FÖRSLAG?!


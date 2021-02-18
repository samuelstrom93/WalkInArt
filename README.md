# DSU21_2
**Distribuerad systemutveckling grupp 2**

## WalkInArt

WalkInArt är en sida för älskare av konst och konstnärer. Här kan konstnärer lägga upp sina verk och besökarna kan uppleva konsten i VR för en immersiv upplevelse. Besökarna ska känna att dem har möjlighet att välja konst från en stor katalog och känna att dem är som på plats i en konsthall! Men i själva verket sitter du hemma på sängkammaren, eller på tåget hem från en resa. Vi tycker att konst ska kunna upplevas **överallt**!

Har man inte VR-glasögon tillhands så frukta ej! VR går att upplevas utan VR-glasögon, rakt upp och ner i webbläsaren. Du rör dig genom dina piltangenter och kan använda musen för flytta din syn.

Är man inte mycket för VR eller har en begränsad uppkoppling så kan man åtnjuta konsten som på en mer traditionell hemsida där tavlorna hänger på en bakgrund som konstnären kan välja och sedan kan navigera sig emellan olika delar av rummet genom att använda sig av navigationspilar. 

När man kommer in på WalkInArts startsida så har du i VR-rummet möjlighet att välja mellan olika utställningar. Genom att hovra över en tavla på första sidan kan du välja den utställning och du kommer sedan in utställningens rum och kan skåda alla tavlor. Vill du byta miljö kan du byta till antingen ett till VR-rum genom att "Byt rum" eller gå till ett mer traditionellt sätt att beskåda konst på i form av 2d.

WalkInArt finns tillgänglig på https://grupp2.dsvkurs.miun.se/. 


## Tekniker

### Arkitektur

Projektet är skapat i Visual Studio med hjälp av ramverket ASP.NET core och enligt MVC-mönstret. Här jobbar vi även med vymodeller för att minska beroenden mellan logiken och det vyerna. I projektet har vi även jobbat med asynkron programmering för att snabba upp webbsidan.

### A-frame
A-frame är ramverket vi använt för att bygga våra VR-rum och är baserat på HTML-kod. Här har vi använt oss av 3d-modeller för att bygga upp en immersiv upplevelse. Mer information kring ramverket A-frame finns på [A-frame dokumentation](https://aframe.io/docs/1.2.0/introduction/faq.html).


### API
Sökfunktioner är ofta en central del av webbsidor och för att enkelt kunna hitta en konstutställning du älskar eller bara vill besöka kan du söka på den, eller för den delen en kategori. Därför har vi skapat en sökfunktion som efter du skrivit ned minst två bokstäver får förslag på utställningar eller kategorier som matchar det du söker på. För att möjliggöra att det har vi skapat ett API. 

API:et finns tillgängligt på https://grupp8.dsvkurs.miun.se/.

Ett exempel på ett API-anrop är: https://grupp8.dsvkurs.miun.se/api/artists som returnerar alla artister på hemsidan via databasen. 


### Databas EF

Infoga bild på databas-diagram



### Google-login
Så att utställarna kan logga in och skapa en profil samt lägga till en utställning behövs det inlogg. Vi har använt oss av Googles OAUTH 2.0 protocol för att autentisera och legitimera användarna. Genom cookies sparas använda inlogg när de rör sig på hemsidan och behöver således inte logga in igen.

### Facebook dela-knapp

På 2D-utställningarna har vi implementerat en **dela-knapp** för Facebook. Om en användare använder funktionen kan dem dela den utställning de är varit inne på och integrera i sitt Facebook-flöde.


### Kodstandarder 

[Länk till MD-fil med kodstandarder](Kodstandard.md)

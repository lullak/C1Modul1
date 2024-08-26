// 1. Vad är en variabel? Vad är en datatyp?
// En variabel är en container för att lagra data. De innehåller en datatyp (tex int) ett namn (tex testNamn) och ett värde ( tex för en int 1)
//int testNamn = 1;
// en datatyp specificerar vilken typ av data och storlek i minnet en variabel ska ha.

// 2. Vad betyder ordet const? När används det?
// Const står för constant och används när man inte ska kunna skriva över värdet man anger med en annan, de är "read-only".

// 3. Vilka olika operatorer finns det och hur används de?
// Arithmetic, assignment, comparison och logical.
// Arithmetic operatorer används oftast för att utföra mathematical operations. + - * / %
// Assignment operatorer används för att tilldela eller uppdatera värden till variabler. = += *= /= -=
// Comparison operatorer används för att jämföra värden eller variabler. De retunerar True/false. == != < <= > >= 
// Logical operatorer används för att sammansätta villkor där tex, en eller flera måste vara uppfyllda. && || !
// Bitwise operators Överkurs men de används i bitnivå. & | ^ ~ << >>


// 4. Vilken roll har parenteser tillsammans med operatorer?
// De används för att styra prioriterinsgordningen 

// 5. När används tecknet ; i C#?
// För att signalera slutet på en kodrad

// 6. Vad kallas detta tecken \ . Hur används det?
// \ används som en escape-tecken dvs om man vill få med " i en text så kan man använda \" så den blir synlig, några andra vanliga är \t \n \\

// 7. Vad innebär det att använda ++? När görs detta ofta?
// tex i++ används oftast i samband med loopar för att "increament" dvs öka värdet med 1. Även -- går att använda för att minska med 1.

// 8. Vilka datatyper kan ha värdet null? Vad innebär null? Ge exempel.
// String och object har värdet null om de inte pekar på något object i minnet.
// Även int kan vara nullable genom int? dvs om man har ett registeringsformulär där man kan ange ålder men det finns ingen krav att man måste göra det då kan int? age; användas


//9.Vad är ett kodblock? Hur kan man se var det börjar och slutar?
// en samling av koder mellan hakparanterserna {} som börjar på { och sluter på }

// 10.I vilket sammanhang kan man använda typen var?
// var kan användas utan att ange vilken typ den ska ha genom att tilldella en variabel ett värde där compiler ger den en typ baserat på värdet man gett.

//11.Vad innebär typkonverteringar? Ge exempel.
// En typ konvertering är om man vill ändra från en typ till en annan till int till double.
// Ett exempel på detta är int temperature = 23;
// double doubleTemperature = (double)temperature;

//12.Vad är en array? Hur deklarerar man en array? Hur initierar man en array? Vad är skillnaden?
// En array används för att samla flera värden i en variabel istället för att ange en variabel per värde.
//En array deklaras på detta sätt: int[] array = new array[5]; 
//En array kan initieras på detta sätt: int[] array = { 1, 2, 3, 4, 5 };
// kan även intieras på detta sätt array[0] = 23; array[1] = 35; osv.
//När man deklrerar en array anger man typen och storlken på en array.
// När man initierar den tilldelar man Arrayen värden.

//13.Vad är skillnaden mellan en for, while eller foreach loop?
// en for loop används när man vet hur många gånger loopen ska köras.
// en while loop används när man vill kära loopen så länge ett villkor är sant.
// en foreach används för att iterera genom varje element i en collection tex array eller list.

//14.Vad är en ternary operator och vad kan fördelen med att använda en sådan vara?
// Är en förenklad if else sats som kan användas för att göra koden mer lättläslig.
// int test = 25;
// int test1 = (test <= 30) ? "siffran är lägre eller lika med 30" : "siffran är högre än 30";
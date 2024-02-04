// See https://aka.ms/new-console-template for more information

//rakendus küsib kasutajal valida tema sugu (m/f)
//rakendus küsib kasutajal sisestada tema perekonnanime
//lähtudes kasutaja valikust, rakendus tervitab kasutajat järgmiselt:
//"Welcome, Mr. [kasutaja perekonnanimi]" / "Welcome, Ms. [kasutaja perekonnanimi]"
// kirjuta CW, vajuta 2x korda TAB ja tuleb Console.WriteLine();

Console.WriteLine("Please, select your gender (m/f):");
//char kasuta kui on üks sümbol (m/f)
char userGender = Char.Parse(Console.ReadLine());// loeb konsoolist maha andmeid string (sõne) formaadis
Console.WriteLine("Please, enter your last name:");
string userLastName = Console.ReadLine();
//kasutaja nime küsimine peab olema enne if lauseid, sest koodi loetakse ülevalt alla.Muidu pole andmeid kusagilt võtta.
// if blokis ehk mis jääb () peale if võib ainult võrrelda andmeid, ei tee tehteid
// == võrdlemine
if (userGender == 'm')
{
    Console.WriteLine($"Welcome, Mr. {userLastName}!");//Kui on need andmed kasutatud, siis need kustuvad vahemälust, jäävad ainult konsooli.
}

else if(userGender == 'f')
{
    Console.WriteLine($"Welcome, Ms. {userLastName}!");//et kood saaks teksti sisse sisestada andmeid kasuta $ märki sulgudes jutumärgi ees.
}
//jutumärgid"" on sõnadele. ' on sümbolile või üksikule tähele. Süsteem teeb vahet char ja stringil
else
{
    Console.WriteLine($"Welcome, {userLastName}!");
}
//if ja else if vahe - kui on if ära kontrollinud ja on õige, siis ei hakka else if-ga veel lisaks kontrollima
//Kui on if ja if, siis kontrollib kõik läbi ja teeb üleliigset tööd.
//Stack - primitiivsed sümbolid, numbrid(char) üksik sisend. Heap - keerulisemad andmetüübid (string).
//Heapist läheb stacki ja loob indeksid
//Kui lood rakenduse, mõtle vahemälule, võimalikult palju säästa vahemälu.
//Kui on valikus üks sümbol näiteks m(male), kasuta char vahemälu säästmiseks.


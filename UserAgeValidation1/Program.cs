//rakendus küsib kasutajal sisestada tema vanus
//kui kasutaja vanus on väiksem kui 13, siis konsoolis kuvatakse:
//"You are too young to use Instagram"
//muul juhul
//konsoolis kuvatakse "Welcome to Instagram"

Console.WriteLine("Enter your age:");

int userAge  = Int32.Parse(Console.ReadLine()); //"13" - heap (string), 13 - stack (int)
//Et võrrelda andmeid, need peavad olema samat tüüpi. int -> 13. string ->"13"
if (userAge >= 13) // >= kasutaja vanus suurem või võrdub. 
{
    Console.WriteLine("Welcome to Instagram!");
}
//else if(userAge == 13)
//{
//    Console.WriteLine("Welcome to Instagram!");
//} ÜLELIIGNE
else //if (userAge < 13) ei ole vaja kasutada
{
    Console.WriteLine("You are too young to use Instagram.");
}

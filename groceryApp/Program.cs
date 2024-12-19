
using System;

Console.WriteLine("MERHABA, MANAVIMIZA HOŞGELDİNİZ.\nHANGİ MEYVEYİ SATIN ALMAK İSTERSİNİZ?");

string userInput = Console.ReadLine();

string userInput2 = userInput.ToLower();

/*

if (userInput2 == "elma")
{
    Console.WriteLine("Elma: 2TL");
}
else if(userInput2=="armut")
{
    Console.WriteLine("Armut: 3TL");
}
else if (userInput2 =="çilek" )
{
    Console.WriteLine("Çilek: 2TL");
}
else if (userInput2 == "muz")
{
    Console.WriteLine("Muz: 3TL ");
}
else
{
    Console.WriteLine(userInput2+": 4 TL");
}
*/

switch (userInput2)
{
    case "elma":
        Console.WriteLine("Elma: 2TL");
        break;

    case "armut":
        Console.WriteLine("Armut: 3TL");
        break;

    case "çilek":
        Console.WriteLine("Çilek: 2TL");
        break;

    case "muz":
        Console.WriteLine("Muz: 3TL ");
        break;

    default:
        Console.WriteLine(userInput2 + ": 4 TL");
        break;

}


// switch-case yapısı bu uygulama için daha kullanışlıdır.
// Sabit değer kontrolleri için switch-case daha idealdir, daha okunaklıdır.
// if/else yapısı daha karmaşık durumlar için kullanılabilir.


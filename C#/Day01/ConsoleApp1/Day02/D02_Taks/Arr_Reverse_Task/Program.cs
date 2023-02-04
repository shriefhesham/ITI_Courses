string Word = Console.ReadLine() ;
string[] ReversedString = Word.Split(' ') ;
Array.Reverse(ReversedString) ;
string Word1 = string.Join(" ", ReversedString) ;    
Console.WriteLine(Word1) ;    
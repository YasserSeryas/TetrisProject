public bool Contains (char value);
{
    while (line != 'o' && line != 'n')
            {
                Console.WriteLine("La boucle va etre enlever ?");
                line = char.Parse(Console.ReadLine());
            }
}



var year = 1950
var dateOfBirth = 1992

while year < dateOfBirth {
    print("Nous sommes en \(year). Je ne suis pas né !")
    year += 1
}

print("Nous sommes en \(year). Je suis né !")
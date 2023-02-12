//N кеглей выставили в один ряд, занумеровав их слева направо числами от 1 до N. Затем по этому ряду бросили K шаров, при этом i-й шар сбил все кегли с номерами от li до ri включительно. Определите, какие кегли остались стоять на месте
Console.WriteLine("Введите количество кеглей и количество бросков через пробел");

string numberNK = Console.ReadLine() ?? "0";
string[] numberNKarr = numberNK.Split(' ');
string numberNK0 = numberNKarr[0];
string numberNK1 = numberNKarr[1];
int numberN = int.Parse(numberNK0);
int numberK = int.Parse(numberNK1);

string[] pins = new string[numberN];
for(int i = 0; i < pins.Length; i++)
{
    pins[i] = $"{i+1}";
}
for(int i = 0; i < numberK; i++)
{
    Console.WriteLine($"Введите через пробел пару номеров кегль, сбитых {i+1} броском");
    string pinnumber = Console.ReadLine() ?? "0";
    string[] pinnumbers = pinnumber.Split(' ');
    for(int j = 0; j < pins.Length; j++)
    {
        if(pinnumbers[0] == pinnumbers[1] && pins[j] == pinnumbers[0])
        {
            pins[j] = ".";
        }
        else if(pinnumbers[0] != pinnumbers[1] && pins[j] == pinnumbers[0])
        {
            int temp1 = j;
            int temp2 = 0;
            for(int k = j + 1; k < pins.Length; k++)
            {
                if(pins[k] == pinnumbers[1])
                {
                    temp2 = k;
                }
                for(int l = temp1; l <= temp2; l++)
                {
                    pins[l] = ".";
                }
            }
        }
        else if(pinnumbers[0] != pinnumbers[1] && pins[j] == pinnumbers[1])
        {
            while(pins[j] != ".")
            {
                pins[j] = ".";
                j = j - 1;
            }
        }
    }
}
for(int i = 0; i < pins.Length; i++)
{
    if(pins[i] != ".")
    {
        pins[i] = "I";
    }
    Console.Write(pins[i]);
}

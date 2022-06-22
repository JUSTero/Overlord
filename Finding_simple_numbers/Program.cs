Console.WriteLine("Введите нижний предел");
string mintemp = Console.ReadLine();
int min = Convert.ToInt32(mintemp);
Console.WriteLine("Введите верхний предел");
string maxtemp = Console.ReadLine();
int max = Convert.ToInt32(maxtemp);

int count = 0;
int i = 7;

while(count < 5)

{   
    int count_div = 0;
    Random c = new Random();
    int a = c.Next(min, max + 1);
    
    if (a == 1 ^ a == 2 ^ a == 3 ^ a == 5)

    {  
        Console.WriteLine(a);
        count++;
        continue;
    }

    if (a % 2 == 0)

    {
        continue;
    }

    else if (a % 3 == 0)
    {
        continue;
    }

    else if (a % 5 == 0)
    {
        continue;
    }
    
    else if (a * a % 10 != 1)
    {
        for (i = 7; i <= Math.Sqrt(a); i += 2)
            {
                if (a % i == 0)
                {
                    count_div += 1;
                } 
            
                if (count_div > 0)
                {
                    break;
                }
            }
        if (count_div == 0)
        {
            int b = a;
            int sum = 0;
            while (b >= 10)
            {
                sum = sum + b % i;
                b = b / i;
            }

            sum = sum + b;
            if (10 < sum & sum < 20)
            {
                Console.WriteLine(a);
                count++;
            }
        }
    }
}
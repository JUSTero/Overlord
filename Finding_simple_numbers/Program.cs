int count = 0;
int i = 7;

while(count < 5)
{
    count_div = 0;
    a = rnd.Next();
    
    if (a == 1) or (a == 2); or (a == 3); or (a == 5);
    {   
        Console.WritLine(a);
        count++;
        continue;
    }

    if (a % 2 == 0) or (a % 3 == 0); or (a % 4 == 0); or (a % 5 == 0);
    {
        continue;
    }

    if (a * a % 10 != 1)
    {
        while (i <= Math.sqrt(a));
            {
                if (a % i == 0)
                {
                    count_div += 1;
                } 
            
                if (count_div > 0)
                {
                    break;
                }
                i++;
            }
        if (count_div == 0)
        {
            b = a;
            sum = 0;
            while (b => 10)
            {
                sum = sum + b % i;
                b = b / i;
            }

            sum = sum + b;
            if (10 < sum < 20)
            {
                Console.WritLine(a);
                count++;
            }
        }
    }
}
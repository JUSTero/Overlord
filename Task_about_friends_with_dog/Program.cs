double count = 0;
double friend = 2;
double time = 0;
Console.WriteLine("Введите расстояние ");
double distance = Convert.ToDouble (Console.ReadLine());
Console.WriteLine("Введите скорость первого друга ");
double first_speed = Convert.ToDouble (Console.ReadLine());
Console.WriteLine("Введите скорость второго друга ");
double second_speed = Convert.ToDouble (Console.ReadLine());
Console.WriteLine("Введите скорость собаки ");
double dog_speed = Convert.ToDouble (Console.ReadLine());

while(distance > 10)
{
    if(friend == 1)
    {
        time = distance / ( first_speed + dog_speed );
        friend = 2;
    }
    else
    {
        time = distance / ( second_speed + dog_speed );
        friend = 1;
    }

    distance = distance - ( first_speed + second_speed ) * time;
    count ++;
}

count = Convert.ToInt32(count);

Console.Write($"Собака пробежит {count} раз");
//Два друга и собака.

int count = 0;
int distance = 10000;
int firstSp = 1;
int secondSp = 2;
int dogSp = 5;
int flag = 2;
int time = 0;

while (distance > 10)
{
    if (flag == 1)
    {
        time = distance / (secondSp + dogSp);
        flag = 2;
    }
    else
    {
        time = distance / (firstSp + dogSp);
        flag = 1;
    }
    distance = distance - (firstSp+secondSp)*time;
    count++;
}
Console.WriteLine(count);
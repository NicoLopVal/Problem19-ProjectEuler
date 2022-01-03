int[] monthDays = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
int currentYear = 1900;
int currentDay = 0;
int dayOfWeek = 0;
int totalSundays = 0;

while (currentYear <= 2000)
{
    if (currentYear % 4 == 0)
    {
        if (currentYear % 400 == 0)
            monthDays[2] = 29;
        else if (currentYear % 100 == 0)
            monthDays[2] = 28;
        else
            monthDays[2] = 29;
    }
    else
        monthDays[2] = 28;
    for (int month = 1; month <= 12; month++)
    {
        for (int day = 1; day <= monthDays[month]; day++)
        {
            currentDay++;
            if (dayOfWeek < 7)
                dayOfWeek++;
            else if (dayOfWeek == 7)
                dayOfWeek = 1;
            if (dayOfWeek == 7 && currentDay == 1 && currentYear > 1900)
                totalSundays++;
        }
        currentDay = 0;
    }
    currentYear++;

}
Console.WriteLine("The number of Sundays that fell on the first of the month during the twentieth century (1 Jan 1901 to 31 Dec 2000) is: " + totalSundays);
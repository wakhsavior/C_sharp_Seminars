using System.Globalization;



bool correctnum = false;
int dayNumber = 0;
while(correctnum == false){
    
    Console.Write("Enter Number 1 to 7: ");

    dayNumber = Convert.ToInt32(Console.ReadLine());
    

    if (dayNumber <= 7 && dayNumber >= 1){
        Console.Write("The day of the week for " + dayNumber + " is " + CultureInfo.CurrentCulture.DateTimeFormat.DayNames[dayNumber-1]);
        correctnum = true;
    }
}
// See https://aka.ms/new-console-template for more information
// ask for input
Console.WriteLine("Enter 1 to create data file.");
Console.WriteLine("Enter 2 to parse data.");
Console.WriteLine("Enter anything else to quit.");
// input response
string? resp = Console.ReadLine();

if (resp == "1")
{
    // TODO: create data file
        // ask a question
    Console.WriteLine("How many weeks of data is needed?");
    // input the response (convert to int)
    int weeks = int.Parse(Console.ReadLine());
        // determine start and end date
    DateTime today = DateTime.Now;
    // we want full weeks sunday - saturday
    DateTime dataEndDate = today.AddDays(-(int)today.DayOfWeek);
    // subtract # of weeks from endDate to get startDate
    DateTime dataDate = dataEndDate.AddDays(-(weeks * 7));
    Console.WriteLine("Week of {0:MMM}, {0:dd}, {0:yyyy}", dataDate);
        // random number generator
    Random rnd = new Random();

    // loop for the desired # of weeks
    while (dataDate < dataEndDate)
    {
        // 7 days in a week
        int total = 0;
        int[] hours = new int[7];
        for (int i = 0; i < hours.Length; i++)
        {
            // generate random number of hours slept between 4-12 (inclusive)
            hours[i] = rnd.Next(4, 13);
            
            total = +Convert.ToInt32(hours);
        
        }
        // M/d/yyyy,#|#|#|#|#|#|#
        Console.WriteLine($"{dataDate:MMMM/dd/yyyy} {string.Join("|", hours)}");
        Console.WriteLine("Su Mo Tu We Th Fr Sa Tot Avg");
        Console.WriteLine("-- -- -- -- -- -- -- --  --" );
        Console.Write($"{string.Join("  ", hours)}");
        //average hours
        Console.Write(total);
        //Console.Write(avg);
        //Total hours
        
        // add 1 week to date
        dataDate = dataDate.AddDays(7);
    }
    
}
else if (resp == "2")
{
    // TODO: parse data file

    // create data file


}
    

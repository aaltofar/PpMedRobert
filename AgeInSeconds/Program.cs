//int ageInput = 35;
int.TryParse(Console.ReadLine(), out int num);

//var timeNow = DateTime.Now.Year;
//Console.WriteLine(timeNow);

//Console.WriteLine("Hvor gammel er du?");
//int.TryParse(Console.ReadLine(), out int ageInput);

//var ageYear = new DateTime(timeNow.Year - ageInput);

// 365.2425 * 24 * 60 * 60; sekunder i ett år.

// fødselsår - 2022 = X. 

Console.WriteLine(365.2425 * 24 * 60 * 60 * num);

//totalDaysCounter * 24 * 60 * 60; totale dager å dele opp i sekunder.

//datetimenowyear - året man skriver inn, finner fødselsåret

//list of years, på den kjører vi en foreach
// if (DateTime.IsLeapYear(year) totalDaysCounter++;)

//913939200

//var result = ageInput
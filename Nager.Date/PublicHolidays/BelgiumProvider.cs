﻿using Nager.Date.Contract;
using Nager.Date.Model;
using System;
using System.Collections.Generic;

namespace Nager.Date.PublicHolidays
{
    public class BelgiumProvider : IPublicHolidayProvider
    {
        public IEnumerable<PublicHoliday> Get(DateTime easterSunday, int year)
        {
            //Belgium
            //https://en.wikipedia.org/wiki/Public_holidays_in_Belgium

            var countryCode = CountryCode.BE;

            var items = new List<PublicHoliday>();
            items.Add(new PublicHoliday(year, 1, 1, "Nieuwjaar", "New Year's Day", countryCode, 1967));
            items.Add(new PublicHoliday(easterSunday.AddDays(1), " Paasmaandag", "Easter Monday", countryCode, 1642));
            items.Add(new PublicHoliday(year, 5, 1, "Dag van de arbeid", "Labor Day", countryCode));
            items.Add(new PublicHoliday(easterSunday.AddDays(39), "Onze Lieve Heer hemel", "Ascension Day", countryCode));
            items.Add(new PublicHoliday(easterSunday.AddDays(50), "Pinkstermaandag", "Whit Monday", countryCode));
            items.Add(new PublicHoliday(year, 7, 21, "Nationale feestdag", "Belgian National Day", countryCode));
            items.Add(new PublicHoliday(year, 8, 15, "Onze Lieve Vrouw hemelvaart", "Assumption Day", countryCode));
            items.Add(new PublicHoliday(year, 11, 1, "Allerheiligen", "All Saints' Day", countryCode));
            items.Add(new PublicHoliday(year, 11, 11, "Wapenstilstand", "Armistice Day", countryCode));
            items.Add(new PublicHoliday(year, 12, 25, "Weihnachten", "Christmas Day", countryCode));

            return items;
        }
    }
}

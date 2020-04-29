using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAPI
{
    public class Country
    {
        public string Name { get; set; }
        public List<string> topLevelDomain { get; set; }
        public string alpha2Code { get; set; }
        public string alpha3Code { get; set; }
        public List<string> callingCodes { get; set; }
        public string Capital { get; set; }
        public List<string> altSpellings { get; set; }
        public string region { get; set; }
        public string subregion { get; set; }
        public long population { get; set; }

        public string domonym { get; set; }

        public List<string> timezones { get; set; }
        public List<string> borders { get; set; }
        public string nativeName { get; set; }
        public string numericName { get; set; }
        public List<Currency> currencies { get; set; }
        public List<Language> languages { get; set; }
        public string cioc { get; set; }
    }

    public class Language
    {
        public string iso639_1 { get; set; }
        public string iso639_2 { get; set; }
        public string name { get; set; }
        public string nativeName { get; set; }
    }

    public class Currency
    {
        public string code { get; set; }
        public string name { get; set; }
        public string symbol { get; set; }
    }
}


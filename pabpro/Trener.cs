//------------------------------------------------------------------------------
// <auto-generated>
//    Ten kod źródłowy został wygenerowany na podstawie szablonu.
//
//    Ręczne modyfikacje tego pliku mogą spowodować nieoczekiwane zachowanie aplikacji.
//    Ręczne modyfikacje tego pliku zostaną zastąpione w przypadku ponownego wygenerowania kodu.
// </auto-generated>
//------------------------------------------------------------------------------

namespace pabpro
{
    using System;
    using System.Collections.Generic;
    
    public partial class Trener
    {
        public Trener()
        {
            this.Drużyna = new HashSet<Drużyna>();
        }
    
        public int Trener_ID { get; set; }
        public string Trener_Imię { get; set; }
        public string Trener_Nazwisko { get; set; }
        public string Trener_Drużyna { get; set; }
    
        public virtual ICollection<Drużyna> Drużyna { get; set; }
    }
}
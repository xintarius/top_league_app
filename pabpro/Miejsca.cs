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
    
    public partial class Miejsca
    {
        public Miejsca()
        {
            this.Mecz = new HashSet<Mecz>();
        }
    
        public int Miejsca_ID { get; set; }
        public string Miejscowość { get; set; }
    
        public virtual ICollection<Mecz> Mecz { get; set; }
    }
}

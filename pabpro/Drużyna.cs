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
    
    public partial class Drużyna
    {
        public Drużyna()
        {
            this.Mecz = new HashSet<Mecz>();
            this.Mecz1 = new HashSet<Mecz>();
            this.Przynależność = new HashSet<Przynależność>();
        }
    
        public int Drużyna_ID { get; set; }
        public Nullable<int> Trener_ID { get; set; }
        public string Drużyna1 { get; set; }
    
        public virtual Trener Trener { get; set; }
        public virtual ICollection<Mecz> Mecz { get; set; }
        public virtual ICollection<Mecz> Mecz1 { get; set; }
        public virtual ICollection<Przynależność> Przynależność { get; set; }
    }
}

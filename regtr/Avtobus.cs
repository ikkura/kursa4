//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace regtr
{
    using System;
    using System.Collections.Generic;
    
    public partial class Avtobus
    {
        public Avtobus()
        {
            this.Perevozka = new HashSet<Perevozka>();
        }
    
        public int ID_Avtobus { get; set; }
        public string Номер { get; set; }
        public string Модель { get; set; }
        public string Номерной_знак { get; set; }
        public int Количество_мест { get; set; }
    
        public virtual ICollection<Perevozka> Perevozka { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Учебка
{
    using System;
    using System.Collections.Generic;
    
    public partial class Заказы
    {
        public int id { get; set; }
        public Nullable<int> id_клиента { get; set; }
        public Nullable<int> id_услуги { get; set; }
        public string Дата_заказа { get; set; }
        public Nullable<decimal> Стоимость { get; set; }
    
        public virtual Клиенты Клиенты { get; set; }
        public virtual Услуги Услуги { get; set; }
    }
}

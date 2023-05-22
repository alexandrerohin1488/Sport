//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sport
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Media.Imaging;

    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            this.ProductOrder = new HashSet<ProductOrder>();
        }
    
        public int ProductID { get; set; }
        public string ImagePath { get; set; }
        public string NameProduct { get; set; }
        public string Description { get; set; }
        public Nullable<int> ProducerIds { get; set; }
        public Nullable<decimal> Cost { get; set; }
        public Nullable<int> Discount { get; set; }
        public Nullable<int> CountProduct { get; set; }
    
        public virtual Producer Producer { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductOrder> ProductOrder { get; set; }

        public BitmapImage PathImg
        {
            get
            {
                return new BitmapImage(new Uri("/Images" + ImagePath, UriKind.Relative));
            }
        }
    }
}
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MiParcialito.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class user
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public user()
        {
            this.inscripciones = new HashSet<inscripciones>();
        }
    
        public int idUser { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public int edad { get; set; }
        public System.DateTime fecha_nacimiento { get; set; }
        public int idroles { get; set; }
        public int idStatus { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<inscripciones> inscripciones { get; set; }
        public virtual roles roles { get; set; }
        public virtual status status { get; set; }
    }
}

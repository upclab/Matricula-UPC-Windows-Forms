//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MatriculaUPC
{
    using System;
    using System.Collections.Generic;
    
    public partial class Desarrollador
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Desarrollador()
        {
            this.Avances = new HashSet<Avance>();
            this.DesarrolladorProyectoes = new HashSet<DesarrolladorProyecto>();
            this.Proyectoes = new HashSet<Proyecto>();
        }
    
        public int DesarrolladorId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int TipoDocumentoId { get; set; }
        public string NroDocumento { get; set; }
        public string Estado { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Avance> Avances { get; set; }
        public virtual TipoDocumento TipoDocumento { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DesarrolladorProyecto> DesarrolladorProyectoes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Proyecto> Proyectoes { get; set; }
    }
}

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
    
    public partial class Avance
    {
        public int AvanceId { get; set; }
        public int ProyectoId { get; set; }
        public string Descripcion { get; set; }
        public System.DateTime Fecha { get; set; }
        public int DesarrolladorReponsableId { get; set; }
        public decimal Porcentaje { get; set; }
        public decimal Horas { get; set; }
    
        public virtual Desarrollador Desarrollador { get; set; }
        public virtual Proyecto Proyecto { get; set; }
    }
}
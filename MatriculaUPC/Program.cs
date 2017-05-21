using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatriculaUPC
{
    static class Program
    {
        public static PC1_Web_20171Entities1 ctx = new PC1_Web_20171Entities1();

        public static frm_Desarrolladores frm_desarrolladores;
        public static frm_Desarrollador frm_desarrollador;
        public static frm_Proyectos frm_proyectos;
        public static frm_Proyecto frm_proyecto;
        public static frm_Equipo frm_equipo;
        public static frm_AsignarEquipo frm_asignar_equipo;
        public static frm_Principal frm_principal;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            frm_principal = new frm_Principal();
            frm_desarrolladores = new frm_Desarrolladores();
            frm_desarrollador = new frm_Desarrollador();
            frm_proyectos = new frm_Proyectos();
            frm_proyecto = new frm_Proyecto();
            frm_equipo = new frm_Equipo();
            frm_asignar_equipo = new frm_AsignarEquipo();
 
            Application.Run(frm_principal);
        }
    }
}

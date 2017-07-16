using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ventacar
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            OleDbConnection conexion = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source = Database.mdb");
            try

            {

                conexion.Open();

                conexion.Close();

            }

            catch (System.Exception ex)

            {

                MessageBox.Show("ERROR:" + ex.Message);

            }
            Application.Run(new Form1());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KfzVerwaltung
{

	// ToDo
	// Tankkosten berechnen!!!
    // zurückschreiben in Klasse ausständig
    // Loop bei Öffnen einer xml Datei und cancel drücken
    // Speichern und Datei Fußzeile beim Vergrößern des Fensters
    // Hauptfenster fixe Größe?

	// nicetohave
	// Eingabevalidierung 
	// Bilder anzeigen wenn VW, SEAT, etc.

	// Testen
	// Settings zurückschreiben
	// Fehler für andere Datei abfangen

	static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
								Application.Run(new FormMain());
                
            }
            catch (Exception ex)
            {
                //Errorhandling
                MessageBox.Show(ex.Message);
            }
        }
    }
}

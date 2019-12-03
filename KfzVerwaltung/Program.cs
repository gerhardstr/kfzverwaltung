using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KfzVerwaltung
{

	// ToDo
	// 1 Klasse Auto, 1 Klasse Kosten, 1 Klasse Tankkosten
	// blank car save fixing
	// Settings zurückschreiben
	// check auf numerische Werte bei Eingabe kw und wartungsintervall
	// Fehler für andere Datei abfangen
	// textboxfarbe ####### setzen
	// Abfrage speichern beim Beenden
	// check auf numerische Werte bei Eingabe kw und wartungsintervall



	// nicetohave
	// Eingabevalidierung 
	// Bilder anzeigen wenn VW, SEAT, etc.
	// grid layout ausblenden?
	// eventuell Logo Del ändern
	// anzeige speichervorgang

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

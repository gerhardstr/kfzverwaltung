using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KfzVerwaltung
{

    // ToDo
    // Datetime fixin
    // blank car save fixing
    // Bilder anzeigen wenn VW, SEAT, etc.
    // Settings zurückschreiben
    // Fehler für andere Datei abfangen
    // grid layout ausblenden?
    // eventuell Logo Del ändern
    // anzeige speichervorgang
    // Abfrage speichern beim Beenden
    // FormLogin abbrechen nochmal testen
    // check auf numerische Werte bei Eingabe kw und wartungsintervall
    // textboxfarbe ####### setzen
    // Eingabevalidierung 

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
                //Anmeldung am Programm
                FormLogin loginForm = new FormLogin();
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    Application.Run(new FormMain());
                }
                else
                {
                    MessageBox.Show("Sie haben leider nicht die Berechtigung das Programm zu nutzen.", "Keine Berechtigung", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                //Errorhandling
                MessageBox.Show(ex.Message);
            }
        }
    }
}

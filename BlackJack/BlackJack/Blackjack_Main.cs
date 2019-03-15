// Geoff Overfield
// Basic Blackjack card game

using System;
using System.Windows.Forms;

namespace BlackJack
{
    static class Blackjack_Main
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new BlackjackTable());
        }
    }
}

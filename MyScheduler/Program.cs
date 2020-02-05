/*
 CISP 405 Summer 2019 Tony Wang SID # 1443145
 
 Assignment 1 Description:
 Create the GUI for the calendar and appointments for basic
 learning of Visual C#.
 
 Program.cs
 Setting up the My Scheduler application GUI and then calling a new Form1 object.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyScheduler
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        // Main method begins program execution
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1()); // Declaring new Form1 object and executed.
        } // end Main
    }   // end class Program
}

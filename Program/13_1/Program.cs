using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using _13_1.Model;

namespace _13_1
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            TStatement group1 = new TStatement();
            //
            group1.ShowStatement();
            group1.Staz();
            group1.Goodjob();
            group1.AgeWorker();
        }
    }
}

using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using Newtonsoft.Json;
namespace Observador
{
    class Program
    {
        static readonly string Dir = @"C:/Users/Curso/Desktop/filesRevisar/";
        static readonly string Dirdos = @"C:\Users\Curso\Desktop\filesRevisar";
        static DataProductsEntities D = new DataProductsEntities();
        static int id;
        public static FileSystemWatcher f = new FileSystemWatcher(Dirdos, "*.*");
        public static ElWatcher ob;
        public static void Habilita()
        {
            f.EnableRaisingEvents = true;
            f.Changed += Accion;
            f.Created += Accion;
            f.Deleted += Accion;
        }

        private static void Accion(object source, FileSystemEventArgs e)
        {
            // Specify what is done when a file is changed, created, or deleted.
            Console.WriteLine($"File: {e.FullPath} {e.ChangeType}" + " " + DateTime.Now);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("App escuchando cambios en el directorio C:/Users/Curso/Desktop/filesRevisar");
            Habilita();
            int id = D.ChangesOnProduct.Select(x => x.IdLog).ToList().Last();
            ob = new ElWatcher(Dir, id);
            System.Timers.Timer timer = new System.Timers.Timer()
            {
                Interval = 1000
            };
            timer.Elapsed += Timer_Elapsed;
            timer.Start();
            Console.Read();
        }

        public static void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            ob.Ciclo();
        }
    }
}
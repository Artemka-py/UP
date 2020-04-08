using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace AistWPF
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static string intID = "";
        public static string FIOSotr = "";
        public static Int32 intDropStatis = 0;
        public static string strStatus = "Null";
        public static bool connect = false;
        private static Mutex _instanse;
        private const string _app_name = "ИНЖПРОМТОРГ";

        
    }
}

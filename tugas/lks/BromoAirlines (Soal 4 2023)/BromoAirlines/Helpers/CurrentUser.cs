using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BromoAirlines.Helpers
{
    /// <summary>
    /// Class helper static untuk menyimpan sesi user yang sedang aktif/login
    /// </summary>
    public static class CurrentUser
    {
        public static int ID { get; set; }
        public static string Username { get; set; }
        public static string Nama { get; set; }
        public static bool MerupakanAdmin { get; set; }

        /// <summary>
        /// Menghapus sesi user saat melakukan Logout
        /// </summary>
        public static void Clear()
        {
            ID = 0;
            Username = string.Empty;
            Nama = string.Empty;
            MerupakanAdmin = false;
        }
    }
}
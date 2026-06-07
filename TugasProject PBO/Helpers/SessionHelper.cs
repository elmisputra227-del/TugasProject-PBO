using System;
using System.Collections.Generic;
using System.Text;

namespace inventory_panen_mvc.Helpers
{
    public static class SessionHelper
    {
        public static int UserId { get; set; }
        public static string Username { get; set; }
        public static string Role { get; set; } // Admin, Petani, Customer (Sesuai folder Views Anda)

        public static void StartSession(int id, string username, string role)
        {
            UserId = id;
            Username = username;
            Role = role;
        }

        public static void ClearSession()
        {
            UserId = 0;
            Username = null;
            Role = null;
        }
    }
}

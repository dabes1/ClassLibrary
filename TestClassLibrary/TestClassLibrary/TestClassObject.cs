using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClassLibraryNamespace
{
    public class TestClassObject
    {
        private static string _clientID = "TEST_CLIENT_ID";
        private static string _secretID = "TEST_SECRET_ID";

        public static string GetClientID { get { return _clientID; } }
        public static string GetSecretID {  get { return _secretID; } }
    }
}

using System;

namespace AzureTrainingClassLibrary
{
    public class AzClass
    {

        public string GetName(string Fname, string Lname)
        {
            string FullName;
            FullName = Fname + " " + Lname;
            return FullName;
        }
    }
}

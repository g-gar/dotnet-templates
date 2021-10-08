using System;

namespace extensions {
    public static class GeneralPurposeExtensions{
        public static void Cout(this object obj, params object[] args) { 
            Console.WriteLine(obj.ToString(), args);
        }
    }
}
using System;

namespace classTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AssemblyBaseClass objectBase = new AssemblyBaseClass();
            objectBase.TestAssess();

            Console.WriteLine("");

        }
    }


    public class AssemblyBaseClass
    {
        private string privateValiable = "privateValiable";
        protected string protectedVaLiable = "protectedVaLiable";
        internal string internalValiable = "internalValiable";
        protected internal string protectedInternalVaLiable = "protectedInternalVaLiable";
        public string publicVaLiable = "publicVaLiable";

        public void TestAssess()
        {
            //not accessible

            //accessible
            Console.WriteLine(privateValiable);
            Console.WriteLine(protectedVaLiable);
            Console.WriteLine(internalValiable);
            Console.WriteLine(protectedInternalVaLiable);
            Console.WriteLine(publicVaLiable);
        }
    }

    public class AssemblyDerivedClass : AssemblyBaseClass
    {
        public void TestAssessInDerivedClass()
        {
            //not accessible
            //Console.WriteLine(privateValiable);

            //accessible
            Console.WriteLine(protectedVaLiable);
            Console.WriteLine(internalValiable);
            Console.WriteLine(protectedInternalVaLiable);
            Console.WriteLine(publicVaLiable);
        }
    }
}

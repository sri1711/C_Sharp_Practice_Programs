using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace Assignment1 
{
    class ClassReflections
    {
        public int a { get; set; }

        
        string str ;
        char abc;


        public void method1() { }

        private int method2() { return 0; }

        static void main(string[] args)
        {

            TypeInfo myType = typeof(ClassReflections).GetTypeInfo();
            IEnumerable<PropertyInfo> properties = myType.DeclaredProperties;
            
            IEnumerable<MethodInfo> methods = myType.DeclaredMethods;
            Console.WriteLine(myType);
            Console.WriteLine(properties);
            Console.WriteLine(methods);
            StringBuilder strBuilder = new StringBuilder();
            Console.WriteLine();
            strBuilder.Append("The properties are:");
            foreach (PropertyInfo p in properties)
            {
                strBuilder.Append(" " + p.Name);
            }
            strBuilder.Append("\n");
         
            strBuilder.Append("The methods are: ");
   foreach (MethodInfo m in methods)
            {
                strBuilder.Append(" " + m.Name);
   }
            Console.WriteLine(strBuilder);
           
        }
        
        
    }
}

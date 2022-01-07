using System;

namespace Program2.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            IPerson personm = new Man();
            IPerson personw = new Woman();

          //  Man m = new Man();
            string details = GetDetails(personm);
            //Woman w = new Woman();
        }

        

        private static string GetDetails(IPerson personm)
        {
            return personm.Name + "-" + personm.InterestedOn;
        }
        
       // private static string GetDetails(Man m)
        //{
        //    return m.Name + "-" + m.InterestedOn;
        //}
        //private static string GetDetails(Woman w)
        //{
         //   return w.Name + "-" + w.InterestedOn;
        //}
    }
}

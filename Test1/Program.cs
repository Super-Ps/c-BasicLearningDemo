using UnityEditor;
using UnityEngine;
using Humanizer;

namespace Test1 {


    //   public class sacnscen : MonoBehaviour { 

    //   }


    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine(" dotnet new  console -n Test2 -f net6.0");
            Human();
            HumanizeDates();
           // public static List<ArtResInfo> m_artResList = new List<ArtResInfo>()
        }

        static void Human() {
            Console.WriteLine("case".ToQuantity(0));
            Console.WriteLine("case".ToQuantity(1));
            Console.WriteLine("case".ToQuantity(5));
        }

        static void HumanizeDates() {
            Console.WriteLine(DateTime.UtcNow.AddHours(-24).Humanize());
            Console.WriteLine(DateTime.UtcNow.AddHours(-2).Humanize());
            Console.WriteLine(TimeSpan.FromDays(1).Humanize());
            Console.WriteLine(TimeSpan.FromDays(16).Humanize());
        }
    }

    
}
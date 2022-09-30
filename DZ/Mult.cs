using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace MyLib
{
    public static class Mult
    {
        public static string MultB(double value)
        {
            return $"{value * 1}\n{value * 2}\n" +
                $"{value * 3}\n{value * 4}\n" +
                $"{value * 5}\n{value * 6}\n" +
                $"{value * 7}\n{value * 8}\n" +
                $"{value * 9}\n{value * 10}\n";
        }
        public static string MultD(double value)
        {
            return $"{value / 1}\n{value / 2}\n" +
                $"{value / 3}\n{value / 4}\n" +
                $"{value / 5}\n{value / 6}\n" +
                $"{value / 7}\n{value / 8}\n" +
                $"{value / 9}\n{value / 10}\n";
        }
            
        public static string card(int value)
        {
            List<string> cards = new List<string>() {"такого нет",
              "такого нет","такого нет","такого нет",
                "такого нет","такого нет","шестерка",
            "семерка", "восьмерка","девятка","десятка","валет",
            "дама","король","туз"};
            return $"{value} - это {cards[value]}";

        }
    }
}

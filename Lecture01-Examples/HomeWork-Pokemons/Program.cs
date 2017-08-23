using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_Pokemons
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("請輸入Pokemon編號 : ");
            String num = Console.ReadLine();
            Console.Write("請輸入Pokemon名稱 : ");
            String name = Console.ReadLine();
            Console.Write("請輸入Pokemon高度 : ");
            String height = Console.ReadLine();
            Console.Write("請輸入Pokemons重量(lbs) : ");
            String weight = Console.ReadLine();
            Console.Write("請輸入Pokemon種類 : ");
            String category = Console.ReadLine();
            Console.WriteLine("輸入的Pokemon編號為{0},名稱為{1}," +
                "高度為{2},重量為{3}(lbs),種類為{4}。"
                , num, name, height, weight, category);
        }
    }
}
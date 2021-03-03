using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap15App
{
    class Profile
    {
        public string Name { get; set; }
        public short Height { get; set; }


    }

    class Product
    {
        public string Title { get; set; }
        public string Star { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 9, 2, 6, 4, 5, 3, 7, 8, 1, 10 };
            
            // LINQ 안쓰는 방식
            List<int> result = new List<int>();

            foreach (var item in numbers)
                if (item % 2 == 0)
                    result.Add(item);
            result.Sort();

            foreach (var item in result)
                Console.WriteLine($"짝수 : {item}");

            Console.WriteLine("---------------------");

            // LINQ 쓰는 방식
            // IEnumerable<int> result 2 = ~~~;
            var result2 = from item in numbers
                         where item % 2 == 0
                         orderby item
                         select item;

            foreach(var item in result2)
                Console.WriteLine($"짝수 : {item}");

            Console.WriteLine("---------------------");
            
            List<Profile> profiles = new List<Profile>();
            profiles.Add(new Profile() { Name = "정우성", Height = 186 });
            profiles.Add(new Profile() { Name = "김태희", Height = 158 });
            profiles.Add(new Profile() { Name = "고현정", Height = 172 });
            profiles.Add(new Profile() { Name = "이문세", Height = 178 });
            profiles.Add(new Profile() { Name = "하하"  , Height = 171 });

            List<Product> products = new List<Product>
            {
                new Product() { Title = "비트", Star = "정우성"},
                new Product() { Title = "CF다수", Star = "김태희"},
                new Product() { Title = "아이리스", Star = "김태희"},
                new Product() { Title = "모래시계", Star = "고현정"},
                new Product() { Title = "솔로예찬", Star = "이문세"}
            };
            /*IEnumerable < new { string Name, short Height, double InchHeight } > resProfiles_ =
                              from item in profiles
                              where item.Height < 175
                              orderby item.Height ascending // descending
                              select new
                              {
                                  item.Name,
                                  item.Height,
                                  InchHeight = item.Height * 0.393
                              };*/
             // 익명 클래스는 정의 + 초기화만 됨... 클래스를 새로 만들어야 되므로 var 형식을 이용한다!
             

            var resProfiles = from item in profiles
                              where item.Height < 175
                              orderby item.Height ascending // descending
                              select new
                              {
                                  item.Name,
                                  item.Height,
                                  InchHeight = item.Height * 0.393
                              };

            foreach (var item in resProfiles)
                Console.WriteLine($"이름 : {item.Name}, 키 : {item.Height}cm, {item.InchHeight}inch");

            Console.WriteLine("---------------------");

            var resProfiles2 = from item in profiles
                              where item.Height < 175
                              orderby item.Height ascending // descending
                              select item.Name;

            foreach (var item in resProfiles2)
                Console.WriteLine($"이름 : {item}");

            Console.WriteLine("---------------------");

            // groupby
            var resProfiles3 = from item in profiles
                               orderby item.Height
                               group item by item.Height < 175 into g
                               select new {
                                   GroupKey = g.Key,
                                   Items = g
                               };

            foreach (var group in resProfiles3)
            {
                Console.WriteLine((group.GroupKey) ? "175 미만 그룹" : "175 이상 그룹 ");
                foreach (var item in group.Items)
                    Console.WriteLine($"{item.Name} : {item.Height}cm");
            }

            Console.WriteLine("---------------------");

            // inner join
            var joinProfiles = from pf in profiles
                               join pd in products on pf.Name equals pd.Star
                               select new
                               {
                                   Name = pf.Name,
                                   Work = pd.Title,
                                   InchHeight = pf.Height * 0.393
                               };
            foreach (var item in joinProfiles)
                Console.WriteLine($"이름 : {item.Name}, 작품 : {item.Work}, 키 : {item.InchHeight}inch");

            Console.WriteLine("---------------------");

            // outer join
            var joinProfiles2 = from pf in profiles
                               join pd in products on pf.Name equals pd.Star into ps
                               from p2 in ps.DefaultIfEmpty(new Product() { Title = "작품없음" })
                               select new
                               {
                                   Name = pf.Name,
                                   Work = p2.Title,
                                   InchHeight = pf.Height * 0.393
                               };
            foreach (var item in joinProfiles2)
                Console.WriteLine($"이름 : {item.Name}, 작품 : {item.Work}, 키 : {item.InchHeight}inch");

            Console.WriteLine("---------------------");

        }
    }
}

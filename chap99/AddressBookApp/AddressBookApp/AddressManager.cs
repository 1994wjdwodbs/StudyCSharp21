using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookApp
{
    class AddressManager
    {

        // 주소록을 담을 List 컬렉션 (초기화)
        public List<AddressInfo> listAddress = new List<AddressInfo>();

        public void PrintMenu()
        {
            Console.WriteLine("▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒");
            Console.WriteLine("1. 주소입력");
            Console.WriteLine("2. 주소검색");
            Console.WriteLine("3. 주소수정");
            Console.WriteLine("4. 주소삭제");
            Console.WriteLine("5. 주소전체 출력");
            Console.WriteLine("6. 프로그램 종료");
            Console.WriteLine("▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒");
        }

        public int SelectMenu()
        {
            Console.Write("메뉴를 선택하세요 >>> ");
            string input = Console.ReadLine();
            int.TryParse(input, out int menuNum);
            if (!(menuNum > 0 && menuNum < 7))
                menuNum = 0;

            return menuNum;
        }

        public void inputAddress()
        {
            Console.Clear();

            Console.WriteLine("주소입력");
            Console.WriteLine("---------------------------------------------");
            Console.Write("이름 입력 : ");
            string name = Console.ReadLine();
            Console.Write("전화 입력 : ");
            string phone = Console.ReadLine();
            Console.Write("주소 입력 : ");
            string address = Console.ReadLine();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(address))
            {
                Console.WriteLine("빈 값은 입력할 수 없습니다.");
            }
            else
                listAddress.Add(new AddressInfo() { Name = name, Phone = phone, Address = address });
        }

        public void searchAddress()
        {
            Console.Clear();

            Console.WriteLine("주소검색");
            Console.WriteLine("---------------------------------------------");
            Console.Write("이름 입력 : ");
            string name2 = Console.ReadLine();
            int idx2 = 0;
            bool isFind2 = false;

            foreach (var item in listAddress)
            {
                if (item.Name == name2)
                {
                    Console.WriteLine($"[{idx2}]------------------------------------------");
                    Console.WriteLine($"이름 : {item.Name}");
                    Console.WriteLine($"전화 : {item.Phone}");
                    Console.WriteLine($"주소 : {item.Address}");
                    Console.WriteLine("---------------------------------------------");
                    isFind2 = true;
                    break;
                }
                idx2++;
            }
            if (!isFind2)
                Console.WriteLine("검색 결과가 없습니다.");

            Console.ReadLine(); // 화면 멈춤
        }

        public void updateAddress()
        {
            Console.Clear();

            Console.WriteLine("주소검색");
            Console.WriteLine("---------------------------------------------");
            Console.Write("이름 입력 : ");
            string name3 = Console.ReadLine();
            int idx3 = 0;
            bool isFind3 = false;

            foreach (var item in listAddress)
            {
                if (item.Name == name3)
                {
                    Console.WriteLine($"[{idx3}]------------------------------------------");
                    Console.WriteLine($"이름 : {item.Name}");
                    Console.WriteLine($"전화 : {item.Phone}");
                    Console.WriteLine($"주소 : {item.Address}");
                    Console.WriteLine("---------------------------------------------");

                    Console.Write("이름 재입력 : ");
                    string uName = Console.ReadLine();
                    Console.Write("전화 재입력 : ");
                    string uPhone = Console.ReadLine();
                    Console.Write("주소 재입력 : ");
                    string uAddress = Console.ReadLine();

                    if (string.IsNullOrEmpty(uName) || string.IsNullOrEmpty(uPhone) || string.IsNullOrEmpty(uAddress))
                    {
                        Console.WriteLine("빈 값은 입력할 수 없습니다.");

                        isFind3 = true;
                        break;
                    }
                    else
                    {
                        item.Name = uName;
                        item.Phone = uPhone;
                        item.Address = uAddress;

                        isFind3 = true;
                        break;
                    }
                }
                idx3++;
            }
            if (!isFind3)
                Console.WriteLine("검색 결과가 없습니다.");
        }

        public void deleteAddress()
        {
            Console.Clear();

            Console.WriteLine("주소검색");
            Console.WriteLine("---------------------------------------------");
            Console.Write("이름 입력 : ");
            string name4 = Console.ReadLine();
            int idx4 = 0;
            bool isFind4 = false;

            foreach (var item in listAddress)
            {
                if (item.Name == name4)
                {
                    Console.WriteLine($"[{idx4}]------------------------------------------");
                    Console.WriteLine($"이름 : {item.Name}");
                    Console.WriteLine($"전화 : {item.Phone}");
                    Console.WriteLine($"주소 : {item.Address}");
                    Console.WriteLine("---------------------------------------------");
                    Console.Write("삭제하시겠습니까? [y/n] : ");
                    string answer = Console.ReadLine();
                    if (answer.ToUpper() == "Y")
                    {
                        listAddress.RemoveAt(idx4);
                        Console.WriteLine("삭제했습니다.");
                        System.Threading.Thread.Sleep(1000);
                    }
                    isFind4 = true;
                    break;
                }
                idx4++;
            }
            if (!isFind4)
                Console.WriteLine("검색 결과가 없습니다.");
        }

        public void PrintAllAddress()
        {
            Console.Clear();

            Console.WriteLine("주소전체 출력");
            Console.WriteLine("---------------------------------------------");
            int idx5 = 0;
            foreach (var item in listAddress)
            {
                Console.WriteLine($"[{idx5}]------------------------------------------");
                Console.WriteLine($"이름 : {item.Name}");
                Console.WriteLine($"전화 : {item.Phone}");
                Console.WriteLine($"주소 : {item.Address}");
                Console.WriteLine("---------------------------------------------\n");
                idx5++;
            }
            Console.ReadLine(); // 화면 멈춤
        }
    }
}

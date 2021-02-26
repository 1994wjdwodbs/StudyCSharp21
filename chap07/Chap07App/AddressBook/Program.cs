using System;
using System.Collections.Generic;
using System.Linq;

/* 0 : 주소 입력 
 * 1 : 주소 검색
 * 2 : 주소 수정
 * 3 : 주소 삭제
 * 4 : 주소 전체 출력
 * 5 : 프로그램 종료 */

namespace ConsoleApp1
{
    class AddressBook
    {
        // idx, 이름, 전화, 주소 를 받는 정적 list
        private static List<(string, string, string)> list;

        // 정적 생성자
        static AddressBook()
        {
            // list 초기화 (1번만)
            list = new List<(string, string, string)>();
        }

        public void Menu()
        {
            Console.Clear();

            Console.WriteLine("------------------------");
            Console.WriteLine("[Address Book Ver 1.0]");
            Console.WriteLine("0. 입력");
            Console.WriteLine("1. 검색");
            Console.WriteLine("2. 수정");
            Console.WriteLine("3. 삭제");
            Console.WriteLine("4. 전체 출력");
            Console.WriteLine("5. 프로그램 종료");
            Console.WriteLine("------------------------");

            Console.Write("메뉴를 선택하세요 >>> ");
            bool is_Num = int.TryParse(Console.ReadLine(), out int number);
            if (is_Num)
            {
                switch (number)
                {
                    case 0:
                        Input();
                        break;

                    case 1:
                        Search();
                        break;

                    case 2:
                        Update();
                        break;

                    case 3:
                        Delete();
                        break;

                    case 4:
                        Print();
                        break;

                    case 5:
                        // 정상 종료
                        Environment.Exit(0);
                        break;

                    default:
                        // 비정상 종료
                        Environment.Exit(1);
                        break;
                }
            }
            else
            {
                return;
            }
        }

        // 입력
        public void Input()
        {
            string name, mobile, addr;
            Console.Clear();

            do
            {
                Console.WriteLine("------------------------");
                Console.Write("이름 (엔터 시 종료) : ");
                name = Console.ReadLine();
                if (string.IsNullOrEmpty(name))
                    break;

                Console.Write("전화 : ");
                mobile = Console.ReadLine();
                if (string.IsNullOrEmpty(mobile))
                    break;

                Console.Write("주소 : ");
                addr = Console.ReadLine();
                if (string.IsNullOrEmpty(addr))
                    break;
                Console.WriteLine("------------------------");

                list.Add((name, mobile, addr));
                // Console.WriteLine(list.ElementAt(list.Count - 1).Item1);
            } while (true);
        }

        // 검색
        public void Search()
        {
            Console.Clear();
            while (true)
            {
                Console.WriteLine("------------------------");
                Console.Write("검색 영역 선택(1.이름, 2.전화, 3.주소, etc.종료) : ");
                string select = Console.ReadLine();

                if (select.Contains('1') || select.Contains("이름"))
                    select = "1";
                else if (select.Contains('2') || select.Contains("전화"))
                    select = "2";
                else if (select.Contains('3') || select.Contains("주소"))
                    select = "3";
                else
                    break;

                Console.Write("검색 단어 : ");
                string search = Console.ReadLine();
                int count = 0;

                Console.WriteLine("------------------------");
                for (int i = 0; i < list.Count; i++)
                {
                    (string, string, string) ptr = list[i];
                    switch (select)
                    {
                        case "1":
                            if (ptr.Item1.Contains(search))
                            {
                                Console.WriteLine($"이름 : {ptr.Item1}");
                                Console.WriteLine($"전화 : {ptr.Item2}");
                                Console.WriteLine($"주소 : {ptr.Item3}");
                                Console.WriteLine("------------------------");
                                count++;
                            }
                            break;
                        case "2":
                            if (ptr.Item2.Contains(search))
                            {
                                Console.WriteLine($"이름 : {ptr.Item1}");
                                Console.WriteLine($"전화 : {ptr.Item2}");
                                Console.WriteLine($"주소 : {ptr.Item3}");
                                Console.WriteLine("------------------------");
                                count++;
                            }
                            break;
                        case "3":
                            if (ptr.Item3.Contains(search))
                            {
                                Console.WriteLine($"이름 : {ptr.Item1}");
                                Console.WriteLine($"전화 : {ptr.Item2}");
                                Console.WriteLine($"주소 : {ptr.Item3}");
                                Console.WriteLine("------------------------");
                                count++;
                            }
                            break;
                        default:
                            break;
                    }
                }
                Console.WriteLine($"검색 결과 : {count}건");
            }
        }

        // 수정
        public void Update()
        {
            Console.Clear();
            while (true)
            {
                Console.WriteLine("------------------------");
                Console.WriteLine("[수정할 영역 검색]");
                Console.Write("검색 영역 선택(1.이름, 2.전화, 3.주소, etc.종료) : ");
                string select = Console.ReadLine();

                if (select.Contains('1') || select.Contains("이름"))
                    select = "1";
                else if (select.Contains('2') || select.Contains("전화"))
                    select = "2";
                else if (select.Contains('3') || select.Contains("주소"))
                    select = "3";
                else
                    break;

                Console.Write("검색 단어 : ");
                string search = Console.ReadLine();
                List<int> idx = new List<int>(); // idx 리스트 초기화

                Console.WriteLine("------------------------");
                for (int i = 0; i < list.Count; i++)
                {
                    (string, string, string) ptr = list[i];
                    switch (select)
                    {
                        case "1":
                            if (ptr.Item1.Contains(search))
                            {
                                Console.WriteLine($"인덱스 : {i}");
                                Console.WriteLine($"이름 : {ptr.Item1}");
                                Console.WriteLine($"전화 : {ptr.Item2}");
                                Console.WriteLine($"주소 : {ptr.Item3}");
                                Console.WriteLine("------------------------");
                                idx.Add(i);
                            }
                            break;
                        case "2":
                            if (ptr.Item2.Contains(search))
                            {
                                Console.WriteLine($"인덱스 : {i}");
                                Console.WriteLine($"이름 : {ptr.Item1}");
                                Console.WriteLine($"전화 : {ptr.Item2}");
                                Console.WriteLine($"주소 : {ptr.Item3}");
                                Console.WriteLine("------------------------");
                                idx.Add(i);
                            }
                            break;
                        case "3":
                            if (ptr.Item3.Contains(search))
                            {
                                Console.WriteLine($"인덱스 : {i}");
                                Console.WriteLine($"이름 : {ptr.Item1}");
                                Console.WriteLine($"전화 : {ptr.Item2}");
                                Console.WriteLine($"주소 : {ptr.Item3}");
                                Console.WriteLine("------------------------");
                                idx.Add(i);
                            }
                            break;
                        default:
                            break;
                    }
                }
                Console.WriteLine($"검색 결과 : {idx.Count}건");

                if (idx.Count > 0)
                {
                    if (idx.Count == 1)
                    {
                        Console.WriteLine("------------------------");
                        Console.Write("이름 (엔터 시 수정취소) : ");
                        string name = Console.ReadLine();
                        if (string.IsNullOrEmpty(name))
                            continue;

                        Console.Write("전화 : ");
                        string mobile = Console.ReadLine();
                        if (string.IsNullOrEmpty(mobile))
                            continue;

                        Console.Write("주소 : ");
                        string addr = Console.ReadLine();
                        if (string.IsNullOrEmpty(addr))
                            continue;
                        Console.WriteLine("------------------------");
                        list[idx[0]] = ((name, mobile, addr));
                    }
                    else
                    {
                        Console.WriteLine("------------------------");
                        Console.Write("변경할 인덱스 번호 : ");
                        bool is_Idx = int.TryParse(Console.ReadLine(), out int sel_idx);
                        if (is_Idx)
                        {
                            int Idx = idx.FindIndex(x => x == sel_idx);
                            if (Idx != -1)
                            {
                                Console.WriteLine("------------------------");
                                Console.Write("이름 (엔터 시 수정취소) : ");
                                string name = Console.ReadLine();
                                if (string.IsNullOrEmpty(name))
                                    continue;

                                Console.Write("전화 : ");
                                string mobile = Console.ReadLine();
                                if (string.IsNullOrEmpty(mobile))
                                    continue;

                                Console.Write("주소 : ");
                                string addr = Console.ReadLine();
                                if (string.IsNullOrEmpty(addr))
                                    continue;
                                Console.WriteLine("------------------------");
                                list[idx[Idx]] = ((name, mobile, addr));
                            }
                        }
                        else
                            continue;
                    }
                }

            }
        }

        // 삭제
        public void Delete()
        {
            Console.Clear();
            while (true)
            {
                Console.WriteLine("------------------------");
                Console.WriteLine("[삭제할 영역 검색]");
                Console.Write("검색 영역 선택(1.이름, 2.전화, 3.주소, 4.etc) : ");
                string select = Console.ReadLine();

                if (select.Contains('1') || select.Contains("이름"))
                    select = "1";
                else if (select.Contains('2') || select.Contains("전화"))
                    select = "2";
                else if (select.Contains('3') || select.Contains("주소"))
                    select = "3";
                else
                    break;

                Console.Write("검색 단어 : ");
                string search = Console.ReadLine();
                List<int> idx = new List<int>(); // idx 리스트 초기화

                Console.WriteLine("------------------------");
                for (int i = 0; i < list.Count; i++)
                {
                    (string, string, string) ptr = list[i];
                    switch (select)
                    {
                        case "1":
                            if (ptr.Item1.Contains(search))
                            {
                                Console.WriteLine($"인덱스 : {i}");
                                Console.WriteLine($"이름 : {ptr.Item1}");
                                Console.WriteLine($"전화 : {ptr.Item2}");
                                Console.WriteLine($"주소 : {ptr.Item3}");
                                Console.WriteLine("------------------------");
                                idx.Add(i);
                            }
                            break;
                        case "2":
                            if (ptr.Item2.Contains(search))
                            {
                                Console.WriteLine($"인덱스 : {i}");
                                Console.WriteLine($"이름 : {ptr.Item1}");
                                Console.WriteLine($"전화 : {ptr.Item2}");
                                Console.WriteLine($"주소 : {ptr.Item3}");
                                Console.WriteLine("------------------------");
                                idx.Add(i);
                            }
                            break;
                        case "3":
                            if (ptr.Item3.Contains(search))
                            {
                                Console.WriteLine($"인덱스 : {i}");
                                Console.WriteLine($"이름 : {ptr.Item1}");
                                Console.WriteLine($"전화 : {ptr.Item2}");
                                Console.WriteLine($"주소 : {ptr.Item3}");
                                Console.WriteLine("------------------------");
                                idx.Add(i);
                            }
                            break;
                        default:
                            break;
                    }
                }
                Console.WriteLine($"검색 결과 : {idx.Count}건");

                if (idx.Count > 0)
                {
                    if (idx.Count == 1)
                    {
                        Console.Write("정말로 삭제할까요 ? (Y/N) : ");
                        string cmd = Console.ReadLine();
                        if (cmd.Contains('y') || cmd.Contains('Y'))
                            list.RemoveAt(idx[0]);
                        else
                        { }
                    }
                    else
                    {
                        Console.WriteLine("------------------------");
                        Console.Write("삭제할 인덱스 번호 : ");
                        bool is_Idx = int.TryParse(Console.ReadLine(), out int sel_idx);
                        if (is_Idx)
                        {
                            int Idx = idx.FindIndex(x => x == sel_idx);
                            if (Idx != -1)
                            {
                                Console.Write("정말로 삭제할까요 ? (Y/N) : ");
                                string cmd = Console.ReadLine();
                                if (cmd.Contains('y') || cmd.Contains('Y'))
                                    list.RemoveAt(idx[Idx]);
                                else
                                { }
                            }
                        }
                    }
                }

            }
        }

        // 전체 출력
        public void Print()
        {
            Console.Clear();

            string cmd;
            do
            {
                Console.WriteLine("------------------------");
                for (int i = 0; i < list.Count; i++)
                {
                    (string, string, string) ptr = list[i];
                    Console.WriteLine($"인덱스 : {i}");
                    Console.WriteLine($"이름 : {ptr.Item1}");
                    Console.WriteLine($"전화 : {ptr.Item2}");
                    Console.WriteLine($"주소 : {ptr.Item3}");
                    Console.WriteLine("------------------------");
                }
                Console.WriteLine($"총 {list.Count}건의 정보가 있습니다.\n");
                Console.Write("다시 보실래요? 나갈래요? (y/n) : ");
                cmd = Console.ReadLine();
            } while (cmd.Contains('y') || cmd.Contains('Y'));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            AddressBook book = new AddressBook();
            while (true)
                book.Menu();
        }
    }
}

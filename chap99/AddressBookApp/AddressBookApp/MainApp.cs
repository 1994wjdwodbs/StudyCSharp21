using System;
using System.Collections.Generic;
using System.IO;

namespace AddressBookApp
{
    class MainApp
    {
        static void Main(string[] args)
        {
            AddressManager manager = new AddressManager();
            DataFileManager fileManager = new DataFileManager();

            // 시작 전에 파일 읽기
            fileManager.ReadData(manager.listAddress);

            while(true)
            {
                Console.Clear();

                manager.PrintMenu();
                int menuNum = manager.SelectMenu();
                
                switch(menuNum)
                {
                    case 0:
                        break;

                    case 1:
                        manager.inputAddress();
                        break;

                    case 2:
                        manager.searchAddress();
                        break;

                    case 3:
                        manager.updateAddress();
                        break;

                    case 4:
                        manager.deleteAddress();
                        break;

                    case 5:
                        manager.PrintAllAddress();
                        break;

                    case 6:
                        fileManager.WriteData(manager.listAddress);
                        Environment.Exit(0);
                        break;

                    default:
                        Environment.Exit(1);
                        break;
                }
                
            }

        }
    }
}

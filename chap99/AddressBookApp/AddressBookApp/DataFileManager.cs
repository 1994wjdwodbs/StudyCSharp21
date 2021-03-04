using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookApp
{
    class DataFileManager
    {
        string filePath = Environment.CurrentDirectory + @"\address.dat"; // 데이터 파일
        public void ReadData(List<AddressInfo> param)
        {
            // 텍스트 파일에서 저장된 주소록을 불러온다(로드).

            // 파일 존재 안하면
            if (!File.Exists(filePath))
                return;

            StreamReader sr = new StreamReader(new FileStream(filePath, FileMode.Open, FileAccess.Read));
            while (sr.EndOfStream == false)
            {
                var temp = sr.ReadLine();
                string[] splits = temp.Split('|');
                param.Add(new AddressInfo() { Name = splits[0], Phone = splits[1], Address = splits[2] });
            }
            sr.Close();
        }

        public void WriteData(List<AddressInfo> param)
        {
            // 종료 전에 주소록을 다시 파일에 씀
            StreamWriter sw = new StreamWriter(
                new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write));
            if (param.Count > 0)
            {
                foreach (var item in param)
                {
                    sw.WriteLine($"{item.Name}|{item.Phone}|{item.Address}");
                }
            }
            sw.Close();
        }
    }
}

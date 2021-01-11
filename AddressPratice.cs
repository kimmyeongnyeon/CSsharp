using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AddressPratice
{
   enum CMD_NUM
    {
        INPUT,
        SEARCH,
        UPDATE,
        DELETE,
        PRINTALL,
        EXIT
    }

    class Adddress
    {
        private string name = "";
        public string phone = "";
        public string address = "";

        public string Name { get; internal set; }
    }

    class Program
    {
        static List<Adddress> listAddress =
            new List<Adddress>(10);
        static void Main(string[] args)
        {
            MainLoop();
        }

        static void MainLoop()
        {
            while (true)
            {
                ClearView();
                PrintMenu();
                int sel = GetSelMenu();

                switch ((CMD_NUM)sel)
                {
                    case CMD_NUM.INPUT:
                        InputAddress();
                        break;
                    case CMD_NUM.SEARCH:
                        SearchAddress();
                        break;
                    case CMD_NUM.UPDATE:
                        UpdateAddress();
                        break;
                    case CMD_NUM.DELETE:
                        DeleteAddress();
                        break;
                    case CMD_NUM.PRINTALL:
                        PrintAllAddress();
                        break;
                    case CMD_NUM.EXIT:
                        ProgramExit();
                        break;
                    default:
                        Console.WriteLine("Inalid Number");
                        break;
                }
            }
            static void PrintMenu()
            {
                Console.WriteLine("--------------------------");
                Console.WriteLine("0. 주소입력");
                Console.WriteLine("1. 주소 검색");
                Console.WriteLine("2. 주소수정");
                Console.WriteLine("3. 주소삭제");
                Console.WriteLine("4.주소 전체 출력");
                Console.WriteLine("5.프로그램 종료");
                Console.WriteLine("--------------------------");
            }
            static int GetSelMenu()
            {
                int sel = -1;
                Console.Write("메뉴 선택 :");
                sel = int.Parse(Console.ReadLine());
                return sel;
            }

            static void InputAddress()
            {
                ClearView();
               Adddress addr = new Adddress();
                Console.WriteLine("이름 입력:");
                addr.Name = Console.ReadLine();
                Console.WriteLine("전화 입력:");
                addr.phone = Console.ReadLine();
                Console.WriteLine("주소 입력:");
                addr.address = Console.ReadLine();

                listAddress.Add(addr);

            }

            static void SearchAddress()
            {
                ClearView();
                Console.WriteLine("이름 입력 :");
                string name = Console.ReadLine();
                for (int i = 0; i < listAddress.Count; i++)
                {
                    Adddress addr = listAddress[i];
                    Console.WriteLine("이름 :" + addr.Name);
                    Console.WriteLine("전화" + addr.phone);
                    Console.WriteLine("주소" + addr.address);
                    break;
                }
            }

            Console.ReadLine();
        }

        static void UpdateAddress()
        {
            Console.WriteLine("UpdateAddress");
            Console.ReadLine();
        }

        static void DeleteAddress()
        {
            Console.WriteLine("Delete Address");
            Console.ReadLine();
        }

        static void PrintAllAddress()
        {
            ClearView();
            for(int i=0; i<listAddress.Count; i++)
            {
                Adddress addr = listAddress[i];
                Console.WriteLine("----------------", i + 1);
                Console.WriteLine("이름 :" + addr.Name);
                Console.WriteLine("번호 :" + addr.phone);
                Console.WriteLine("주소" + addr.address);
              
            }
            Console.ReadLine();
        }

        static void ProgramExit()
        {
            Environment.Exit(0);
        }

        static void ClearView()
        {
            Console.Clear();
        }
    }

   

    

   

    
}

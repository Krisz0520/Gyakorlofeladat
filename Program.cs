namespace Gyakorlofeladat
{
    internal class Program
    {
        static string[] nevek = new string[10] { "", "", "", "", "", "", "", "", "", "", };
        static string[] Elehelyezo()
        {
            nevek[4] = "alma";
            nevek[8] = "kosz";
            nevek[10] = "por";

        }
        static int Vanehely()
        {
                int szabadertek = -1;
            for (int i = 0; i < nevek.Length; i++)
            {
                if(nevek[i] == "" && szabadertek == -1)
                {
                    szabadertek = i;
                }
            }
                return szabadertek;
        }
        static void Ételelhelyezés()
        {
            Console.WriteLine("Mit akarsz elhelyezni a hűtőben?");
            nevek[Vanehely()] = Console.ReadLine()!;
        }
        static void Takarit()
        {
            for (int i = 0; i < nevek.Length; i++)
            {
                if (nevek[i] !="" && i > 0)
                {
                    for (int j = 0; j < nevek.Length; j++)
                    {
                        if (i > j)
                        {
                            (nevek[i], nevek[j]) = (nevek[j], nevek[i]);
                        }
                    }
                }
            }
        }
        static void KeresEtel()
        {
            Console.Write("Melyik ételt keresi?");
            string keresendoEtel = Console.ReadLine()!;
            bool nincsMeg = true;
            Console.WriteLine();
            for (int i = 0; i < nevek.Length; i++)
            {
                if(keresendoEtel == nevek[i])
                {
                    Console.WriteLine($"Az étel a hűtben a {i+1}. helyen van");
                    nincsMeg = false;
                }
            }
            if(nincsMeg == true)
            {
                Console.WriteLine("0");
            }
        }
        static void MaganhangzoVanE()
        {
            string maganhangzo = "aáeéiíoóöőuúüű";
            foreach (var item in nevek)
            {
                if (item.Length > 0)
                {
                    if (maganhangzo.Contains(item[0]))
                    {
                        Console.WriteLine(item);
                    }
                }
            }
        }
        static void Main(string[] args)
        {

            int opcio;
            do
            {
                Elehelyezo();
                Console.WriteLine("\n-----------------------------------\n");
                Console.WriteLine("Mit akar csinálni? \n[1] Elhelezni valamit \n[2] Takarít \n[3] Keresés \n[4] Magánhangzós Kilistázás \n[5] Kilistázás \n[6] Kilépés");
                opcio = Convert.ToInt32(Console.ReadLine()!);
                Console.WriteLine("\n-----------------------------------\n");
                switch (opcio)
                {
                    case 1:
                        Ételelhelyezés();
                        break;
                    case 2:
                        Takarit();
                        break;
                    case 3:
                        KeresEtel();
                        break;
                    case 4:
                        MaganhangzoVanE();
                        break;

                    case 5:
                            foreach (var item in nevek)
                            {
                                Console.WriteLine(item);
                            }
                            break;

                        }
            } while (opcio != 6);


        }
    }
}

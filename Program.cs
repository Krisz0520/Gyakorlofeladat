namespace Gyakorlofeladat
{
    internal class Program
    {
        static string[] nevek = new string[10] { "", "", "", "", "", "", "", "kosz", "", "por", };
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



        static void Main(string[] args)
        {
            int opcio = 0;
            do
            {
                Console.WriteLine("Mit akar csinálni? \n[1] Elhelezni valamit \n[2] Takarít \n[3] Keresés \n[4] Kilistázás \n[5] Kilépés");
                opcio = Convert.ToInt32(Console.ReadLine()!);
                switch (opcio)
                {
                    case 1:
                        Ételelhelyezés();
                        break;
                    case 2:
                        Takarit();
                        break;

                    case 4:
                            foreach (var item in nevek)
                            {
                                Console.WriteLine(item);
                            }
                            break;

                        }
            } while (opcio != 5);


        }
    }
}

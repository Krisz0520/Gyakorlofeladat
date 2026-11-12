namespace Gyakorlofeladat
{
    internal class Program
    {
        static string[] nevek = new string[10] { "", "", "", "", "", "", "", "", "", "", };
        static int vanehely()
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

        static void Main(string[] args)
        {
            vanehely();
            Console.WriteLine("Mit akar csinálni? [1] Elhelezni valamit, [2] Takarít, [3] Keresés [4] kilistázás");
        }
    }
}

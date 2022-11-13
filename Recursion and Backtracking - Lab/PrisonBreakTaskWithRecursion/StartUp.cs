namespace PrisonTask
{
    internal class StartUp
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            char[,] prison = new char[n, m];

            int prisonerRow = 0;
            int prisonerCol = 0;


            for (int row = 0; row < prison.GetLength(0); row++)
            {
                char[] rowInput = Console.ReadLine().ToCharArray();

                for (int col = 0; col < rowInput.Length; col++)
                {
                    prison[row, col] = rowInput[col];
                    if (prison[row,col] == 'P')
                    {
                        prisonerRow = row;
                        prisonerCol = col;
                    }
                }
            }

            string path = "";

            List<string> possibleBreakOuts = new List<string>();

            bool[,] visited = new bool[prison.GetLength(0), prison.GetLength(1)];

            FindAllBreakOutPaths(prison, prisonerRow, prisonerCol, visited, path, possibleBreakOuts);

            if (possibleBreakOuts.Count == 0)
            {
                Console.WriteLine("impossible");
                return;
            }

            var shortestRoute = possibleBreakOuts.OrderBy(r => r.Length).First();

            Console.WriteLine($"Number of routes leading to the exit: {possibleBreakOuts.Count}");
            Console.WriteLine($"The shortest route leading to the exit: {shortestRoute}");
            

        }

        public static void FindAllBreakOutPaths(char[,] prison, int row,int col, bool[,] visited,string path, List<string> possibleBreakOuts)
        {
            

            if (prison[row,col] == 'E')
            {
                possibleBreakOuts.Add(path);
               return;
            }

            visited[row, col] = true;

            if (IsSafe(prison, row + 1, col,visited))
            {
                FindAllBreakOutPaths(prison, row + 1, col, visited, path + "D", possibleBreakOuts);
            }

            if (IsSafe(prison, row - 1, col, visited))
            {
                FindAllBreakOutPaths(prison, row - 1, col, visited, path + "U", possibleBreakOuts);
            }

            if (IsSafe(prison, row , col + 1, visited))
            {
                FindAllBreakOutPaths(prison, row , col + 1, visited, path + "R", possibleBreakOuts);
            }

            if (IsSafe(prison, row, col - 1, visited))
            {
                FindAllBreakOutPaths(prison, row, col - 1, visited, path + "L", possibleBreakOuts);
            }

        }

        private static bool IsSafe(char[,] prison,int row,int col, bool[,] visited)
        {
            if (row < 0 || col < 0 || row >= prison.GetLength(0) || col >= prison.GetLength(1))
            {
                return false;
            }

            if (prison[row,col] == '1' || visited[row,col])
            {
                return false;
            }


            return true;
        }       
    }
}
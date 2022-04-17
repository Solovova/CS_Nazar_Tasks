namespace Tasks;

public static class ExtFuncs{
    public static void ToConsole2DimArray(int[,] arr){
        for (var i = 0; i < arr.GetLength(0); i++){
            for (var j = 0; j < arr.GetLength(1); j++){
                Console.Write(arr[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
    
    public static void ToConsole1DimArray(int[] arr){
        foreach (var t in arr){
            Console.Write(t + " ");
        }
        Console.WriteLine();
    }
    
    public static void ToConsoleArrayOfArray(int[][] arr){
        foreach (var t in arr){
            foreach (var t1 in t){
                Console.Write(t1 + " ");
            }
            Console.WriteLine();
        }
    }
    
    public static int[] GetArrRandom(int len,int min, int max){
        var result = new int[len];
        Random rnd = new Random();
        for (int i = 0; i < result.Length; i++){
            result[i] = rnd.Next(min,max+1);
        }
        return result;
    }

    public static List<(int, int)> GetNeighborCells(int x,int y, int minX, int maxX, int minY, int maxY){
        var result = new List<(int, int)>();
        for (int tx = x-1; tx <= x+1; tx++){
            for (int ty = y-1; ty <= y+1; ty++){
                if ((tx == x && ty == y) || (tx < minX) || (tx > maxX) || (ty < minY) || (ty > maxY)){
                    continue;
                }
                result.Add((tx,ty));
            }    
        }

        return result;
    }
}
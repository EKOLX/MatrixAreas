Console.WriteLine($"{Environment.NewLine}------ Matrix Areas ------");

Console.Write($"{Environment.NewLine}Enter a matrix of values:  ");
var values = Console.ReadLine();
Console.WriteLine();

if(string.IsNullOrEmpty(values))
{
    Console.WriteLine($"No values!{Environment.NewLine}");
}
else
{
    var rows = values.Split(';');
    
    int[][] matrix = new int[rows.Length][];

    for(int rowIndex = 0; rowIndex < rows.Length; rowIndex++)
    {
        var columns = rows[rowIndex].Split(',');
        matrix[rowIndex] = columns.Select(int.Parse).ToArray();
    }
    
    int zoneOneCount = new MatrixAreas().FindZonesOne(matrix);

    Console.WriteLine($"{Environment.NewLine}Number of areas: {zoneOneCount}{Environment.NewLine}");
}

Console.WriteLine("------ Matrix Areas ------");

Console.Write($"{Environment.NewLine}Press any key to exit...");
Console.ReadKey(true);

class MatrixAreas
{
    public int FindZonesOne(int[][] matrix)
    {
        int zoneOneCount = 0;

        for(int rowIndex = 0; rowIndex < matrix.Length; rowIndex++)
        {
            for(int columnIndex = 0; columnIndex < matrix[rowIndex].Length; columnIndex++)
            {
                if(matrix[rowIndex][columnIndex] == 1)
                {
                    CheckArea(matrix, rowIndex, columnIndex);
                    zoneOneCount++;
                }
            }
        }

        return zoneOneCount;
    }

    private void CheckArea(int[][] matrix, int rowIndex, int columnIndex)
    {
        // Check the boundaries and whether cell is 1
        if(rowIndex < 0 || rowIndex >= matrix.Length
           || columnIndex < 0 || columnIndex >= matrix[rowIndex].Length
           || matrix[rowIndex][columnIndex] != 1)
           return;

        // Mark current cell as visited by value 2
        matrix[rowIndex][columnIndex] = 2;

        // Check all 4 directions
        CheckArea(matrix, rowIndex, columnIndex - 1); // LEFT
        CheckArea(matrix, rowIndex, columnIndex + 1); // RIGHT
        CheckArea(matrix, rowIndex - 1, columnIndex); // UP
        CheckArea(matrix, rowIndex + 1, columnIndex); // DOWN
    }
}
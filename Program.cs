Console.WriteLine($"{Environment.NewLine}------ Matrix Areas ------");

Console.Write($"{Environment.NewLine}Enter a matrix of values:  ");
var values = Console.ReadLine();

if(string.IsNullOrEmpty(values))
{
    Console.WriteLine($"{Environment.NewLine}No values!");
}
else
{
    int zoneCount = 0;
    var rows = values.Split(';');
    Console.WriteLine();

    for(int rowIndex = 0; rowIndex < rows.Length; rowIndex++)
    {
        var columns = rows[rowIndex].Split(',');
        Console.WriteLine(rows[rowIndex]);
        
        for(int columnIndex = 0; columnIndex < columns.Length; columnIndex++)
        {
            var currentValue = int.Parse(columns[columnIndex]);
            // if value of cell is 0 then move on
            if(currentValue == 0) continue;
            // if value of cell is 1 then check its all 4 sides
            else
            {
                // CHECK LEFT SIDE
                if(columnIndex == 0)
                {
                    // we good, there is no left side
                }
                if(columnIndex > 0)
                {
                    var leftValue = int.Parse(columns[columnIndex - 1]);
                    if(leftValue == 0)
                    {
                        // we good, left value is 0
                    }
                    if(leftValue == 1)
                    {
                        continue;
                    }
                }

                // CHECK RIGHT SIDE
                if(columnIndex + 1 == columns.Length)
                {
                    // we good, there is no right side
                }
                if(columnIndex + 1 < columns.Length)
                {
                    var rightValue = int.Parse(columns[columnIndex + 1]);
                    if(rightValue == 0)
                    {
                        // we good, right value is 0
                    }
                    if(rightValue == 1)
                    {
                        continue;
                    }
                }

                //  CHECK TOP SIDE
                if(rowIndex == 0)
                {
                    // we good, there is no top value
                }
                if(rowIndex > 0)
                {
                    var topValue = int.Parse(rows[rowIndex - 1].Split(',')[columnIndex]);
                    if(topValue == 0)
                    {
                        // we good, top value is 0
                    }
                    if(topValue == 1)
                    {
                        continue;
                    }
                }

                // CHECK BOTTOM SIDE
                if(rowIndex + 1 == rows.Length)
                {
                    // we good, there is no bottom side
                }
                if(rowIndex + 1 < rows.Length)
                {
                    var bottomValue = int.Parse(rows[rowIndex + 1].Split(',')[columnIndex]);
                    if(bottomValue == 0)
                    {
                        // we good, bottom value is 0
                    }
                    if(bottomValue == 1)
                    {
                        continue;
                    }
                }

                zoneCount++;
            } 
        }
    }

    Console.WriteLine($"{Environment.NewLine}Number of areas: {zoneCount}{Environment.NewLine}");
}

Console.WriteLine("------ Matrix Areas ------");

Console.Write($"{Environment.NewLine}Press any key to exit...");
Console.ReadKey(true);
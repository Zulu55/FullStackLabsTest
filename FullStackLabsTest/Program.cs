int n = 6;
int[][] matrix = new int[n][];
for (int i = 0;i < n; i++)
{
    matrix[i] = new int[n];
}
FillMatrix(matrix);
ShowMatrix(matrix);
Console.WriteLine(Evaluate(3, matrix));

int Evaluate(int r, int[][] matrix)
{
    return 0;
}

void ShowMatrix(int[][] matrix)
{
    int n = matrix[0].Length;
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write($"{matrix[i][j]}\t");
        }
        Console.WriteLine();
    }
}

void FillMatrix(int[][] matrix)
{
    int n = matrix[0].Length;
    var random= new Random();
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i][j] = random.Next(1, 10);    
        }
    }
}
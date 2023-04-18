int n = 6;
int[][] matrix = new int[n][];
for (int i = 0; i < n; i++)
{
    matrix[i] = new int[n];
}
FillMatrix(matrix);
ShowMatrix(matrix);
Console.WriteLine(Evaluate(3, matrix));

int Evaluate(int r, int[][] matrix)
{
    int n = matrix[0].Length;
    int w = r * 2 - 1;
    int t = n - w + 1;
    int max = 0;
    for (int a = 0; a < t; a++)
    {
        for (int b = 0; b < t; b++)
        {
            int[,] sub = new int[w, w];
            for (int i = 0; i < w; i++)
            {
                for (int j = 0; j < w; j++)
                {
                    sub[i, j] = matrix[i + a][j + b];
                }
            }
            int sum = Sum(sub, w);
            if (sum > max)
            {
                max = sum;
            }
        }
    }
    return max;
}

int Sum(int[,] sub, int w)
{
    int sum = 0;
    int k = w / 2;
    for (int i = 0; i < w; i++)
    {
        int b = 1;
        for (int j = 0; j < b; j++)
        {
            sum  += sub[i, k - i + j];
        }
        if (b < w)
        {
            b += 2;
        }
        else
        {
            b -= 2;
        }

    }
    return sum; 
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
    var random = new Random();
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i][j] = random.Next(1, 10);
        }
    }
}
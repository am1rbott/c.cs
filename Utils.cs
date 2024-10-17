namespace ControlWork;

public static class Utils
{
    public static double RandArray(long x0, int n)
    {
        if (n < 1 || n > 200 || x0 <= 0)
        {
            return null;
        }
        
        double[] result = new double[n];
        long m = 4294967296;
        long a = 1103515245;
        long c = 12345;
        long d = c % m;

        long x = x0;
        
        for (int i = 0; i < n; i++)
        {
            x = (d * x * x + a * x + c) % m;
            result[i] = (double)x / m;
        }
        
        return result;

    }
    
    public static string ArrayToStr(double[] r, int precise)
    {
        // Проверка на корректность параметров
        if (r == null || precise < 0 || precise > 4)
            return "";

        string format = "F" + precise; // Форматирование с нужной точностью
        string[] strArray = new string[r.Length];

        for (int i = 0; i < r.Length; i++)
        {
            strArray[i] = r[i].ToString(format);
        }

        return string.Join(" ", strArray); // Объединение строк с пробелами
    }
    
    
    static void Main()
    {
        // Пример тестирования методов
        double[] r = Utils.RandArray(long.MaxValue, 150);
        if (r != null)
        {
            Console.WriteLine(Utils.ArrayToStr(r, 3));
        }
    }
}
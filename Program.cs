string x;
string y;
string V;
string a;
double xt;
double yt;
const double g = 9.81;
double t = 0.00;

Console.WriteLine("Введите через Enter начальные координаты х0 и у0, начальную скорость снаряда V0 и угол выстрела а в градусах. Учтите, что нельзя ввести координату у меньше 0 (вы не можете запустить снаряд из ямы).");
x = Console.ReadLine();
y = Console.ReadLine();
V = Console.ReadLine();
a = Console.ReadLine();

if (x == "" || y == "" || V == "" || a == ""){
    Console.WriteLine("Пустые строки не принимаем.");
}
else{
    if (double.TryParse(x, out double x0) == false || double.TryParse(y, out double y0) == false || double.TryParse(V, out double V0) == false || double.TryParse(a, out double aint) == false || V0 < 0 || y0 < 0 || (y0 == 0 && (aint < 0 || aint > 180)))
    {
        Console.WriteLine("При вводе данных вы совершили ошибку. Пожалуйста, повторите ввод.");
    }
    else
    {
        double Vx = V0 * Math.Cos(aint * Math.PI / 180);
        double Vy = V0 * Math.Sin(aint * Math.PI / 180);

        do
        {
            xt = x0 + Vx * t;
            yt = y0 + Vy * t - (g * Math.Pow(t, 2)) / 2;

            if (yt >= 0)
            {
                Console.WriteLine($"Х — {Math.Round(xt, 2)}; Y — {Math.Round(yt, 2)}");
            }
            t += 0.1;
        }
        while (yt >= 0.00);
    }
}

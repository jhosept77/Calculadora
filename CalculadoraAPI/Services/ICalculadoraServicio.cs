namespace CalculadoraAPI.Services
{
    public interface ICalculadoraServicio
    {
        double Sumar(double a, double b);
        double Restar(double a, double b);
        double Multiplicar(double a, double b);
        double Dividir(double a, double b);
    }
}
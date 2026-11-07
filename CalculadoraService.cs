// Implementamos la interfaz ICalculadoraSoap cumpliendo con el contrato.
using CoreWCF;

public class CalculadoraService: ICalculadoraService
{
    //suma
    public double Sumar(double primerNumero, double segundoNumero)
    {
        return primerNumero + segundoNumero;
    }

    //resta
    public double Restar(double primerNumero, double segundoNumero)
    {
        return primerNumero - segundoNumero;
    }

    //multiplicacion
    public double Multiplicar(double primerNumero, double segundoNumero)
    {
        return primerNumero * segundoNumero;
    }

    //division
    public double Dividir(double primerNumero, double segundoNumero)
    {
        if(segundoNumero == 0)
        {
            throw new FaultException("No se puede dividir entre cero. Intenta otro numero");
        }
        return primerNumero / segundoNumero;
    }
}
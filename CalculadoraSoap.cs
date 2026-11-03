// Implementamos la interfaz ICalculadoraSoap cumpliendo con el contrato.
public class CalculadoraSoap: ICalculadoraSoap
{
    public double Sumar(double primerNumero, double segundoNumero)
    {
        return primerNumero + segundoNumero;
    }
}
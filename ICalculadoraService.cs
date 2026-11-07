using CoreWCF;

[ServiceContract]
public interface ICalculadoraService
{
    [OperationContract]
    double Sumar(double primerNumero, double segundoNumero);

    [OperationContract]
    double Restar(double primerNumero, double segundoNumero);

    [OperationContract]
    double Multiplicar(double primerNumero, double segundoNumero);

    [OperationContract]
    double Dividir(double primerNumero, double segundoNumero);
}
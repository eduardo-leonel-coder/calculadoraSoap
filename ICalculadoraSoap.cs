using CoreWCF;

[ServiceContract]
public interface ICalculadoraSoap
{
    [OperationContract]
    double Sumar(double primerNumero, double segundoNumero);
}
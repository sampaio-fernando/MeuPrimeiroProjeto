using System.Linq.Expressions;

public class Conta
{
    private double saldo;

    public void SetSaldo(double s)
    {
        try {
            if (s >= 0)
            {
                saldo = s;
            }
            else
            {
                //lança uma exceção
                throw new Exception("O saldo não pode ser negativo!");
            }
        }catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
}
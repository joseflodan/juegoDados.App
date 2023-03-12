namespace juegoDados;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

    private void botonGirarDado(object sender, EventArgs e)
    {
        Random dado = new Random();

        int numeroDe1 = 0;
        int numeroDe2 = 0;
        int numeroDe3 = 0;
        int numeroDe4 = 0;
        int numeroDe5 = 0;
        int numeroDe6 = 0;

        for (int contador = 0; contador < 999999; contador++)
        {
            int resultado = dado.Next(1, 7);
            if(resultado == 1)
            {
                numeroDe1++;
            }
            if(resultado == 2)
            {
                numeroDe2++;
            }
            if (resultado == 3)
            {
                numeroDe3++;
            }
            if (resultado == 4)
            {
                numeroDe4++;
            }
            if (resultado == 5)
            {
                numeroDe5++;
            }
            if (resultado == 6)
            {
                numeroDe6++;
            }
        }

        valorDado.Text = $"Numero de uno: {numeroDe1}\n" +
            $"Numero de dos: {numeroDe2}\n" +
            $"Numero de tres: {numeroDe3}\n" +
            $"Numero de cuatro: {numeroDe4}\n" +
            $"Numero de cinco: {numeroDe5}\n" +
            $"Numero de seis: {numeroDe6}\n"; ;
    }
}


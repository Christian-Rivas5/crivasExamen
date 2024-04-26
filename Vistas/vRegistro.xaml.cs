using System.Collections.Specialized;
using System.Globalization;

namespace crivasExamen.Vistas;

public partial class vRegistro : ContentPage
{
	
	public vRegistro(string usuario)
	{
		InitializeComponent();
        DisplayAlert("Alerta", "bienvenido" + usuario, "Cerrar");
        lblUsuario.Text= "usuario conectado: " + usuario;
	}

    private void btnIniciar_Clicked(object sender, EventArgs e)
    {

    }

    private void btnAcerca_Clicked(object sender, EventArgs e)
    {

    }

    private void pkPaises_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void pkCidaddes_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void btnPicker_Clicked(object sender, EventArgs e)
    {
        string fecha=dpFecha.Date.ToString();
        lblFecha.Text= "Fecha" + fecha;

        if(pkCidaddes.SelectedIndex== -1)
        {
            DisplayAlert("alerta", "no esxite dato", "Cerarr");
        }
        else
        {
            string dato= pkCidaddes.Items[pkCidaddes.SelectedIndex].ToString();
            string pais = pkPaises.Items[pkPaises.SelectedIndex].ToString();

            Navigation.PushAsync(new vResumen());
        }
    }

    private void btnCalcular_Clicked(object sender, EventArgs e)
    {
       
        double montoinicial = Convert.ToDouble(txtMinicial.Text);

        double costo = 1500;
        double porcentaje= 4.0;
        double cuota = (costo - montoinicial) / 4;

        DisplayAlert("Alerta", "EL pago mensual es: "+ cuota,"Cerrar");

    }
}
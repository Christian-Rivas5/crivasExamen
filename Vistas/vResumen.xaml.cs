namespace crivasExamen.Vistas;

public partial class vResumen : ContentPage
{
	public vResumen()
	{
		InitializeComponent();
        
    }

    private void btnCalcular_Clicked(object sender, EventArgs e)
    {

    }

    private void btnCerrar_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new vLoguin());
    }
}
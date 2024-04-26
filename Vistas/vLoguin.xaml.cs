

namespace crivasExamen.Vistas;

public partial class vLoguin : ContentPage
{
	string usuario1;
	string contrasena1;
	public vLoguin()
	{
		InitializeComponent();
        //usuario1 = usuario;
        //contrasena1 = contrasena;
    }

	private void btnInicair_Clicked(object sender, EventArgs e)
	{
		string[] usuarios;
		string[] contrasenas;

		Boolean logueado;
		string usuario_logueado;

		usuarios = new string[3];
		contrasenas = new string[3];

		logueado=false;
		usuario_logueado = "";

		usuarios[0] = "estudiante2024";
		usuarios[1]= "examen1";
		usuarios[2] = "Christian";

		contrasenas[0] = "uisrael.2024";
		contrasenas[1] = "parcial1";
		contrasenas[2] = "2024";

		for (int i = 0; i < usuarios.Length; i++) 
		{
			if ((txtUsuario.Text == usuarios[i] && txtContrasena.Text== contrasenas[i])) 
			{
				logueado = true;
				usuario_logueado = usuarios[i];
				break;
			}
			else if ((txtUsuario.Text == usuario1 && txtContrasena.Text == contrasena1))
			{
				logueado = true;
				usuario_logueado= usuario1;
				break;
			}
		}
		if (logueado)
		{
			Navigation.PushAsync(new vRegistro(usuario_logueado));
		}
		else 
		{
			DisplayAlert("Alerta", "Usuario/contrasena incorresctos", "Cerrar");
		}
    }

    private void btnAcerca_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new vAcercade());
	}
}
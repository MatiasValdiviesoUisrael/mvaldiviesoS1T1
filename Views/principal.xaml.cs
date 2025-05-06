namespace mvaldiviesoS1T1.Views;

public partial class principal : ContentPage
{
	public principal()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		if(txtCorreo.Text != txtConfirmarCorreo.Text)
		{
			DisplayAlert("Error", "Los correos no coinciden", "OK");
        }

        string contenido = $"Identificaci�n: {txtIdentificacion.Text}\n" +
                           $"Apellidos: {txtApellidoPaterno.Text} {txtApellidoMaterno.Text}\n" +
                           $"Nombres: {txtNombres.Text}\n" +
                           $"Tel�fono: {txtTelefono.Text}\n" +
                           $"Correo: {txtCorreo.Text}\n" +
                           $"Carrera: {txtCampus.Text}\n" +
                           $"Modalidad: {txtModalidad.Text}\n" +
                           $"Campus: {txtCampus.Text}";

        string filePath = Path.Combine(FileSystem.AppDataDirectory, "registro.txt");
        File.WriteAllText(filePath, contenido);

        DisplayAlert("Registro", "Registro guardado correctamente", "OK");
    }
}
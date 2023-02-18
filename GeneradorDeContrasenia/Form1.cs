namespace GeneradorDeContrasenia
{

    public partial class Form1 : Form
    {
        Random _ramdom = new Random();
        static string mayusculaLista = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        static string minusculasLista = "abcdefghijklmnopqrstuvwxyz";
        static string numeroLista = "0123456789";
        static string simbolosLista = "!@#$%^&*()[]{}=<>/,.";

        string todosLosCaracteres = string.Empty;


        public Form1()
        {
            InitializeComponent();
            txtLongitudContrasenia.Text = "20";
        }


        private void ConstuirListaCaracteres()

        {
            todosLosCaracteres = string.Empty;
            if (chkIncluMayusculas.Checked)
                todosLosCaracteres += mayusculaLista;
            if (chkIncluMinusculas.Checked)
                todosLosCaracteres += minusculasLista;
            if (chkIncluNumeros.Checked)
                todosLosCaracteres += numeroLista;
            if (chkIncluSimbolos.Checked)
                todosLosCaracteres += simbolosLista;

            if (string.IsNullOrEmpty(todosLosCaracteres))
                todosLosCaracteres = mayusculaLista + mayusculaLista + numeroLista + simbolosLista;
        }


        private string GenerarContrasenia(int longitud)
        {
            string nuevaContrasenia = string.Empty;

            if (longitud < 6)
                throw new Exception("Una contraseña fuerte necesita tener más de 6 caracteres");

            for(int i = 0; i < longitud; i++)
            {
                nuevaContrasenia += ObtenerRandomChar();
            }

            return nuevaContrasenia;
        }

        private string ObtenerRandomChar()
        {
            return todosLosCaracteres.ToCharArray()[(int)Math.Floor(_ramdom.NextDouble() * todosLosCaracteres.Length)].ToString();
        }

        private void btnGenerarContrasenia_Click(object sender, EventArgs e)
        {

            
            ConstuirListaCaracteres();
            txtContraseniaGenerada.Text = GenerarContrasenia(int.Parse(txtLongitudContrasenia.Text));

        }

        private void txtLongitudContrasenia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                e.Handled = true;
        }
    }
}
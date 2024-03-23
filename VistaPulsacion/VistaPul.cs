using Entity;
using System;
using System.Windows.Forms;

namespace VistaPulsacion
{
    public partial class VistaPul : Form
    {
        private readonly Persona Personaservice;
       

        public VistaPul()
        {
            InitializeComponent();
            Personaservice = new Persona();
        }

        private void ButtonCalcular_Click(object sender, EventArgs e)
        {
            string mensaje = Calcular();
            MessageBox.Show(mensaje, "Información al Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private string Calcular() 
        {
            if (ValidarTextosVacios()) 
            {
                Persona persona = MapearTextoAPersona();
                decimal resultado = Personaservice.CalcularPulsacion(persona);
                TextBoxPulsaciones.Text = resultado.ToString();
                return "Pulsaciones calculadas correctamente.";
            }
            else
            {
                MessageBox.Show("Los datos suministrados están incompletos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "Los datos suministrados están incompletos";
            }
        
        }
        private Persona MapearTextoAPersona()
        {
            var persona = new Persona();
            persona.Edad = int.Parse(TextBoxEdad.Text);
            persona.Sexo = MapearComboASexo(ComboBoxSexo.Text);
            persona.CalcularPulsacion(persona); 
            TextBoxPulsaciones.Text = persona.Pulsacion.ToString();
            return persona;
        }

        private string MapearComboASexo(string sexo)
        {
            return sexo.Equals("Femenino") ? "F" : "M";
        }
        private bool ValidarTextosVacios()
        {
            return !string.IsNullOrEmpty(TextBoxEdad.Text) && !string.IsNullOrEmpty(ComboBoxSexo.Text);
        }
    }
}

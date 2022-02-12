using Newtonsoft.Json;

namespace ProyectoN1
{
    public partial class Form1 : Form
    {
        //Variable Global
        String[,] equipos;



        public Form1()
        {
            //Lineas De Codigo Encargadas de Subir la Info
            String path = "C:\\Tareas\\ProyectoN1\\Resultados.json";
            String descarga = File.ReadAllText(path);
            equipos = JsonConvert.DeserializeObject<String[,]>(descarga);
            InitializeComponent();

        }
       
    }
}
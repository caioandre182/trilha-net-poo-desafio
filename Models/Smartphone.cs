namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        private string modelo;
        private string IMEI;
        private int memoria;


        public Smartphone(string numero, string modeloCelular, string imei, int memoriaCelular)
        {
            Numero = numero;
            modelo = modeloCelular;
            IMEI = imei;
            memoria = memoriaCelular;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}
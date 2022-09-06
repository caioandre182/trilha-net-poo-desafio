namespace DesafioPOO.Models
{

    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modeloCelular,
                    string imei, int memoriaCelular) : base(numero, modeloCelular, imei, memoriaCelular)
                {

                }
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"O aplicativo: {nomeApp} foi instalado com sucesso no Nokia");
        }
    }
}
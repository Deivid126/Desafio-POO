namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }
        
         public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Intalando o aplicativo {nomeApp} no Iphone");
        }
        
    }
     
}
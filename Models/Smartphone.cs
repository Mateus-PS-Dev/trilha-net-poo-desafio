namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            // Implementado!!!
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;

        }

        public string Numero { get; set; }
        // Implementado!!!
        private string Modelo { get; set; }
        private string IMEI { get; set; }
        private int Memoria { get; set; }

        public void Ligar(string numero)
        {
            Console.WriteLine($"Ligando para {numero}...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação de \"numero desconhecido\"...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}
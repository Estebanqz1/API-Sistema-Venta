namespace SistemaVenta.API.Utilidad
{
    public class Response <T>
    {
        public bool status { get; set; }
        public T values { get; set; }
        public string msg { get; set; }
    }
}

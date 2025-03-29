namespace ExcepcionesPropias
{
    public class DatosInvalidosException : Exception
    {
        public DatosInvalidosException() { }

        public DatosInvalidosException(string mensaje) : base(mensaje) { }

        public DatosInvalidosException(string mensaje, Exception interna) : base(mensaje, interna) { }
        
    }
}

namespace Infotrack.Base.Datos
{
    public partial class DatosContexto
    {
        public DatosContexto()
            : base("name=ContextoBase")
        {
            this.Configuration.ProxyCreationEnabled = false;
        }
    }
}
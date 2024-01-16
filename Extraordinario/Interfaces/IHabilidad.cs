namespace Extraordinario.Interfaces
{
    internal interface IHabilidad
    {
        int id { get; set; }
        string Nombre { get; set; }
        string clase { get; set; }
        float nivel_requerido { get; set; }

        bool pasivo { get; set; }
    }
}

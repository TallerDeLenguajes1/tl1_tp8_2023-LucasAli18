namespace Tareas
{
    public class Tarea
    {
        private int id;
        private string? descripcion;
        private int duracion;

        public int Id { get => id; set => id = value; }
        public string? Descripcion { get => descripcion; set => descripcion = value; }
        public int Duracion { get => duracion; set => duracion = value; }

        //Nueva tarea
        public Tarea CrearTarea(int id)
        {
            string[] tareasNuevas ={"lavar","comer","correr","cantar","jugar","nadar","caminar"};
            int tarea;
            Random aleatorio = new Random();
            Tarea nueva = new Tarea();
            nueva.id = id;
            nueva.descripcion=tareasNuevas[aleatorio.Next(0,tareasNuevas.Length)];
            nueva.duracion=aleatorio.Next(10,101);
            return nueva;
        }
        
    }
}
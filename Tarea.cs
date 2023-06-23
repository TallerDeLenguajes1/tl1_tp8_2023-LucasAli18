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
            Random aleatorio = new Random();
            Tarea nueva = new Tarea();
            nueva.id = id;
            Console.WriteLine("Descripcion de la tarea:");
            nueva.descripcion=Console.ReadLine();
            nueva.duracion=aleatorio.Next(10,101);
            /* Console.WriteLine("ID: "+nueva.id);
            Console.WriteLine("Descripcion: "+nueva.descripcion);
            Console.WriteLine("Duracion: "+nueva.duracion);
            Console.WriteLine(); */
            return nueva;
        }
        public void BuscarTarea(List<Tarea> TP,string descripcion)
        {
            /* Tarea igual = new Tarea();
            int resultado;
            resultado=0;
            foreach (var tar in TP)
            {
                if (tar.descripcion==descripcion)
                {
                    Console.WriteLine("=======================================");
                    Console.WriteLine("El id de la tarea es: "+tar.id);
                    Console.WriteLine("La tarea es: "+tar.descripcion);
                    Console.WriteLine("La duracion de la tarea es: "+tar.duracion);
                    Console.WriteLine("=======================================");
                }
            } */
        }
        
    }
}
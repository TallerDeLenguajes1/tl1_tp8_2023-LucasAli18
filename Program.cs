using Tareas;
using Empleados;


        Random aleatorio = new Random();
        int canEmpleados = aleatorio.Next(1, 4);
        List<Tarea> TareasPendientes = new List<Tarea>();
        List<Tarea> TareasRealizadas = new List<Tarea>();
        List<Empleado> Empleadores = new List<Empleado>();
        int opcion;
        string? buscador;
        int canTareas = aleatorio.Next(1, 4);
        for (int i = 0; i < 3; i++)
        {
            Tarea nueva = new Tarea();
            TareasPendientes.Add(nueva.CrearTarea(i+1));
        }
        Console.WriteLine("==================MENU========================");
        Console.WriteLine("1.Ver Tareas Pendientes");
        Console.WriteLine("2.Ver Tareas Realizadas");
        Console.WriteLine("3.Mover TP a TR");
        Console.WriteLine("4.Buscar por descripcion en TP y TR");
        Console.WriteLine("==============================================");
        int.TryParse(Console.ReadLine(),out opcion);
        Tarea? tareaEncontrada = new Tarea();
        while (opcion!=0)
        {
            switch (opcion)
            {
                case 1:
                        if (TareasPendientes.Count!=0)
                        {
                         foreach (var tarea in TareasPendientes)
                            {
                                Console.WriteLine("El id de la tarea es: "+tarea.Id);
                                Console.WriteLine("La tarea es: "+tarea.Descripcion);
                                Console.WriteLine("La duracion de la tarea es: "+tarea.Duracion);
                            }        
                        }else{
                            Console.WriteLine("No hay Tareas Pendientes");
                        }
                break;
                case 2: if (TareasRealizadas!=null)
                        {
                         foreach (var tarea in TareasRealizadas)
                            {
                                Console.WriteLine("El id de la tarea es: "+tarea.Id);
                                Console.WriteLine("La tarea es: "+tarea.Descripcion);
                                Console.WriteLine("La duracion de la tarea es: "+tarea.Duracion);
                            }        
                        }else{
                            Console.WriteLine("No hay Tareas Realizadas");
                        }
                break;
                case 3:
                        Console.WriteLine("Elija la tarea que desea mover");
                        buscador = Console.ReadLine();
                        if (TareasPendientes!=null)
                        {
                        tareaEncontrada = TareasPendientes.Find(t => t.Descripcion == buscador);
                        if (tareaEncontrada!=null && TareasRealizadas!=null)
                        {
                        TareasRealizadas.Add(tareaEncontrada);
                        TareasPendientes.Remove(tareaEncontrada);
                        }
                        }else
                        {
                            Console.WriteLine("No hay tareas pendientes para mover");
                        }

                break;
                case 4:
                        Console.WriteLine("Escribir la tarea que desea buscar: ");
                        buscador = Console.ReadLine();
                        /* if (TareasPendientes!=null)
                        {
                        tareaEncontrada = TareasPendientes.Find(t => t.Descripcion == buscador);
                        }

                        if (tareaEncontrada!=null)
                        {
                        Console.WriteLine("Tarea encontrada ID: "+tareaEncontrada.Id);                          
                        Console.WriteLine("Tarea encontrada Descripcion: "+tareaEncontrada.Descripcion);                          
                        Console.WriteLine("Tarea encontrada Duracion: "+tareaEncontrada.Duracion);                          
                        }else
                        {
                        Console.WriteLine("No se encontro nada");
                        } */
                            if (TareasPendientes!=null && buscador!=null)
                            {
                                List<Tarea> tareasEncontradas = TareasPendientes.FindAll(t => t.Descripcion.Contains(buscador));                              
                                tareasEncontradas.AddRange(TareasRealizadas.FindAll(t => t.Descripcion.Contains(buscador)));
                                if (tareasEncontradas.Count!=0)
                                {
                                    foreach (var tareas in tareasEncontradas)
                                    {
                                        Console.WriteLine("La tarea encontrada es: "+tareas.Descripcion);
                                    }
                                }else{
                                    Console.WriteLine("No se encontro nada");
                                }
                                
                                
                            }

                break;
                default: Console.WriteLine("La opcion ingresada no es correcta");
                break;
            } 
            Console.WriteLine("==================MENU========================");
            Console.WriteLine("1.Ver Tareas Pendientes");
            Console.WriteLine("2.Ver Tareas Realizadas");
            Console.WriteLine("3.Mover TP a TR");
            Console.WriteLine("4.Buscar por descripcion en TP y TR");
            Console.WriteLine("==============================================");
            int.TryParse(Console.ReadLine(),out opcion);
        }
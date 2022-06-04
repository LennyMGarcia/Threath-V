using System;
using System.Threading;
using System.Threading.Tasks;

namespace Threath_V
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Threath y task");

            // Task tarea = new Task(EjecutarTarea);

            //  tarea.Start();
            //con Run. es como si se declarara y se iniciara al mismo tiempo
            Task tarea = Task.Run(()=>EjecutarTarea());
            //se ejecuta despues de la primera usando un mensaje que viene de un objeto de tipo task
            Task tarea2 = tarea.ContinueWith(EjecutarOtraTarea);

            /* Task tarea2 = new Task(() =>
             {
                 for (int i = 0; i < 100; i++)
                 {
                     var Mithreath = Thread.CurrentThread.ManagedThreadId;

                     Thread.Sleep(1000);

                     Console.WriteLine("Tarea correspondiente al hilo:  " + Mithreath + " Ejecutandose desde el main");
                 }


             });

             tarea2.Start();*/
            /*for (int i = 0; i < 100; i++)
            {
                /*Thread t = new Thread(EjecutarTarea);

                t.Start();
                //Esto hace que un numero determinado de hilos maneje un determinado numero de tareas siempre que una termine primero su tarea, en este caso aparecen alredor de 20
                //esto ayuda a optimizar los recursos y no ejeuctar 500 hilos para  500 tareas al mismo tiempo, sino un n numeros de hilos para 500 tareas
                ThreadPool.QueueUserWorkItem(EjecutarTarea, i);

            }*/
            Console.ReadLine();
        }


        static void EjecutarTarea(/*object obj*/)
        {


            for (int i = 0; i < 3; i++)
            {
                var Mithreath = Thread.CurrentThread.ManagedThreadId;

                Thread.Sleep(1000);

                Console.WriteLine("Esta vuelta del bucle corresponde al THreath: " + Mithreath + "...");
            }
        }
        //para poder iniciar otra tarea a partr de la anterior se necesita un objeto de tipo task que funcione como mensaje
            static void EjecutarOtraTarea(Task obj)
            {


                for (int i = 0; i < 10; i++)
                {
                    var Mithreath = Thread.CurrentThread.ManagedThreadId;

                    Thread.Sleep(1000);

                    Console.WriteLine("Esta es otraaaaaa tarea para la vuelta del bucle corresponde al THreath: " + Mithreath + "...");
                }

            }
                /* //se usa el mismo parametro de object como entero pero con otro valor en la variable por eso se puede utilizar como i
                 int nTarea = (int)obj;


                 //especifica el numero de id del treath
                 Console.WriteLine($"Threath No.:{Thread.CurrentThread.ManagedThreadId} ha comenzado la tarea numero {nTarea}");
                 Thread.Sleep(1000);

                 Console.WriteLine($"Threath No.:{Thread.CurrentThread.ManagedThreadId} ha terminado su tarea{nTarea}");*/
            }
    }


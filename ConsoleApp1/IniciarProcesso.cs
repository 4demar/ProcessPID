using System;
using System.Diagnostics;

namespace ConsoleApp1
{
    public class IniciarProcesso
    {
        //public void IniciarApp()
        //{
        //    var subject = new Subject();

        //    for (int i = 0; i < 3; i++)
        //    {
        //        IniciarProcessoWorker();
        //        var WorkerObserver = new ConcreteObserver();
        //        WorkerObserver.Update()

        //        subject.Adicionar(observerA);
        //    }
        //}
        public void IniciarPaint(int numero)
        {
            var singleton = Singleton.ClassSingleton.GetInstancia;
            Process inicioWorker = new Process();

            inicioWorker.StartInfo.CreateNoWindow = false;
            inicioWorker.StartInfo.UseShellExecute = true;
            inicioWorker.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
            inicioWorker.StartInfo.WorkingDirectory = "%windir%\\system32";
            inicioWorker.StartInfo.FileName = "mspaint.exe";

            //inicioWorker.StartInfo.Arguments = numeroworker.ToString();
             

            try
            {
                inicioWorker.Start();
                singleton.numeroProcess.Add(inicioWorker.Id);
                singleton.worker.Add(new INomeWorker() {numeroPID = inicioWorker.Id, numeroWorker = numero });
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
                
            
        }
    }
}
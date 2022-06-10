using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main()
        {
            var singleton = Singleton.ClassSingleton.GetInstancia;
            IniciarProcesso iniciar = new IniciarProcesso();
            for (int i = 0; i <= 2; i++)
            {
                iniciar.IniciarPaint(i);
            }

            Thread.Sleep(TimeSpan.FromSeconds(20)); // 30 Segundos

            Process[] processAberto = Process.GetProcessesByName("mspaint");
            List<int> processoAtual = new List<int>();
            for (int i = 0; i < processAberto.Length; i++)
            {
                processoAtual.Add(processAberto[i].Id);
            }

            //// Compara e mostra na tela...
            var listaCaiu = singleton.numeroProcess.Except(processoAtual).ToList();

            for (int i = 0; i < listaCaiu.Count; i++)
            {
                Console.WriteLine("Paint de PID: " + listaCaiu[i] + " fechou...");
                foreach(INomeWorker dados in singleton.worker)
                {
                    if (dados.numeroPID == listaCaiu[i])
                    {
                        Console.WriteLine("Paint: " + dados.numeroWorker + " fechou...");
                        break;
                    }
                }
            }
        }
    }
}

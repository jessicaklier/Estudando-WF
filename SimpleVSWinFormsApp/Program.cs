using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleVSWinFormsApp
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.                                                                                                                                                                                                                                                                                                                                                                                        
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();// Habilitar estilos visuais.
            Application.SetCompatibleTextRenderingDefault(false); // Conjunto de aplicativos compativeis com renderização de textos padrões
            Application.Run(new MainWindow());// execução do aplicativo nova janela principal.
        }
    }
}

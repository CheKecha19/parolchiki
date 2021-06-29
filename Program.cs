using parolchiki.forms;
using System;
using System.Windows.Forms;

namespace parolchiki
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());



            /*
            //код для закрытия БД при закрытии программы
            {
                // если подключение открыто
                if (connection.State == ConnectionState.Open)
                {
                    // закрываем подключение
                    await connection.CloseAsync();
                    Console.WriteLine("Подключение закрыто...");
                }
                Console.WriteLine("Программа завершила работу.");
                Console.Read();
            }
            */
        }
    }
}

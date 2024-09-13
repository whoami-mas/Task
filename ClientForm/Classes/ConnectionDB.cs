using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using FirebirdSql.Data.FirebirdClient;

namespace ClientForm.Classes
{
    /// <summary>
    /// Подключение к БД
    /// </summary>
    public class ConnectionDB
    {
        
        public FbConnection? fbconnection { get; set; }
        private bool status { get; set; }

        /// <summary>
        /// Функция подключения к базе данных
        /// </summary>
        /// <param name="ip">переменная для ввода IP-адреса сервера</param>
        /// <param name="port">переменная для ввода порта сервера</param>
        /// <param name="filename">переменаная файла с БД</param>
        /// <param name="pass">переменная пароля</param>
        /// <param name="user">переменная юзера</param>
        /// <returns></returns>
        public string Connect(string ip,string port, string user, string pass, string filename)
        {
            //проверка на корректность порта
            if (!int.TryParse(port, out var _port)) return "Введенный порт некорректный";
            if (ip != "localhost")
            {
                if (!IPAddress.TryParse(ip, out var _ip)) return "Некорректный IP-адрес";
                ip = _ip.ToString();
            }
            if(fbconnection != null)
            {
                if (fbconnection.State == System.Data.ConnectionState.Open) 
                    return "Сервер работает";
            }
            if (pass != "masterkey" || user != "SYSDBA") 
                return "Пароль или имя пользователя не верны";
            if (filename == "") return "Вы не выбрали базу данных";

            FbConnectionStringBuilder builder = new FbConnectionStringBuilder();
            builder.UserID = user;
            builder.Password = pass;
            builder.Database = filename;
            builder.ServerType = 0;
            builder.Port = _port;
            builder.DataSource = ip;
            
            try
            {
                fbconnection = new FbConnection(builder.ToString());
                
                //проверка на доступность сервера
                fbconnection.Open();
                status = true;
                fbconnection.Close();
                fbconnection.Dispose();

                return "Подключение установлено";
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
        }

        public bool statusOpen()
        {
            return status;
        }

        /// <summary>
        /// Вывод информации о базе данных
        /// </summary>
        /// <returns></returns>
        public string InfoDataBase()
        {
            if( fbconnection == null && fbconnection?.State != System.Data.ConnectionState.Open ) 
                return "Соединение не установлено";
            fbconnection.Open();
            FbDatabaseInfo DataBaseInfo = new FbDatabaseInfo(fbconnection);

            string DataBaseInformation=$"Info Класс сервера={DataBaseInfo.GetServerClass()} \n" +
                $"Версия сервера={DataBaseInfo.GetServerVersion()} \n" +
                $"Версия протокола={DataBaseInfo.GetProtocolVersion()}";
            fbconnection.Close();
            fbconnection.Dispose();
            return DataBaseInformation;
        }
    }
}

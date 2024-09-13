using FirebirdSql.Data.FirebirdClient;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientForm.Classes
{
    /// <summary>
    /// Функции для БД
    /// </summary>
    public class CommandDB
    {
        private FbConnection fbConnection { get; set; }

        public CommandDB(FbConnection fbConnection)
        {
            this.fbConnection = fbConnection;
        }

        
        /// <summary>
        /// Функция загрузки данных
        /// </summary>
        /// <returns></returns>
        public List<Users> LoadUser()
        {
            fbConnection.Open();
            List<Users> users = new List<Users>();

            using(var FBcommand = new FbCommand("SELECT NAME, AGE, DATE_ADD FROM USERS",fbConnection))
            {
                using(var reader = FBcommand.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        users.Add(
                            new Users(name: reader["NAME"].ToString(),
                            age: Convert.ToInt32(reader["AGE"]),
                            date: Convert.ToDateTime(reader["DATE_ADD"]).ToString("dd:MM:yyyy"))
                            );
                    }
                }
            }
            fbConnection.Close();
            fbConnection.Dispose();
            return users;
        }

        /// <summary>
        /// Функция добавления пользователя
        /// </summary>
        /// <param name="name">ФИО пользователя</param>
        /// <param name="age">Возраст</param>
        /// <param name="datetime">Время добавления</param>
        /// <returns></returns>
        public string AddUser(string name, int age)
        {
            var user = new Users(name, age, DateTime.Now.ToString());
            if (CheckDublicate(user)) return "Вы пытаетесь создать дубликат";
            
            fbConnection.Open();
            
            using (var FBcommand = new FbCommand($"INSERT INTO USERS (NAME,AGE,DATE_ADD)" +
                $" VALUES ('{user.name}',{user.age}," +
                $"DATE '{Convert.ToDateTime(user.date).ToString("yyyy-MM-dd")}')",fbConnection))
            {
                FBcommand.ExecuteNonQuery();
            }
            
            fbConnection.Close();
            fbConnection.Dispose();
            return "Запись успешно добавлена";
        }

        /// <summary>
        /// Проверка на дубликат в БД
        /// </summary>
        /// <param name="user">пользователь, которого хотим создать</param>
        /// <returns></returns>
        private bool CheckDublicate(Users user)
        {
            fbConnection.Open();

            using (var FBcommand = new FbCommand("SELECT NAME, AGE FROM USERS", 
                fbConnection))
            {
                using (var reader = FBcommand.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        if (reader["NAME"].ToString() == user.name &&
                            Convert.ToInt32(reader["AGE"]) == user.age)
                        {
                            fbConnection.Close();
                            fbConnection.Dispose();
                            return true;
                        }
                    }
                }
            }

            fbConnection.Close();
            fbConnection.Dispose();
            return false;
        }
    }
}

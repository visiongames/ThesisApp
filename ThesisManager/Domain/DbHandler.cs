using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;
using System.Threading;
using ThesisManager.Models;

namespace ThesisManager.Domain
{
    public class DbHandler
    {
        public SQLiteConnection dbConnection;

        public void DBInit()
        {
            DbConnect();
        }

        public void CreateDatabaseTable()
        {
            //init creation of db
            if (!File.Exists("./database.sqlite3"))
            {
                SQLiteConnection.CreateFile("database.sqlite3");
                System.Console.WriteLine("DB created");
            }
            
        }
        public void DbConnect()
        {
            dbConnection = new SQLiteConnection("Data Source=database.sqlite3");
            if (dbConnection.State == System.Data.ConnectionState.Closed)
            {
                dbConnection.Open();
                
            }
        }

        public void DbDisconnect()
        {
            if (dbConnection.State == System.Data.ConnectionState.Open)
            {
                dbConnection.Close();
            }
        }

        public void AddUser(string userName, string userPassword)
        {
            string initQuery = "INSERT INTO Users ('UserName', 'UserPassword') VALUES (@UserName, @UserPassword)";
            SQLiteCommand initCommand = new SQLiteCommand(initQuery, dbConnection);
            initCommand.Parameters.AddWithValue("@UserName", userName);
            initCommand.Parameters.AddWithValue("@UserPassword", userPassword);
            initCommand.ExecuteNonQuery();
        }

        public bool CheckUserData(string userName, string userPassword)
        {
            Console.WriteLine("Check user method was called");
            DbConnect();
            string userQuery = "SELECT * FROM Users";
            SQLiteCommand userCheckCommand = new SQLiteCommand(userQuery, dbConnection);
            SQLiteDataReader resultData = userCheckCommand.ExecuteReader();
            if (resultData.HasRows)
            {
                while (resultData.Read())
                {
                    Console.WriteLine(resultData["UserName"]);
                    Console.WriteLine(resultData["UserPassword"]);
                    if ((string)resultData["UserName"] == userName && (string)resultData["UserPassword"] == userPassword)
                    {
                        Console.WriteLine("User exist");
                        return true;
                        
                    }
                }
            }

            DbDisconnect();
            return false;
        }   

        public void AddThesis(ThesisModel thesisToAdd)
        {
            DbConnect();
            string initQuery = "INSERT INTO Thesis ('emailAdres', 'studentIndexNumber', 'studentName', 'studentLastName', 'degree', 'studentSpecialization', 'fieldOfStudy', 'teacherAdvisorName', 'thesisDateCreation', 'topicOfThesisEnglish', 'topicOfThesisPolish', 'typeOfLearning') VALUES (@emailAdres, @studentIndexNumber, @studentName, @studentLastName, @degree, @studentSpecialization, @fieldOfStudy, @teacherAdvisorName, @thesisDateCreation, @topicOfThesisEnglish, @topicOfThesisPolish, @typeOfLearning)";
            SQLiteCommand thesisCommand = new SQLiteCommand(initQuery, dbConnection);
            thesisCommand.Parameters.AddWithValue("@emailAdres", thesisToAdd.EmailAdres);
            thesisCommand.Parameters.AddWithValue("@studentIndexNumber", thesisToAdd.StudentIndexNumber);
            thesisCommand.Parameters.AddWithValue("@studentName", thesisToAdd.StudentName);
            thesisCommand.Parameters.AddWithValue("@studentLastName", thesisToAdd.StudentLastName);
            thesisCommand.Parameters.AddWithValue("@degree", thesisToAdd.Degree);
            thesisCommand.Parameters.AddWithValue("@studentSpecialization", thesisToAdd.StudentSpecialization);
            thesisCommand.Parameters.AddWithValue("@fieldOfStudy", thesisToAdd.FieldOfStudy);
            thesisCommand.Parameters.AddWithValue("@teacherAdvisorName", thesisToAdd.TeacherAdvisorName);
            thesisCommand.Parameters.AddWithValue("@thesisDateCreation", thesisToAdd.ThesisDateCreation);
            thesisCommand.Parameters.AddWithValue("@topicOfThesisEnglish", thesisToAdd.TopicOfThesisEnglish);
            thesisCommand.Parameters.AddWithValue("@topicOfThesisPolish", thesisToAdd.TopicOfThesisPolish);
            thesisCommand.Parameters.AddWithValue("@typeOfLearning", thesisToAdd.TypeOfLearning);

            thesisCommand.ExecuteNonQuery();
            Console.WriteLine("Add thesis was called in DbHandler");
            DbDisconnect();
        }

        public void GetAllThesis()
        {

        }

        public void UpdateThesis(){

        }

        public void RemoveThesis()
        {

        }
    }
}

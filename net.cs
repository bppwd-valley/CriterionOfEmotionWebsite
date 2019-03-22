using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

class Program
{
    static void Main(string[] args)
    {
        string sql;
        SQLiteCommand cmd;

        SQLiteConnection.CreateFile("DB.sqlite");
        SQLiteConnection db_connection = new SQLiteConnection("Data Source=DB.sqlite;");
        db_connection.Open();

        sql = "create table users (name varchar(20))";
        cmd = new SQLiteCommand(sql, db_connection);
        cmd.ExecuteNonQuery();

        sql = "insert into users (name) values ('Damon')";
        cmd = new SQLiteCommand(sql, db_connection);
        cmd.ExecuteNonQuery();

        sql = "select * from users order by name asc";
        cmd = new SQLiteCommand(sql, db_connection);
        SQLiteDataReader reader = cmd.ExecuteReader();
        while (reader.Read())
            System.Diagnostics.Debug.WriteLine("Name: " + reader["name"]);
    }
}

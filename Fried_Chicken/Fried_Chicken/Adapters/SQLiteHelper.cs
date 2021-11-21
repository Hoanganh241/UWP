using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLitePCL;
using Windows.Storage;
using System.IO;

namespace Fried_Chicken.Adapters
{
    class SQLiteHelper
    {
        private readonly string dbame = "chicken.db";

        private static SQLiteHelper instance;


        private SQLiteHelper()
        {
            string path = Path.Combine(ApplicationData.Current.LocalFolder.Path, dbName);
            SQLiteConnection = new SQLiteConnection(path); //tao ket noi db SQLite


            //Tao bang Cart: Id Name Image, Price, Qty
            var sql_txt = @"create table if not exists Cart(Id integer primary key, Name var(255), Image varchar(255), Price integer, Qty integer)";
            var statement = SQLiteConnection.Prepare(sql_txt);
            statement.Step();
        }
        public SQLiteConnection SQLiteConnection { get; set; }


        
        public static SQLiteHelper GetInstance()
        {
            if (instance == null)
                instance = new SQLiteHelper();
            return instance;

        }

    }
}

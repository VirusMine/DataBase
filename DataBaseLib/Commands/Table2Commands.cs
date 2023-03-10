using DataBaseLib.Access;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseLib.Commands
{
    internal class Table2Commands : ITableEditorCommand
    {
        // ЕСЛИ нужна другая БД, просто меняем AccessDataBaseController
        // на нужную, например SQLiteDataBaseController
        // в следующей строке
        private AccessDataBaseController controller = new AccessDataBaseController();

        public void Select(string[] args)
        {

        }

        public void Insert(string[] args)
        {            
            string query = $"INSERT INTO [Автомобили] " +
                    $"([Код], [Модель], [Цвет], [Бренд], [Цена]) " +
                    $"VALUES ({args[0]}, '{args[1]}','{args[2]}','{args[3]}',{args[4]})";
            controller.ExecuteCommand(query);
        }

        public void Update(string[] args)
        {
            string query = @$"UPDATE [Автомобили]
                    SET [Модель] = '{args[1]}',[Цвет] = '{args[2]}',[Бренд] = '{args[3]}',[Цена] = '{args[4]}'
                    WHERE [Код] = {args[0]}";
            controller.ExecuteCommand(query);
        }

        public void Delete(string[] args)
        {
            string query = $"DELETE FROM [Автомобили] " +
                    $"WHERE [Код] = {args[0]}";
            controller.ExecuteCommand(query);
        }


    }
}

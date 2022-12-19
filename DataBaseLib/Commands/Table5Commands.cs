using DataBaseLib.Access;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseLib.Commands
{
    internal class Table5Commands : ITableEditorCommand
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
            string query = $"INSERT INTO [Персонал] " +
                    $"([Код], [Фамилия], [Имя], [Отчество]) " +
                    $"VALUES ({args[0]}, '{args[1]}', '{args[2]}', '{args[3]}')";
            controller.ExecuteCommand(query);
        }

        public void Update(string[] args)
        {
            string query = @$"UPDATE [Персонал]
                    SET [Фамилия] = '{args[1]}', [Имя] = '{args[2]}', [Отчество] = '{args[3]}'
                    WHERE [Код] = {args[0]}";
            controller.ExecuteCommand(query);
        }

        public void Delete(string[] args)
        {
            string query = $"DELETE FROM [Персонал] " +
                    $"WHERE [Код] = {args[0]}";
            controller.ExecuteCommand(query);
        }


    }
}

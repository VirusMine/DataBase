using DataBaseLib.Access;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseLib.Commands
{
    internal class Table1Commands : ITableEditorCommand
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
            string query = $"INSERT INTO [Продажи] " +
                    $"([Код продажи], [Код кроссовок], [Клиент], [Цена], [Персонал], [Код филиала]) " +
                    $"VALUES ({args[0]}, {args[1]}, {args[2]}, {args[3]}, {args[4]}, {args[5]})";
            controller.ExecuteCommand(query);
        }

        public void Update(string[] args)
        {
            string query = @$"UPDATE [Продажи]
                    SET [Код кроссовок] = {args[1]}, [Клиент] = {args[2]}, [Цена] = {args[3]}, [Персонал] = {args[4]} ,[Код филиала]={args[5]}
                    WHERE [Код продажи] = {args[0]}";
            controller.ExecuteCommand(query);
        }

        public void Delete(string[] args)
        {
            string query = $"DELETE FROM [Продажи] " +
                    $"WHERE [Код продажи] = {args[0]}";
            controller.ExecuteCommand(query);
        }


    }
}

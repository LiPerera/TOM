using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace MvcTOM.Models
{
    public class QueryTask:IQueryTask
    {
        private ConnectMySQL Conn = new ConnectMySQL();

        public int Insert(Tasks TaskTable)
        {
            int flag = 0;

            try
            {
                string Query = " insert into Tom_Tasks(Task_id, Task_name, Description, Task_status)" +
                               " values ("+ TaskTable.TASK_ID + ", '" + TaskTable.TASK_NAME + "', '" + TaskTable.DESCRIPTION + "', '" +
                               TaskTable.TASK_STATUS + "' )";

                
                Conn.Connection();
                Conn.TomCon.Open();
                Conn.TomCommand.CommandText = Query;
                Conn.TomCommand.ExecuteNonQuery();
                Conn.TomCon.Close();
            }
            catch {

                flag = 1;
            }

            return flag;

        }

        public List<Tasks> Show()
        {
            List<Tasks> listTasks = new List<Tasks>();

            try{
                string Query = "SELECT TASK_ID,TASK_NAME,DESCRIPTION,TASK_STATUS FROM tom_tasks";
                Conn.Connection();

                Conn.TomCon.Open();
                Conn.TomDta.SelectCommand.CommandText=Query;

                DataTable dt = new DataTable();
                Conn.TomDta.Fill(dt);
                Conn.TomCon.Close();

                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        Tasks task = new Tasks
                        {
                            TASK_ID = Convert.ToInt32(dt.Rows[i]["task_id"]),
                            TASK_NAME = (string)dt.Rows[i]["task_name"],
                            DESCRIPTION = (string)dt.Rows[i]["description"],
                            TASK_STATUS = (string)dt.Rows[i]["task_status"]
                        };
                        listTasks.Add(task);
                    }
                }


            }
            catch{
            }

            return listTasks;
        }
    }
}
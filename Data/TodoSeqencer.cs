using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoIT.Data
{
    public class TodoSeqencer
    {
        private static int todoId = 0;

        public static int nextTodoId()
        {
            return ++todoId;
        }
        public static int reset()
        {
            todoId = 0;
            return todoId;
        }







    }
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace TodoLibrary
{
    public class TodoItem
    {
        private object _number;
        private object _task;
        private object _checked;

        public object Number { get => _number; set => _number = value; }
        public object Task { get => _task; set => _task = value; }
        public object Checked { get => _checked; set => _checked = value; }

        public TodoItem(object n, object t, object c)
        {
            Number = n;
            Task = t;
            Checked = c;
        }

        public bool IsChecked()
        {
            return Convert.ToBoolean(Checked);
        }

        public string GetTask()
        {
            return Task.ToString();
        }

        public string GetNumber()
        {
            return Number.ToString();
        }

        public override string ToString()
        {
            return $"Номер: {GetNumber()}\t Выполнен: {IsChecked()}\t Задание: {GetTask()}";
        }
    }

    public class TodoList<T> : List<T>
    {
        private List<T> _list;

        public TodoList()
        {
            _list = new List<T>();
        }

       public void SetList(List<T> setList)
        {
            _list.AddRange(setList);
        }
    }
}

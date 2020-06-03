using System;
using System.Collections;
using System.Collections.Generic;

namespace IteratorTest
{
    public class CommandCenter
    {
        private readonly IDictionary<string, Action<dynamic>> commands;
        private ListIterator list;

        public CommandCenter()
        {
            this.list = new ListIterator();
            commands = new Dictionary<string, Action<dynamic>>()
            {
                {"Create", item => this.list = ListIterator.Create(item)},
                {"Move", item => Console.WriteLine(this.list.Move())},
                {"HasNext", item => Console.WriteLine(this.list.HasNext())},
                {"Print", item => this.list.Print()}
            };
        }

        public void Run(string command)
        {
            commands[command.Split(' ')[0]](command);
        }
    }
}

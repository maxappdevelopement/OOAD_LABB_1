using System;
using System.Collections.Generic;
using System.Linq;

namespace OOAD_LABB_1
{
    class CommandManager
    {
        private static CommandManager instance = null;
        private Stack<Command> commands;
        private Stack<Command> commandsReverse;

        public static CommandManager getInstance()
        {
            if (instance != null)
                return instance;
            return new CommandManager();
        }

        private CommandManager()
        {
            commands = new Stack<Command>();
            commandsReverse = new Stack<Command>();
        }

        public void Execute(Command command)
        {
                command.Execute();
                commands.Push(command);             
        }

        public void Undo()
        {
           if (commands.Count == 0) { return; }            
           
           Command command = commands.Pop();                           
           if (commands.Count > 0) 
           { 
                Command penultimate = commands.ElementAt(0);
                penultimate.Undo();
                commandsReverse.Push(command);
           }                                
        }

        public void UndoAll()
        {
            while (commands.Count > 0)
            {
                Command command = commands.Pop();
                command.Undo();
            }
        }   
        
        public void Redo()
        {   
            if (commandsReverse.Count > 0) 
            { 
                Command command = commandsReverse.Pop();
                command.Redo();
                commands.Push(command);
            }
        }
    }
}





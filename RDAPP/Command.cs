using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RDPCOMAPILib;
using AxRDPCOMAPILib;
using System.Runtime.InteropServices;

namespace RDAPP
{
    //Interface for commands
    public interface Command
    {
        List<string> Execute();
    }

    //Class to handle Switching
    public class Switch
    {
        private List<Command> _commands = new List<Command>();
        public List<string> StoreAndExecute(Command command)
        {
            _commands.Add(command);
            return command.Execute();

        }
    }

    public class ActiveWindowList : Command
    {
        private Triger _oppetation;
        private RDPSession _currentSession;

        public ActiveWindowList
            (Triger Opperation,RDPSession currentSession)
        {
            _oppetation = Opperation;
            _currentSession = currentSession;
        }

        public List<String> Execute()
        {
           return  _oppetation.ActiveList(_currentSession);
        }
    }
}

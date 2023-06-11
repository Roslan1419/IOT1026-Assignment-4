// Change to 'using Assignment.InterfaceCommand' when you are ready to test your interface implementation
using Assignment.InterfaceCommand;

namespace Assignment
{
    public class Robot
    {
        // These are properties, you can replace these with traditional getters/setters if you prefer.
        public int NumCommands { get; }

        // These properties are not good! The setter allows
        // us to move the robot even if it's off
        public int X { get; set; }
        public int Y { get; set; }
        public bool IsPowered { get; set; }

        private const int DefaultCommands = 6;
        // An array is not the preferred data structure here.
        // You will get bonus marks if you replace the array with the preferred data structure
        // Hint: It is NOT a list either.
        private readonly IRobotCommand[] _commands;
        private int _commandsLoaded = 0;

        public override string ToString()
        {
            return $"[{X} {Y} {IsPowered}]";
        }

        // You should not have to use any of the methods below here, but you should
        // provide XML documentation for the parameterized constructor, the Run method, and one
        // of the LoadCommand methods.
        public Robot() : this(DefaultCommands) { }

        /// <summary>
        /// Constructor that initializes the robot with the capacity to store a user-specified
        /// number of commands.
        /// </summary>
        /// <param name="numCommands">The maximum number of commands the robot can store</param>
        public Robot(int numCommands)
        {
            _commands = new IRobotCommand[numCommands];
            NumCommands = numCommands;
        }

        /// <summary>
        /// Executes the loaded commands sequentially.
        /// </summary>
        public void Run()
        {
            for (var i = 0; i < _commandsLoaded; ++i)
            {
                _commands[i].Run(this);
                Console.WriteLine(this);
            }
        }

        /// <summary>
        /// Loads a command into the robot's command storage.
        /// </summary>
        /// <param name="command">The command to load</param>
        /// <returns>True if the command was successfully loaded, False otherwise</returns>
        public bool LoadCommand(IRobotCommand command)
        {
            if (_commandsLoaded >= NumCommands)
                return false;
            _commands[_commandsLoaded++] = command;
            return true;
        }
    }
}

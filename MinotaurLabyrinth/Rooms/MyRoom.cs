namespace MinotaurLabyrinth
{
    // Make your own unique and fun/creative room! There will be lots of marks for creativity if you aren't able to get your head around
    // how to program something extravagent.

    // 1. Add your Room to the list of enums on line 60 in the Utils.cs file
    // 2. Add the code 'AddRooms(RoomType.MyRoom, map);' to the LabyrinthCreator.cs file below where the Pit room is added (line 48)
    // 3. Implement the Activate, Display and DisplaySense methods.
    // 4. Add documentation and a description of your room (any maybe an image?) to the README.
    public class MyRoom : Room
    {
        static MyRoom()
        {
            RoomFactory.Instance.Register(RoomType.MyRoom, () => new MyRoom());
        }

        /// <inheritdoc/>
        public override RoomType Type { get; } = RoomType.MyRoom;

        /// <inheritdoc/>
        public override bool IsActive { get; protected set; } = true;

        public override void Activate(Hero hero, Map map)
        {

        }

        /// <inheritdoc/>
        public override DisplayDetails Display()
        {
            return IsActive ? new DisplayDetails($"[{Type.ToString()[0]}]", ConsoleColor.Red)
                   : base.Display();
        }

        public override bool DisplaySense(Hero hero, int heroDistance)
        {
            return false;
        }
    }
}

using Command_Pattern;

class Program
{
    static void Main(string[] args)
    {
        Character character = new Character();
        ICommand Move= new MoveForwards(character);
        ICommand Attack = new AttackCommand(character);
        ICommand Stop = new StoppedMoving(character);

        RemoteControl remote = new RemoteControl();

        // Make the robot dance
        remote.SetCommand(Move);
        remote.DoAction();


        // Make the robot spin
        remote.SetCommand(Attack);
        remote.DoAction();
        remote.UndoAction();

        remote.SetCommand(Stop);
        remote.DoAction();
    }
}

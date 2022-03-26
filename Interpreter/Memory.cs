namespace PixelBasic;

public class Memory
{
    private Dictionary<string, Value> memory = new Dictionary<string, Value>();

    public Value get(string name)
    {
        return memory[name];
    }
    
    public void assign(string name, Value value)
    {
        memory[name] = value;
    }

    public void free()
    {
        memory.Clear();
    }
}
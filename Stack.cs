namespace MTCG_project;

public abstract class Stack
{
    private List<Stack> _stacks = [];

    public abstract void AddStack(Stack stack);
}
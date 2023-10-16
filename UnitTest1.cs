namespace Project2;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        Assert.Pass();
    }
}

public interface ITraversable<T>
{
    IEnumerator<T> PreOrder();
    
    IEnumerator<T> InOrder();
    IEnumerator<T> PostOrder();
}
public class BinaryTree<T> where T : IComparable<T>
{
    BSTNode<T>? root = null;

    private  BSTNode<T> FindNode(T value)
    {
        if(root is null || root.GetValue().CompareTo(value) == 0)
        {
            return null;
        }
        else if (value.CompareTo());
      
    }
}
public class BSTNode<T> 
{
    private T value;
    private BSTNode<T> left;
    private BSTNode<T> right;

    public T GetValue {get; set;}
    public BSTNode(T value, BSTNode<T> left, BSTNode<T> right)
    {
        this.value = value;
        this.left = left;
        this.right = right;
    }

    public List<T> PreOrderVisitor()
    {
        List<T> toReturn = new List<T>();
        PreOrderNonVisitor(new Accumulator<T>(toReturn));
        return toReturn;
    }
    public List<T> PreOrderNonVisitor(List<T>? toReturn = null)
    {
        if (toReturn is not null)
        {
            toReturn = new List<T>();
        }
        if (left is not null)
        {
            left.PreOrderNonVisitor(toReturn);
        }
        if (right is not null)
        {
            right.PreOrderNonVisitor(toReturn);
        }

        return toReturn;

    }
    public void Add(T value)
    {

    }

}
public interface IVisitor<T>
{
    public void Visit(T visitor);
}
public class Accumulator<T> : IVisitor<T>
{
    private List<T> accumulated;

    public Accumulator(List<T> whereToAccumulate)
    {
        accumulated = whereToAccumulate;
    }
    public void Visit(T value)
    {
        accumulated.Add(value);
    }
}
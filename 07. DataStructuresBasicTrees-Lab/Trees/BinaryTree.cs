using System;

public class BinaryTree<T>
{
    public T Value { get; set; }

    public BinaryTree<T> LefChild { get; set; }

    public BinaryTree<T> RightChild { get; set; }

    public BinaryTree(T value, BinaryTree<T> leftChild = null, BinaryTree<T> rightChild = null)
    {
        this.Value = value;
        this.LefChild = leftChild;
        this.RightChild = rightChild;
    }

    public void PrintIndentedPreOrder(int indent = 0)
    {
        Console.Write(new string(' ', 2 * indent));
        Console.WriteLine(this.Value);

        if (this.LefChild != null)
        {
            this.LefChild.PrintIndentedPreOrder(indent + 1);
        }
        if (this.RightChild != null)
        {
            this.RightChild.PrintIndentedPreOrder(indent + 1);
        }
    }

    public void EachInOrder(Action<T> action)
    {
        if (this.LefChild != null)
        {
            this.LefChild.EachInOrder(action);
        }

        action(this.Value);
        if (this.RightChild != null)
        {
            this.RightChild.EachInOrder(action);
        }
    }

    public void EachPostOrder(Action<T> action)
    {
        if (this.LefChild != null)
        {
            this.LefChild.EachPostOrder(action);
        }
        if (this.RightChild != null)
        {
            this.RightChild.EachPostOrder(action);
        }
        action(this.Value);
    }
}

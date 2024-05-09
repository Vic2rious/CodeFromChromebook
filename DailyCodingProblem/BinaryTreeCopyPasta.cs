//Victor Ivanov 11/6

using System;
using System.Text;

public class BinaryTree_VictorIvanov {
  public static void Main (string[] args){

    Node<string> root = new Node<string>() { Data = "root" };
  root.Left = new Node<string>() { Data = "1" };
  root.Right = new Node<string>() { Data = "2" };

  root.Left.Left = new Node<string>() { Data = "3" };
  root.Left.Right = new Node<string>() { Data = "4" };

  Console.WriteLine(root.displayNode());
  }
}

public class Node<T>
{
    public T Data { get; set; }
    public Node<T> Left { get; set; }
    public Node<T> Right { get; set; }

    public string displayNode()
    {
        StringBuilder output = new StringBuilder();
        displayNode(output, 0);
        return output.ToString();
    }

    private void displayNode(StringBuilder output, int depth)
    {

        if (Right != null)
            Right.displayNode(output, depth+1);

        output.Append('\t', depth);
        output.AppendLine(Data.ToString());


        if (Left != null)
            Left.displayNode(output, depth+1);

    }
}

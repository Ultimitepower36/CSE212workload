using System.Security.Cryptography.X509Certificates;

public class Node {
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data) {
        this.Data = data;
    }

    public void Insert(int value) {
        if (Data != value){
            if (value < Data) {
                // Insert to the left
                if (Left is null)
                    Left = new Node(value);
                else
                    Left.Insert(value);
            }
            else {
                // Insert to the right
                if (Right is null)
                    Right = new Node(value);
                else
                    Right.Insert(value);
            }
        }
    }

    public bool Contains(int value) {
        // TODO Start Problem 2
        if (Data != value){
            if (value < Data) {
                if (Left is null)
                    return false;
                else
                    return Left.Contains(value);
            }
            else {
                if (Right is null)
                    return false;
                else
                    return Right.Contains(value);
            }
        }
        return true;
    }

    public int GetHeight() {
        // TODO Start Problem 4
        var x = 0;
        var y = 0;
        if (Right is not null){
            x = Right.GetHeight();
        }
        if (Left is not null){
            y = Left.GetHeight();
        }
        if (x > y){
            return x + 1;
        }
        else{
            return y + 1;
        }
        
    }
}
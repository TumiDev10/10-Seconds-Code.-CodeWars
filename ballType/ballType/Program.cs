// See https://aka.ms/new-console-template for more information


/*
 Create a class Ball. Ball objects should accept one argument for "ball type" when instantiated.

If no arguments are given, ball objects should instantiate with a "ball type" of "regular."
*/
public class Ball
{
    public string ballType { get; set; }

    public Ball(string ballType = "regular")
    {
        this.ballType = ballType;
    }
}

using NUnit.Framework;

[TestFixture]
public class Tests
{
    [Test]
    public void Count()
    {
        char[] input1 = "while is a while loop".ToCharArray();
        char[] input2 = "WhilE is a whilE loop".ToCharArray();

        Assert.AreEqual(2, Program.Count(input1));
        Assert.AreEqual(2, Program.Count(input2));
    }

    [Test]
    public void Change()
    {
        char[] input1 = "while is a while loop".ToCharArray();
        char[] input2 = "WhilE is a whilE loop".ToCharArray();

        char[] result1 = Program.Change(input1);
        char[] result2 = Program.Change(input2);

        Assert.AreEqual("** is a ** loop", new string(result1).TrimEnd('\0'));
        Assert.AreEqual("** is a ** loop", new string(result2).TrimEnd('\0'));
    }
}
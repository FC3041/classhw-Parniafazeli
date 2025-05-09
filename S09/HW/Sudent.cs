public class Student
{
    public string name;
    public int stdid;
    public int natid;
    public int credits;
    public bool active;
      
    public Student(string name, int stdid, int natid, int credits, bool active)
    {
        this.name = name;
        this.stdid = stdid;
        this.natid = natid;
        this.credits = credits;
        this.active = active;
    }

    public override string ToString() =>
        $"{name},{stdid},{natid},{credits},{active}";
}
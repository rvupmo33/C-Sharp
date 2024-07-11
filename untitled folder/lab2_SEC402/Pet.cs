// namespace lab2_SEC402;

public class Pet
{
    public string Name { get; }
    public string Owner { get; private set; }
    public int Age { get; }
    public string Description { get; }
    public bool IsHouseTrained { get; private set; }


    public Pet(
        string name, int age, string description)
    {
        Name = name;
        Age = age;
        Description = description;
        Owner = "none";
        IsHouseTrained = false;
    }

    public override string ToString()
    {
        return
            $"Pet details:\nName: {Name}\nAge: {Age}\nDescription: {Description}\nOwner: {Owner}\nisHouseTrained: {IsHouseTrained}\n";
    }

    public void Train()
    {
        IsHouseTrained = true;
    }

    public void SetOwner(string newOwner)
    {
        Owner = newOwner;
    }

}
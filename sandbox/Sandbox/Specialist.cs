public class Specialist
{
    private string _gender;
    private string _lastName;
    private string _specialty;

    pubic Teacher(string gender, string lastName, string specialty)
    {
        _gender = gender;
        _lastName = lastName;
        _specialty = specialty;

    }

    
   
    public void AddTeacher(Teacher theteacher)
    {
        _Teacher.Add(theteacher);
    }
}
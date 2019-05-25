using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class GradeSchool
{
    private readonly IDictionary<string, int> _studentList = new Dictionary<string, int>();
    public void Add(string student, int grade)
    {
        _studentList.Add(student, grade);
    }

    public IEnumerable<string> Roster()
    {
        return _studentList.OrderBy(x => x.Value).ThenBy(x => x.Key).Select(x => x.Key).ToArray();
    }

    public IEnumerable<string> Grade(int grade)
    {
        return _studentList.OrderBy(x => x.Key).Where(x => x.Value == grade).Select(x => x.Key);
    }
}
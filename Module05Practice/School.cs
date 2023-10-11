using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module05Practice
{
    public class School
    {
        public void CallStudentMethod()
        {
            Student student = new Student();
            try
            {
                student.DoSomething();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Возникло исключение: {ex.Message}");
            }
        }
    }
}

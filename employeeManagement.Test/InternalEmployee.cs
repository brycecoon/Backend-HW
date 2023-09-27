namespace employeeManagement.Test
{
    internal class InternalEmployee
    {
        public IEnumerable<object> Salary { get; internal set; }

        public static explicit operator InternalEmployee(void v)
        {
            throw new NotImplementedException();
        }
    }
}
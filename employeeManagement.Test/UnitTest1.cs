 namespace employeeManagement.Test;

public class UnitTest1
{
    [Fact]
    public void method_scenario_result()
    {
        //arrange
        var employeeFactory = new EmployeeFactory();

        //act
        var employee = (InternalEmployee)employeeFactory
            .Create("Kevin", "Dockx");


    //assert
        Assert.Equal(2500, employee.Salary);
    }
}
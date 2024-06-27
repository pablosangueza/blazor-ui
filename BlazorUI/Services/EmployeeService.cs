using System.Net.Http.Json;

namespace BlazorUI.Services;

public class EmployeeService
{
    private readonly HttpClient _httpClient;
    
    public EmployeeService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<Employee[]> GetEmployeesAsync()
    {
        Console.WriteLine("call employee api");
        
        return await _httpClient.GetFromJsonAsync<Employee[]>("http://localhost:5172/Employees");
    }
}

public class Employee
{
    public int Id { get; set; }
    public string FullName { get; set; }
    public string Birth { get; set; }
}

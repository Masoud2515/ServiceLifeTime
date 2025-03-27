using Interface;

namespace Application.Business;

public class GetRandomNumber : IGenerateNumber
{
    private readonly int _number;
    public GetRandomNumber()
    {
        Random random = new Random();
        _number = random.Next(100, 999);
    }
    public Task<int> GetNumber() 
    {
        
        return Task.FromResult(_number);
    }
}

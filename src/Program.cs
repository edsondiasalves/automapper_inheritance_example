using AutoMapper;

namespace automapper.src;
public class AutomapperSrc
{
    static void Main(string[] args)
    {
        var config = new MapperConfiguration(cfg => {
            cfg.AddProfile(new BaseDestinationEntityProfile());
            cfg.AddProfile(new DestinationEntityProfile());
        });
        var mapper = config.CreateMapper();

        var source = new SourceEntity{ Id2 = 1, Name2 = "Edson", Age2 = 35 };
        var destination1 = mapper.Map<BaseDestinationEntity>(source);
        var destination2 = mapper.Map<DestinationEntity>(source);

        Console.WriteLine(destination1);
    }
}

public class SourceEntity
{
    public int Id2 { get; set; }
    public string? Name2 { get; set; }
    public int Age2 { get; set; }
}

public class BaseDestinationEntity
{
    public int Id { get; set; }
    public string? Name { get; set; }
}

public class DestinationEntity: BaseDestinationEntity
{
    public int Age { get; set; }
}
using Xunit;
using FluentAssertions;
using AutoMapper;
using automapper.src;

namespace automapper.test;

public class AutoMapperTest
{
    IMapper mapper;

    public AutoMapperTest()
    {
        var config = new MapperConfiguration(cfg => {
            cfg.AddProfile(new BaseDestinationEntityProfile());
            cfg.AddProfile(new DestinationEntityProfile());
        });
        
        mapper = config.CreateMapper();
    }

    [Fact]
    public void MapBaseDestinationEntityTest()
    {
        //Arrange
        var source = new SourceEntity{ Id2 = 1, Name2 = "Peter", Age2 = 3 };
        var expected = new BaseDestinationEntity{ Id = 1, Name = "Peter" };
        
        //Act
        var destination = mapper.Map<BaseDestinationEntity>(source);

        //Assert
        destination.Should().BeEquivalentTo(expected);
    }

    [Fact]
    public void MapDestinationEntityTest()
    {
        //Arrange
        var source = new SourceEntity{ Id2 = 1, Name2 = "Peter", Age2 = 3 };
        var expected = new DestinationEntity{ Id = 1, Name = "Peter", Age = 3 };
        
        //Act
        var destination = mapper.Map<DestinationEntity>(source);

        //Assert
        destination.Should().BeEquivalentTo(expected);
    }
}
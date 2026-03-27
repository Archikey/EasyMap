using EasyMap;
using EasyMap.MapData;
using TestEasyMap.DTO;
using TestEasyMap.Entity;
using EasyMap.FactoryObjects;

namespace TestEasyMap
{
    public class TestProject
    {

        private readonly IMapData<UserDTO, UserEntity> _mapData;
        private readonly IObjectFactory _objectFactory;

        public TestProject()
        {
            _mapData = new MapData<UserDTO, UserEntity>();
            _objectFactory = new ObjectFactory();

        }


        [Fact]
        public void TestMapBase()
        {
            var userDTO = CreateUserDTO();

            var result = _mapData.Map(userDTO);

            Assert.Equal(result.Name, userDTO.Name);
            Assert.Equal(result.Password, userDTO.Password);
            Assert.Equal(result.Email, userDTO.Email);




        }

        [Fact]
        public void TestCreateCustomObject()
        {
            var keyValuePairs = new Dictionary<string, object?>
            {
                ["Name"] = "Alex",
                ["Age"] = 25
            };

            dynamic obj = _objectFactory.CreateCustomObject(keyValuePairs);


            Assert.Equal(obj.Name, keyValuePairs["Name"]);
            Assert.Equal(obj.Age, keyValuePairs["Age"]);

        }




        private UserDTO CreateUserDTO()
        {
            return new UserDTO
            {
                Name = "John Doe",
                Password = "password123",
                RepiatPassword = "password123",
                Email = "hello@world.email"
            };
        }
    }
}

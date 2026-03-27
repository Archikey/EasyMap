using EasyMap;
using TestEasyMap.DTO;
using TestEasyMap.Entity;

namespace TestEasyMap
{
    public class TestMap
    {

        private readonly IMapData<UserDTO, UserEntity> _mapData;

        public TestMap()
        {
            _mapData = new MapData<UserDTO, UserEntity>();

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

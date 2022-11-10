using Newtonsoft.Json;

namespace Web.Dtos.UserSelfInfoDto.Profile
{
    public class OutputPermissionSelfInfoDto
    {
        public int ResourceId { get; set; }
        public bool Read { get; set; }
        public bool Write { get; set; }
        public bool Delete { get; set; }
        public bool Right { get; set; }
    }
}
